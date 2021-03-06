﻿namespace KinectTest
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
            this.txtBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxIPID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Join = new System.Windows.Forms.Label();
            this.txtBoxJoin = new System.Windows.Forms.TextBox();
            this.btnSendTest = new System.Windows.Forms.Button();
            this.cmbBoxValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxSlot = new System.Windows.Forms.ComboBox();
            this.cmbBoxSignalType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxIPAddress
            // 
            this.txtBoxIPAddress.Location = new System.Drawing.Point(77, 17);
            this.txtBoxIPAddress.Name = "txtBoxIPAddress";
            this.txtBoxIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIPAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // cmbBoxIPID
            // 
            this.cmbBoxIPID.FormattingEnabled = true;
            this.cmbBoxIPID.Location = new System.Drawing.Point(242, 17);
            this.cmbBoxIPID.Name = "cmbBoxIPID";
            this.cmbBoxIPID.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxIPID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP ID";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(207, 45);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(288, 45);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxIPID);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVoice);
            this.groupBox2.Controls.Add(this.Join);
            this.groupBox2.Controls.Add(this.txtBoxJoin);
            this.groupBox2.Controls.Add(this.btnSendTest);
            this.groupBox2.Controls.Add(this.cmbBoxValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbBoxSlot);
            this.groupBox2.Controls.Add(this.cmbBoxSignalType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // Join
            // 
            this.Join.AutoSize = true;
            this.Join.Location = new System.Drawing.Point(223, 43);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(26, 13);
            this.Join.TabIndex = 12;
            this.Join.Text = "Join";
            // 
            // txtBoxJoin
            // 
            this.txtBoxJoin.Location = new System.Drawing.Point(263, 40);
            this.txtBoxJoin.Name = "txtBoxJoin";
            this.txtBoxJoin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxJoin.TabIndex = 6;
            // 
            // btnSendTest
            // 
            this.btnSendTest.Location = new System.Drawing.Point(265, 72);
            this.btnSendTest.Name = "btnSendTest";
            this.btnSendTest.Size = new System.Drawing.Size(98, 23);
            this.btnSendTest.TabIndex = 11;
            this.btnSendTest.Text = "Send Test Signal";
            this.btnSendTest.UseVisualStyleBackColor = true;
            this.btnSendTest.Click += new System.EventHandler(this.btnSendTest_Click);
            // 
            // cmbBoxValue
            // 
            this.cmbBoxValue.FormattingEnabled = true;
            this.cmbBoxValue.Items.AddRange(new object[] {
            "High",
            "Low",
            "Pulse (High-Low)",
            "Pulse (Low-High)"});
            this.cmbBoxValue.Location = new System.Drawing.Point(263, 13);
            this.cmbBoxValue.Name = "cmbBoxValue";
            this.cmbBoxValue.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slot";
            // 
            // cmbBoxSlot
            // 
            this.cmbBoxSlot.FormattingEnabled = true;
            this.cmbBoxSlot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbBoxSlot.Location = new System.Drawing.Point(72, 37);
            this.cmbBoxSlot.Name = "cmbBoxSlot";
            this.cmbBoxSlot.Size = new System.Drawing.Size(95, 21);
            this.cmbBoxSlot.TabIndex = 7;
            // 
            // cmbBoxSignalType
            // 
            this.cmbBoxSignalType.FormattingEnabled = true;
            this.cmbBoxSignalType.Items.AddRange(new object[] {
            "Digital",
            "Analog",
            "Serial"});
            this.cmbBoxSignalType.Location = new System.Drawing.Point(72, 13);
            this.cmbBoxSignalType.Name = "cmbBoxSignalType";
            this.cmbBoxSignalType.Size = new System.Drawing.Size(95, 21);
            this.cmbBoxSignalType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signal Type";
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(6, 72);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(98, 23);
            this.btnVoice.TabIndex = 13;
            this.btnVoice.Text = "Start Voice";
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 189);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxIPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendTest;
        private System.Windows.Forms.ComboBox cmbBoxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxSlot;
        private System.Windows.Forms.ComboBox cmbBoxSignalType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Join;
        private System.Windows.Forms.TextBox txtBoxJoin;
        private System.Windows.Forms.Button btnVoice;
    }
}

