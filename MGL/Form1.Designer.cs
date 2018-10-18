namespace MGL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStartAdress = new System.Windows.Forms.TextBox();
            this.radWord = new System.Windows.Forms.RadioButton();
            this.rd_WaterLogger = new System.Windows.Forms.RadioButton();
            this.rd_GasLogger = new System.Windows.Forms.RadioButton();
            this.bttn_ReadXML = new System.Windows.Forms.Button();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txt_SMSNo = new System.Windows.Forms.TextBox();
            this.lbl_CellNo = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.grpData = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_24HrsCycle = new System.Windows.Forms.RadioButton();
            this.rd_48HrsCycle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtStartAdress);
            this.groupBox1.Controls.Add(this.radWord);
            this.groupBox1.Controls.Add(this.bttn_ReadXML);
            this.groupBox1.Controls.Add(this.txt_Location);
            this.groupBox1.Controls.Add(this.lbl_Location);
            this.groupBox1.Controls.Add(this.txt_SMSNo);
            this.groupBox1.Controls.Add(this.lbl_CellNo);
            this.groupBox1.Controls.Add(this.lbl_Password);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_IPAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datagate Connectivity";
            // 
            // txtStartAdress
            // 
            this.txtStartAdress.Location = new System.Drawing.Point(364, 49);
            this.txtStartAdress.Name = "txtStartAdress";
            this.txtStartAdress.Size = new System.Drawing.Size(50, 20);
            this.txtStartAdress.TabIndex = 14;
            this.txtStartAdress.Visible = false;
            // 
            // radWord
            // 
            this.radWord.Checked = true;
            this.radWord.Location = new System.Drawing.Point(457, 48);
            this.radWord.Name = "radWord";
            this.radWord.Size = new System.Drawing.Size(67, 21);
            this.radWord.TabIndex = 3;
            this.radWord.TabStop = true;
            this.radWord.Text = "Word";
            // 
            // rd_WaterLogger
            // 
            this.rd_WaterLogger.AutoSize = true;
            this.rd_WaterLogger.Location = new System.Drawing.Point(6, 15);
            this.rd_WaterLogger.Name = "rd_WaterLogger";
            this.rd_WaterLogger.Size = new System.Drawing.Size(90, 17);
            this.rd_WaterLogger.TabIndex = 13;
            this.rd_WaterLogger.Text = "&Water Logger";
            this.rd_WaterLogger.UseVisualStyleBackColor = true;
            this.rd_WaterLogger.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_GasLogger
            // 
            this.rd_GasLogger.AutoSize = true;
            this.rd_GasLogger.Checked = true;
            this.rd_GasLogger.Location = new System.Drawing.Point(262, 15);
            this.rd_GasLogger.Name = "rd_GasLogger";
            this.rd_GasLogger.Size = new System.Drawing.Size(80, 17);
            this.rd_GasLogger.TabIndex = 12;
            this.rd_GasLogger.TabStop = true;
            this.rd_GasLogger.Text = "&Gas Logger";
            this.rd_GasLogger.UseVisualStyleBackColor = true;
            // 
            // bttn_ReadXML
            // 
            this.bttn_ReadXML.Location = new System.Drawing.Point(449, 72);
            this.bttn_ReadXML.Name = "bttn_ReadXML";
            this.bttn_ReadXML.Size = new System.Drawing.Size(75, 23);
            this.bttn_ReadXML.TabIndex = 11;
            this.bttn_ReadXML.Text = "&Read XML";
            this.bttn_ReadXML.UseVisualStyleBackColor = true;
            this.bttn_ReadXML.Click += new System.EventHandler(this.bttn_ReadXML_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(73, 49);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 10;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(6, 52);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 9;
            this.lbl_Location.Text = "Location";
            // 
            // txt_SMSNo
            // 
            this.txt_SMSNo.Location = new System.Drawing.Point(251, 49);
            this.txt_SMSNo.Name = "txt_SMSNo";
            this.txt_SMSNo.Size = new System.Drawing.Size(100, 20);
            this.txt_SMSNo.TabIndex = 8;
            // 
            // lbl_CellNo
            // 
            this.lbl_CellNo.AutoSize = true;
            this.lbl_CellNo.Location = new System.Drawing.Point(184, 52);
            this.lbl_CellNo.Name = "lbl_CellNo";
            this.lbl_CellNo.Size = new System.Drawing.Size(47, 13);
            this.lbl_CellNo.TabIndex = 7;
            this.lbl_CellNo.Text = "SMS No";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(361, 26);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(424, 23);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 4;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(184, 26);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "UserName";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(251, 23);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(74, 23);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_IPAddress.TabIndex = 3;
            this.txt_IPAddress.Text = "127.0.0.1";
            // 
            // grpData
            // 
            this.grpData.AutoSize = true;
            this.grpData.Location = new System.Drawing.Point(18, 197);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(35, 13);
            this.grpData.TabIndex = 15;
            this.grpData.Text = "label2";
            this.grpData.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_WaterLogger);
            this.groupBox2.Controls.Add(this.rd_GasLogger);
            this.groupBox2.Location = new System.Drawing.Point(9, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 38);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_24HrsCycle);
            this.groupBox3.Controls.Add(this.rd_48HrsCycle);
            this.groupBox3.Location = new System.Drawing.Point(21, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 38);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trigger Time";
            // 
            // rd_24HrsCycle
            // 
            this.rd_24HrsCycle.AutoSize = true;
            this.rd_24HrsCycle.Checked = true;
            this.rd_24HrsCycle.Location = new System.Drawing.Point(6, 15);
            this.rd_24HrsCycle.Name = "rd_24HrsCycle";
            this.rd_24HrsCycle.Size = new System.Drawing.Size(85, 17);
            this.rd_24HrsCycle.TabIndex = 13;
            this.rd_24HrsCycle.TabStop = true;
            this.rd_24HrsCycle.Text = "24 Hrs Cycle";
            this.rd_24HrsCycle.UseVisualStyleBackColor = true;
            // 
            // rd_48HrsCycle
            // 
            this.rd_48HrsCycle.AutoSize = true;
            this.rd_48HrsCycle.Location = new System.Drawing.Point(97, 15);
            this.rd_48HrsCycle.Name = "rd_48HrsCycle";
            this.rd_48HrsCycle.Size = new System.Drawing.Size(85, 17);
            this.rd_48HrsCycle.TabIndex = 12;
            this.rd_48HrsCycle.Text = "48 Hrs Cycle";
            this.rd_48HrsCycle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 219);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button bttn_ReadXML;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txt_SMSNo;
        private System.Windows.Forms.Label lbl_CellNo;
        private System.Windows.Forms.RadioButton rd_WaterLogger;
        private System.Windows.Forms.RadioButton rd_GasLogger;
        private System.Windows.Forms.RadioButton radWord;
        private System.Windows.Forms.TextBox txtStartAdress;
        private System.Windows.Forms.Label grpData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_24HrsCycle;
        private System.Windows.Forms.RadioButton rd_48HrsCycle;
    }
}

