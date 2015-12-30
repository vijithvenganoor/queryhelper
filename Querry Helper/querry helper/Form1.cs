using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Querry_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection connection()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string cons = "server="+txtServer.Text+";User Id="+txtID.Text+";password="+txtPwd.Text+";Persist Security Info=True;database="+txtScema.Text+"";
                String connectionString = cons;
                conn.ConnectionString = connectionString;
                return conn;
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable getTableQry(string Querry)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = connection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(Querry, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return dt;
        }

        public bool checkConnection()
        {
            bool check = true;
            MySqlConnection con = connection();
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 4060: // Invalid Database 
                        System.Windows.Forms.MessageBox.Show("Invalid Database");
                        break;
                    case 18456: // Login Failed 
                        System.Windows.Forms.MessageBox.Show("Login Failed ");
                        break;
                    default:
                        //....
                        break;
                }
            }
            return check;
        }


        private void btnGO_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServer.Text == "" && txtID.Text == "" && txtPwd.Text == "")
                    MessageBox.Show("Enter a server, ID and password");
                else
                {
                    if (txtScema.Text == "")
                        MessageBox.Show("Enter a schema name");
                    else
                        if (txtTable.Text == "")
                            MessageBox.Show("Enter the Table Name");
                        else
                            go();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void go()
        {
            string qry = @"SELECT   TABLE_NAME
               , COLUMN_NAME
               , DATA_TYPE
               , CHARACTER_MAXIMUM_LENGTH
               , CHARACTER_OCTET_LENGTH 
               , NUMERIC_PRECISION 
               , NUMERIC_SCALE AS SCALE
               , COLUMN_DEFAULT
               , IS_NULLABLE
               ,TABLE_SCHEMA
               FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + txtTable.Text.Trim().ToString() + "' ";
            if (txtScema.Text.Trim().ToString() != "")
                qry += " and TABLE_SCHEMA='" + txtScema.Text + "'";
            DataTable dt = getTableQry(qry);
            if (dt.Rows.Count > 0)
            {
                storedPros(dt);
                dataModel(dt);
                parameter(dt);
            }
            else
                MessageBox.Show("No Data Available");
        }

        private void parameter(System.Data.DataTable dt)
        {
            string pm = "";
            char ch = '"';
            pm += @"string qry = @"+ch.ToString()+"addEditSystemSetting"+ch.ToString()+@";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = qry;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;";
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DATA_TYPE"].ToString() == "int")
                    pm += "cmd.Parameters.Add(" + ch.ToString() + "@p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "" + ch.ToString() + ", MySqlDbType.Int32).Value = obj." + dt.Rows[i]["COLUMN_NAME"].ToString() + "; \n";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "varchar")
                    pm += "cmd.Parameters.Add(" + ch.ToString() + "@p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "" + ch.ToString() + ", MySqlDbType.VarChar, " + dt.Rows[i]["CHARACTER_MAXIMUM_LENGTH"].ToString() + ").Value = obj." + dt.Rows[i]["COLUMN_NAME"].ToString() + "; \n";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "timestamp" || dt.Rows[i]["DATA_TYPE"].ToString() == "datetime")
                    pm += "cmd.Parameters.Add(" + ch.ToString() + "@p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "" + ch.ToString() + ", MySqlDbType.DateTime).Value = obj." + dt.Rows[i]["COLUMN_NAME"].ToString() + "; \n";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "tinyint")
                    pm += "cmd.Parameters.Add(" + ch.ToString() + "@p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "" + ch.ToString() + ", MySqlDbType.Int16).Value = obj." + dt.Rows[i]["COLUMN_NAME"].ToString() + "; \n";
                else
                    pm += "//contact Vijith \n";
            }
            pm += "return excQry(cmd);";
            txtParameter.Text = pm;
        }

        private void dataModel(System.Data.DataTable dt)
        {
            string dm = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dm += "private ";
                if (dt.Rows[i]["DATA_TYPE"].ToString() == "int")
                    dm += "int _" + dt.Rows[i]["COLUMN_NAME"].ToString()+";\n";
                else if(dt.Rows[i]["DATA_TYPE"].ToString() == "varchar")
                    dm += "string _" + dt.Rows[i]["COLUMN_NAME"].ToString() + ";\n";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "timestamp" || dt.Rows[i]["DATA_TYPE"].ToString() == "datetime")
                    dm += "DateTime _" + dt.Rows[i]["COLUMN_NAME"].ToString() + ";\n";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "tinyint")
                    dm += "bool _" + dt.Rows[i]["COLUMN_NAME"].ToString() + ";\n";
                else
                    dm += "// contact Vijith \n";
            }
            dm += "\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dm += "\n public ";
                if (dt.Rows[i]["DATA_TYPE"].ToString() == "int")
                    dm += "int " + dt.Rows[i]["COLUMN_NAME"].ToString() + "";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "varchar")
                    dm += "string " + dt.Rows[i]["COLUMN_NAME"].ToString() + "";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "timestamp" || dt.Rows[i]["DATA_TYPE"].ToString() == "datetime")
                    dm += "DateTime " + dt.Rows[i]["COLUMN_NAME"].ToString() + "";
                else if (dt.Rows[i]["DATA_TYPE"].ToString() == "tinyint")
                    dm += "bool " + dt.Rows[i]["COLUMN_NAME"].ToString() + "";
                else
                    dm += "// contact Vijith \n";
                dm += @"
                    {
                    get { return _"+dt.Rows[i]["COLUMN_NAME"].ToString()+@"; }
                    set { _"+dt.Rows[i]["COLUMN_NAME"].ToString()+@" = value; }
                    } ";
            }
            txtModel.Text = dm;
        }

        private void storedPros(DataTable dt)
        {
            string sp = "CREATE DEFINER=`root`@`%` PROCEDURE `procedure Name`(";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DATA_TYPE"].ToString() == "varchar")
                    sp += "IN p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + " " + dt.Rows[i]["DATA_TYPE"].ToString() + "(" + dt.Rows[i]["CHARACTER_MAXIMUM_LENGTH"].ToString() + ")";
                else
                    sp += "IN p_" + dt.Rows[i]["COLUMN_NAME"].ToString() + " " + dt.Rows[i]["DATA_TYPE"].ToString() + "";
                if (dt.Rows.Count != (i + 1))
                    sp += ",\n";
            }
            sp += @")
                BEGIN
                if p_" + dt.Rows[0]["COLUMN_NAME"].ToString() + "='0' THEN ";
            sp += "Insert into " + txtTable.Text + " (\n";
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                sp += dt.Rows[i]["COLUMN_NAME"].ToString();
                if (dt.Rows.Count != (i + 1))
                    sp += ",";
            }
            sp += ") values ( \n";
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                sp += "p_" + dt.Rows[i]["COLUMN_NAME"].ToString();
                if (dt.Rows.Count != (i + 1))
                    sp += ",";
            }
            sp += @");
                else
                update " + txtTable.Text.ToString() + " set ";
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                sp += dt.Rows[i]["COLUMN_NAME"].ToString() + "=" + "p_" + dt.Rows[i]["COLUMN_NAME"].ToString();
                if (dt.Rows.Count != (i + 1))
                    sp += ",";
            }
            sp += "\n where  " + dt.Rows[0]["COLUMN_NAME"].ToString() + "=" + "p_" + dt.Rows[0]["COLUMN_NAME"].ToString() + ";\n";
            sp += @"end if;
                    END";
            txtSP.Text = sp;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTable.Text = "";
            txtSP.Text = "";
            txtModel.Text = "";
            txtParameter.Text = "";
        }

        private void txtScema_Leave(object sender, EventArgs e)
        {
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(autoComplete));
            //try
            //{
            //    t.Start();
            //}
            //catch (Exception ex)
            //{                
            //}
        }

        private void autoComplete()
        {
            string qry = @"SELECT   TABLE_NAME               
               FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='" + txtScema.Text + "'";
            DataTable dt = getTableQry(qry);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    txtTable.AutoCompleteCustomSource.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
