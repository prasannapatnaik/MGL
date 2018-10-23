namespace MGL
{
    partial class Server
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_GasLogger = new System.Windows.Forms.RadioButton();
            this.rd_WaterLogger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_ToDt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_FromDt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_listenIP = new System.Windows.Forms.Label();
            this.lbl_DeviceID = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.bttn_Fetch = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_device3 = new System.Windows.Forms.CheckBox();
            this.chk_device2 = new System.Windows.Forms.CheckBox();
            this.chk_device1 = new System.Windows.Forms.CheckBox();
            this.txt_SaveDevices = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_SIM1 = new System.Windows.Forms.TextBox();
            this.txt_SN2 = new System.Windows.Forms.TextBox();
            this.txt_SIM2 = new System.Windows.Forms.TextBox();
            this.txt_SIM3 = new System.Windows.Forms.TextBox();
            this.txt_SN1 = new System.Windows.Forms.TextBox();
            this.txt_SN3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.Label();
            this.rd_ManualProcess = new System.Windows.Forms.RadioButton();
            this.rd_AutoProcess = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dp_HrsList = new System.Windows.Forms.ComboBox();
            this.lbl_Hrs = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bttn_Fetch);
            this.tabPage1.Controls.Add(this.txt_UserName);
            this.tabPage1.Controls.Add(this.txt_IPAddress);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Integration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_GasLogger);
            this.groupBox2.Controls.Add(this.rd_WaterLogger);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logger Type";
            // 
            // rd_GasLogger
            // 
            this.rd_GasLogger.AutoSize = true;
            this.rd_GasLogger.Checked = true;
            this.rd_GasLogger.Location = new System.Drawing.Point(101, 16);
            this.rd_GasLogger.Name = "rd_GasLogger";
            this.rd_GasLogger.Size = new System.Drawing.Size(44, 17);
            this.rd_GasLogger.TabIndex = 1;
            this.rd_GasLogger.TabStop = true;
            this.rd_GasLogger.Text = "Gas";
            this.rd_GasLogger.UseVisualStyleBackColor = true;
            // 
            // rd_WaterLogger
            // 
            this.rd_WaterLogger.AutoSize = true;
            this.rd_WaterLogger.Location = new System.Drawing.Point(10, 19);
            this.rd_WaterLogger.Name = "rd_WaterLogger";
            this.rd_WaterLogger.Size = new System.Drawing.Size(54, 17);
            this.rd_WaterLogger.TabIndex = 0;
            this.rd_WaterLogger.Text = "Water";
            this.rd_WaterLogger.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_MobNo);
            this.groupBox1.Controls.Add(this.lbl_ToDt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_FromDt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_listenIP);
            this.groupBox1.Controls.Add(this.lbl_DeviceID);
            this.groupBox1.Controls.Add(this.lbl_MobileNo);
            this.groupBox1.Location = new System.Drawing.Point(6, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 75);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transmit";
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.AutoSize = true;
            this.lbl_MobNo.Location = new System.Drawing.Point(204, 25);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_MobNo.TabIndex = 11;
            this.lbl_MobNo.Text = "Mobile Number";
            // 
            // lbl_ToDt
            // 
            this.lbl_ToDt.AutoSize = true;
            this.lbl_ToDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDt.Location = new System.Drawing.Point(300, 50);
            this.lbl_ToDt.Name = "lbl_ToDt";
            this.lbl_ToDt.Size = new System.Drawing.Size(48, 13);
            this.lbl_ToDt.TabIndex = 14;
            this.lbl_ToDt.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "From Dt";
            // 
            // lbl_FromDt
            // 
            this.lbl_FromDt.AutoSize = true;
            this.lbl_FromDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDt.Location = new System.Drawing.Point(83, 50);
            this.lbl_FromDt.Name = "lbl_FromDt";
            this.lbl_FromDt.Size = new System.Drawing.Size(48, 13);
            this.lbl_FromDt.TabIndex = 13;
            this.lbl_FromDt.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "To Dt";
            // 
            // lbl_listenIP
            // 
            this.lbl_listenIP.AutoSize = true;
            this.lbl_listenIP.Location = new System.Drawing.Point(6, 25);
            this.lbl_listenIP.Name = "lbl_listenIP";
            this.lbl_listenIP.Size = new System.Drawing.Size(55, 13);
            this.lbl_listenIP.TabIndex = 7;
            this.lbl_listenIP.Text = "Device ID";
            // 
            // lbl_DeviceID
            // 
            this.lbl_DeviceID.AutoSize = true;
            this.lbl_DeviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeviceID.Location = new System.Drawing.Point(83, 25);
            this.lbl_DeviceID.Name = "lbl_DeviceID";
            this.lbl_DeviceID.Size = new System.Drawing.Size(14, 13);
            this.lbl_DeviceID.TabIndex = 8;
            this.lbl_DeviceID.Text = "0";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.Location = new System.Drawing.Point(300, 25);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(14, 13);
            this.lbl_MobileNo.TabIndex = 9;
            this.lbl_MobileNo.Text = "0";
            // 
            // bttn_Fetch
            // 
            this.bttn_Fetch.Location = new System.Drawing.Point(345, 22);
            this.bttn_Fetch.Name = "bttn_Fetch";
            this.bttn_Fetch.Size = new System.Drawing.Size(75, 23);
            this.bttn_Fetch.TabIndex = 3;
            this.bttn_Fetch.Text = "&Fetch XML";
            this.bttn_Fetch.UseVisualStyleBackColor = true;
            this.bttn_Fetch.Click += new System.EventHandler(this.bttn_Fetch_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(117, 24);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.Text = "admin";
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(6, 24);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_IPAddress.TabIndex = 0;
            this.txt_IPAddress.Text = "103.11.117.219";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datagate Server IP";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(228, 24);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "Admin@123";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.chk_device3);
            this.tabPage2.Controls.Add(this.chk_device2);
            this.tabPage2.Controls.Add(this.chk_device1);
            this.tabPage2.Controls.Add(this.txt_SaveDevices);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_SIM1);
            this.tabPage2.Controls.Add(this.txt_SN2);
            this.tabPage2.Controls.Add(this.txt_SIM2);
            this.tabPage2.Controls.Add(this.txt_SIM3);
            this.tabPage2.Controls.Add(this.txt_SN1);
            this.tabPage2.Controls.Add(this.txt_SN3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IP Mapping";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_device3
            // 
            this.chk_device3.AutoSize = true;
            this.chk_device3.Location = new System.Drawing.Point(267, 75);
            this.chk_device3.Name = "chk_device3";
            this.chk_device3.Size = new System.Drawing.Size(56, 17);
            this.chk_device3.TabIndex = 8;
            this.chk_device3.Text = "Active";
            this.chk_device3.UseVisualStyleBackColor = true;
            // 
            // chk_device2
            // 
            this.chk_device2.AutoSize = true;
            this.chk_device2.Location = new System.Drawing.Point(267, 49);
            this.chk_device2.Name = "chk_device2";
            this.chk_device2.Size = new System.Drawing.Size(56, 17);
            this.chk_device2.TabIndex = 5;
            this.chk_device2.Text = "Active";
            this.chk_device2.UseVisualStyleBackColor = true;
            // 
            // chk_device1
            // 
            this.chk_device1.AutoSize = true;
            this.chk_device1.Location = new System.Drawing.Point(267, 26);
            this.chk_device1.Name = "chk_device1";
            this.chk_device1.Size = new System.Drawing.Size(56, 17);
            this.chk_device1.TabIndex = 2;
            this.chk_device1.Text = "Active";
            this.chk_device1.UseVisualStyleBackColor = true;
            // 
            // txt_SaveDevices
            // 
            this.txt_SaveDevices.Location = new System.Drawing.Point(149, 111);
            this.txt_SaveDevices.Name = "txt_SaveDevices";
            this.txt_SaveDevices.Size = new System.Drawing.Size(100, 26);
            this.txt_SaveDevices.TabIndex = 9;
            this.txt_SaveDevices.Text = "Save Devices";
            this.txt_SaveDevices.UseVisualStyleBackColor = true;
            this.txt_SaveDevices.Click += new System.EventHandler(this.txt_SaveDevices_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "3";
            // 
            // txt_SIM1
            // 
            this.txt_SIM1.Location = new System.Drawing.Point(149, 24);
            this.txt_SIM1.Name = "txt_SIM1";
            this.txt_SIM1.Size = new System.Drawing.Size(100, 20);
            this.txt_SIM1.TabIndex = 1;
            // 
            // txt_SN2
            // 
            this.txt_SN2.Location = new System.Drawing.Point(32, 50);
            this.txt_SN2.Name = "txt_SN2";
            this.txt_SN2.Size = new System.Drawing.Size(100, 20);
            this.txt_SN2.TabIndex = 3;
            // 
            // txt_SIM2
            // 
            this.txt_SIM2.Location = new System.Drawing.Point(149, 50);
            this.txt_SIM2.Name = "txt_SIM2";
            this.txt_SIM2.Size = new System.Drawing.Size(100, 20);
            this.txt_SIM2.TabIndex = 4;
            // 
            // txt_SIM3
            // 
            this.txt_SIM3.Location = new System.Drawing.Point(149, 76);
            this.txt_SIM3.Name = "txt_SIM3";
            this.txt_SIM3.Size = new System.Drawing.Size(100, 20);
            this.txt_SIM3.TabIndex = 7;
            // 
            // txt_SN1
            // 
            this.txt_SN1.Location = new System.Drawing.Point(32, 24);
            this.txt_SN1.Name = "txt_SN1";
            this.txt_SN1.Size = new System.Drawing.Size(100, 20);
            this.txt_SN1.TabIndex = 0;
            // 
            // txt_SN3
            // 
            this.txt_SN3.Location = new System.Drawing.Point(32, 76);
            this.txt_SN3.Name = "txt_SN3";
            this.txt_SN3.Size = new System.Drawing.Size(100, 20);
            this.txt_SN3.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mobile No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Device ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "2";
            // 
            // grpData
            // 
            this.grpData.AutoSize = true;
            this.grpData.Location = new System.Drawing.Point(1, 274);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(10, 13);
            this.grpData.TabIndex = 8;
            this.grpData.Text = "-";
            // 
            // rd_ManualProcess
            // 
            this.rd_ManualProcess.AutoSize = true;
            this.rd_ManualProcess.Checked = true;
            this.rd_ManualProcess.Location = new System.Drawing.Point(6, 19);
            this.rd_ManualProcess.Name = "rd_ManualProcess";
            this.rd_ManualProcess.Size = new System.Drawing.Size(60, 17);
            this.rd_ManualProcess.TabIndex = 13;
            this.rd_ManualProcess.TabStop = true;
            this.rd_ManualProcess.Text = "Manual";
            this.rd_ManualProcess.UseVisualStyleBackColor = true;
            // 
            // rd_AutoProcess
            // 
            this.rd_AutoProcess.AutoSize = true;
            this.rd_AutoProcess.Location = new System.Drawing.Point(6, 42);
            this.rd_AutoProcess.Name = "rd_AutoProcess";
            this.rd_AutoProcess.Size = new System.Drawing.Size(47, 17);
            this.rd_AutoProcess.TabIndex = 14;
            this.rd_AutoProcess.Text = "Auto";
            this.rd_AutoProcess.UseVisualStyleBackColor = true;
            this.rd_AutoProcess.CheckedChanged += new System.EventHandler(this.rd_AutoProcess_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Hrs);
            this.groupBox3.Controls.Add(this.dp_HrsList);
            this.groupBox3.Controls.Add(this.rd_ManualProcess);
            this.groupBox3.Controls.Add(this.rd_AutoProcess);
            this.groupBox3.Location = new System.Drawing.Point(32, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 71);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Cycle";
            // 
            // dp_HrsList
            // 
            this.dp_HrsList.FormattingEnabled = true;
            this.dp_HrsList.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "24"});
            this.dp_HrsList.Location = new System.Drawing.Point(59, 41);
            this.dp_HrsList.Name = "dp_HrsList";
            this.dp_HrsList.Size = new System.Drawing.Size(41, 21);
            this.dp_HrsList.TabIndex = 15;
            this.dp_HrsList.Visible = false;
            // 
            // lbl_Hrs
            // 
            this.lbl_Hrs.AutoSize = true;
            this.lbl_Hrs.Location = new System.Drawing.Point(106, 46);
            this.lbl_Hrs.Name = "lbl_Hrs";
            this.lbl_Hrs.Size = new System.Drawing.Size(23, 13);
            this.lbl_Hrs.TabIndex = 16;
            this.lbl_Hrs.Text = "Hrs";
            this.lbl_Hrs.Visible = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 289);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "SCADA Integration Tool";
            this.Load += new System.EventHandler(this.Server_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttn_Fetch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_ToDt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_FromDt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_listenIP;
        private System.Windows.Forms.Label lbl_DeviceID;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label grpData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_GasLogger;
        private System.Windows.Forms.RadioButton rd_WaterLogger;
        private System.Windows.Forms.Button txt_SaveDevices;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_SIM1;
        private System.Windows.Forms.TextBox txt_SN2;
        private System.Windows.Forms.TextBox txt_SIM2;
        private System.Windows.Forms.TextBox txt_SIM3;
        private System.Windows.Forms.TextBox txt_SN1;
        private System.Windows.Forms.TextBox txt_SN3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_device3;
        private System.Windows.Forms.CheckBox chk_device2;
        private System.Windows.Forms.CheckBox chk_device1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_ManualProcess;
        private System.Windows.Forms.RadioButton rd_AutoProcess;
        private System.Windows.Forms.ComboBox dp_HrsList;
        private System.Windows.Forms.Label lbl_Hrs;
    }
}