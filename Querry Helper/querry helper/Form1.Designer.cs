namespace Querry_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtScema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSP = new System.Windows.Forms.RichTextBox();
            this.txtModel = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Name";
            // 
            // txtScema
            // 
            this.txtScema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtScema.Location = new System.Drawing.Point(140, 45);
            this.txtScema.Name = "txtScema";
            this.txtScema.Size = new System.Drawing.Size(228, 20);
            this.txtScema.TabIndex = 3;
            this.txtScema.Text = "atozdental";
            this.txtScema.Leave += new System.EventHandler(this.txtScema_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scema Name";
            // 
            // txtTable
            // 
            this.txtTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTable.Location = new System.Drawing.Point(140, 74);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(228, 20);
            this.txtTable.TabIndex = 5;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(140, 108);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 6;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(236, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(39, 161);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(807, 196);
            this.txtSP.TabIndex = 8;
            this.txtSP.Text = "";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(39, 388);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(333, 221);
            this.txtModel.TabIndex = 9;
            this.txtModel.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stored Procedure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Model";
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(404, 388);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(442, 221);
            this.txtParameter.TabIndex = 12;
            this.txtParameter.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parameter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(140, 11);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 15;
            this.txtServer.Text = "172.16.0.29";
            this.txtServer.Leave += new System.EventHandler(this.txtScema_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(272, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 17;
            this.txtID.Text = "root";
            this.txtID.Leave += new System.EventHandler(this.txtScema_Leave);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(449, 11);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 19;
            this.txtPwd.Text = "root";
            this.txtPwd.Leave += new System.EventHandler(this.txtScema_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 626);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScema);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Querry Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtSP;
        private System.Windows.Forms.RichTextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label9;
    }
}

