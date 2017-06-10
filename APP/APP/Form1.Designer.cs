namespace APP
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
            this.label1 = new System.Windows.Forms.Label();
            this.EncFile = new System.Windows.Forms.TextBox();
            this.EncChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncRsaKey = new System.Windows.Forms.TextBox();
            this.RsaEncKey = new System.Windows.Forms.Button();
            this.BRsaKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncAlg = new System.Windows.Forms.ComboBox();
            this.HashAlg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncKey = new System.Windows.Forms.TextBox();
            this.Encrpt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.DecKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DecHashAlg = new System.Windows.Forms.ComboBox();
            this.DecAlg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RsaDecKey = new System.Windows.Forms.Button();
            this.DecRsaKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DecChooseFile = new System.Windows.Forms.Button();
            this.DecFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CalEncHash = new System.Windows.Forms.Button();
            this.CalDecHash = new System.Windows.Forms.Button();
            this.EncHash = new System.Windows.Forms.TextBox();
            this.EncRsaHash = new System.Windows.Forms.TextBox();
            this.EncAlgHash = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DecRsaHash = new System.Windows.Forms.TextBox();
            this.DecAlgHash = new System.Windows.Forms.TextBox();
            this.DecHash = new System.Windows.Forms.TextBox();
            this.ARsaKey = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DecChooseFile2 = new System.Windows.Forms.Button();
            this.DecFile2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.EncHash2 = new System.Windows.Forms.TextBox();
            this.CalHash = new System.Windows.Forms.Button();
            this.CompareHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择需要加密的文件：";
            // 
            // EncFile
            // 
            this.EncFile.Location = new System.Drawing.Point(29, 31);
            this.EncFile.Name = "EncFile";
            this.EncFile.Size = new System.Drawing.Size(255, 21);
            this.EncFile.TabIndex = 1;
            // 
            // EncChooseFile
            // 
            this.EncChooseFile.Location = new System.Drawing.Point(303, 29);
            this.EncChooseFile.Name = "EncChooseFile";
            this.EncChooseFile.Size = new System.Drawing.Size(35, 23);
            this.EncChooseFile.TabIndex = 2;
            this.EncChooseFile.Text = "…";
            this.EncChooseFile.UseVisualStyleBackColor = true;
            this.EncChooseFile.Click += new System.EventHandler(this.EncChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入密钥：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "UKb加密后的密钥：";
            // 
            // EncRsaKey
            // 
            this.EncRsaKey.Location = new System.Drawing.Point(486, 43);
            this.EncRsaKey.Multiline = true;
            this.EncRsaKey.Name = "EncRsaKey";
            this.EncRsaKey.Size = new System.Drawing.Size(187, 78);
            this.EncRsaKey.TabIndex = 6;
            // 
            // RsaEncKey
            // 
            this.RsaEncKey.Location = new System.Drawing.Point(300, 73);
            this.RsaEncKey.Name = "RsaEncKey";
            this.RsaEncKey.Size = new System.Drawing.Size(67, 23);
            this.RsaEncKey.TabIndex = 8;
            this.RsaEncKey.Text = "加密密钥";
            this.RsaEncKey.UseVisualStyleBackColor = true;
            this.RsaEncKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRsaKey
            // 
            this.BRsaKey.Location = new System.Drawing.Point(830, 556);
            this.BRsaKey.Multiline = true;
            this.BRsaKey.Name = "BRsaKey";
            this.BRsaKey.Size = new System.Drawing.Size(535, 189);
            this.BRsaKey.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "加密算法：";
            // 
            // EncAlg
            // 
            this.EncAlg.FormattingEnabled = true;
            this.EncAlg.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.EncAlg.Location = new System.Drawing.Point(99, 140);
            this.EncAlg.Name = "EncAlg";
            this.EncAlg.Size = new System.Drawing.Size(120, 20);
            this.EncAlg.TabIndex = 11;
            // 
            // HashAlg
            // 
            this.HashAlg.FormattingEnabled = true;
            this.HashAlg.Items.AddRange(new object[] {
            "SHA1",
            "MD5"});
            this.HashAlg.Location = new System.Drawing.Point(98, 183);
            this.HashAlg.Name = "HashAlg";
            this.HashAlg.Size = new System.Drawing.Size(121, 20);
            this.HashAlg.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "哈希算法：";
            // 
            // EncKey
            // 
            this.EncKey.Location = new System.Drawing.Point(99, 74);
            this.EncKey.Name = "EncKey";
            this.EncKey.Size = new System.Drawing.Size(185, 21);
            this.EncKey.TabIndex = 14;
            // 
            // Encrpt
            // 
            this.Encrpt.Location = new System.Drawing.Point(245, 140);
            this.Encrpt.Name = "Encrpt";
            this.Encrpt.Size = new System.Drawing.Size(75, 23);
            this.Encrpt.TabIndex = 15;
            this.Encrpt.Text = "加密文件";
            this.Encrpt.UseVisualStyleBackColor = true;
            this.Encrpt.Click += new System.EventHandler(this.Encrpt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(1301, 143);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 28;
            this.Decrypt.Text = "解密文件";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // DecKey
            // 
            this.DecKey.Location = new System.Drawing.Point(1155, 73);
            this.DecKey.Name = "DecKey";
            this.DecKey.Size = new System.Drawing.Size(185, 21);
            this.DecKey.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1083, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "哈希算法：";
            // 
            // DecHashAlg
            // 
            this.DecHashAlg.FormattingEnabled = true;
            this.DecHashAlg.Items.AddRange(new object[] {
            "SHA1",
            "MD5"});
            this.DecHashAlg.Location = new System.Drawing.Point(1154, 186);
            this.DecHashAlg.Name = "DecHashAlg";
            this.DecHashAlg.Size = new System.Drawing.Size(121, 20);
            this.DecHashAlg.TabIndex = 25;
            // 
            // DecAlg
            // 
            this.DecAlg.FormattingEnabled = true;
            this.DecAlg.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.DecAlg.Location = new System.Drawing.Point(1155, 143);
            this.DecAlg.Name = "DecAlg";
            this.DecAlg.Size = new System.Drawing.Size(120, 20);
            this.DecAlg.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1083, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "解密算法：";
            // 
            // RsaDecKey
            // 
            this.RsaDecKey.Location = new System.Drawing.Point(1012, 71);
            this.RsaDecKey.Name = "RsaDecKey";
            this.RsaDecKey.Size = new System.Drawing.Size(67, 23);
            this.RsaDecKey.TabIndex = 22;
            this.RsaDecKey.Text = "解密密钥";
            this.RsaDecKey.UseVisualStyleBackColor = true;
            this.RsaDecKey.Click += new System.EventHandler(this.RsaDecKey_Click);
            // 
            // DecRsaKey
            // 
            this.DecRsaKey.Location = new System.Drawing.Point(809, 43);
            this.DecRsaKey.Multiline = true;
            this.DecRsaKey.Name = "DecRsaKey";
            this.DecRsaKey.Size = new System.Drawing.Size(187, 78);
            this.DecRsaKey.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "接受到的密钥：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1085, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "得到密钥：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DecChooseFile
            // 
            this.DecChooseFile.Location = new System.Drawing.Point(1361, 29);
            this.DecChooseFile.Name = "DecChooseFile";
            this.DecChooseFile.Size = new System.Drawing.Size(35, 23);
            this.DecChooseFile.TabIndex = 18;
            this.DecChooseFile.Text = "…";
            this.DecChooseFile.UseVisualStyleBackColor = true;
            this.DecChooseFile.Click += new System.EventHandler(this.DecChooseFile_Click);
            // 
            // DecFile
            // 
            this.DecFile.Location = new System.Drawing.Point(1087, 29);
            this.DecFile.Name = "DecFile";
            this.DecFile.Size = new System.Drawing.Size(255, 21);
            this.DecFile.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1084, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "选择需要解密的文件：";
            // 
            // CalEncHash
            // 
            this.CalEncHash.Location = new System.Drawing.Point(245, 181);
            this.CalEncHash.Name = "CalEncHash";
            this.CalEncHash.Size = new System.Drawing.Size(101, 23);
            this.CalEncHash.TabIndex = 29;
            this.CalEncHash.Text = "计算并加密哈希";
            this.CalEncHash.UseVisualStyleBackColor = true;
            this.CalEncHash.Click += new System.EventHandler(this.CalEncHash_Click);
            // 
            // CalDecHash
            // 
            this.CalDecHash.Location = new System.Drawing.Point(1301, 186);
            this.CalDecHash.Name = "CalDecHash";
            this.CalDecHash.Size = new System.Drawing.Size(75, 23);
            this.CalDecHash.TabIndex = 30;
            this.CalDecHash.Text = "解密哈希";
            this.CalDecHash.UseVisualStyleBackColor = true;
            this.CalDecHash.Click += new System.EventHandler(this.CalDecHash_Click);
            // 
            // EncHash
            // 
            this.EncHash.Location = new System.Drawing.Point(98, 227);
            this.EncHash.Name = "EncHash";
            this.EncHash.Size = new System.Drawing.Size(248, 21);
            this.EncHash.TabIndex = 31;
            // 
            // EncRsaHash
            // 
            this.EncRsaHash.Location = new System.Drawing.Point(41, 290);
            this.EncRsaHash.Multiline = true;
            this.EncRsaHash.Name = "EncRsaHash";
            this.EncRsaHash.Size = new System.Drawing.Size(248, 107);
            this.EncRsaHash.TabIndex = 32;
            // 
            // EncAlgHash
            // 
            this.EncAlgHash.Location = new System.Drawing.Point(326, 290);
            this.EncAlgHash.Multiline = true;
            this.EncAlgHash.Name = "EncAlgHash";
            this.EncAlgHash.Size = new System.Drawing.Size(248, 107);
            this.EncAlgHash.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "哈希值：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "RKa加密后的哈希值：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 12);
            this.label13.TabIndex = 36;
            this.label13.Text = "DES/AES加密后的哈希值：";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1145, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 12);
            this.label14.TabIndex = 42;
            this.label14.Text = "DES/AES解密后的哈希值：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(861, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "接收到的哈希值：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1009, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 12);
            this.label16.TabIndex = 40;
            this.label16.Text = "UKa解密后的哈希值：";
            // 
            // DecRsaHash
            // 
            this.DecRsaHash.Location = new System.Drawing.Point(1147, 252);
            this.DecRsaHash.Multiline = true;
            this.DecRsaHash.Name = "DecRsaHash";
            this.DecRsaHash.Size = new System.Drawing.Size(248, 107);
            this.DecRsaHash.TabIndex = 39;
            // 
            // DecAlgHash
            // 
            this.DecAlgHash.Location = new System.Drawing.Point(863, 252);
            this.DecAlgHash.Multiline = true;
            this.DecAlgHash.Name = "DecAlgHash";
            this.DecAlgHash.Size = new System.Drawing.Size(248, 107);
            this.DecAlgHash.TabIndex = 38;
            // 
            // DecHash
            // 
            this.DecHash.Location = new System.Drawing.Point(1147, 377);
            this.DecHash.Name = "DecHash";
            this.DecHash.Size = new System.Drawing.Size(248, 21);
            this.DecHash.TabIndex = 37;
            // 
            // ARsaKey
            // 
            this.ARsaKey.Location = new System.Drawing.Point(41, 556);
            this.ARsaKey.Multiline = true;
            this.ARsaKey.Name = "ARsaKey";
            this.ARsaKey.Size = new System.Drawing.Size(535, 189);
            this.ARsaKey.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 12);
            this.label17.TabIndex = 44;
            this.label17.Text = "（DES请输入8位密钥、AES请输入16位密钥）";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 525);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 12);
            this.label18.TabIndex = 45;
            this.label18.Text = "发送方RSA密钥：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(828, 525);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 46;
            this.label19.Text = "接收方RSA密钥：";
            // 
            // DecChooseFile2
            // 
            this.DecChooseFile2.Location = new System.Drawing.Point(1359, 456);
            this.DecChooseFile2.Name = "DecChooseFile2";
            this.DecChooseFile2.Size = new System.Drawing.Size(35, 23);
            this.DecChooseFile2.TabIndex = 49;
            this.DecChooseFile2.Text = "…";
            this.DecChooseFile2.UseVisualStyleBackColor = true;
            this.DecChooseFile2.Click += new System.EventHandler(this.DecChooseFile2_Click);
            // 
            // DecFile2
            // 
            this.DecFile2.Location = new System.Drawing.Point(1085, 456);
            this.DecFile2.Name = "DecFile2";
            this.DecFile2.Size = new System.Drawing.Size(255, 21);
            this.DecFile2.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(966, 461);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 12);
            this.label20.TabIndex = 47;
            this.label20.Text = "选择解密后的文件：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1003, 416);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 12);
            this.label21.TabIndex = 51;
            this.label21.Text = "解密后文件的哈希值：";
            // 
            // EncHash2
            // 
            this.EncHash2.Location = new System.Drawing.Point(1147, 413);
            this.EncHash2.Name = "EncHash2";
            this.EncHash2.Size = new System.Drawing.Size(248, 21);
            this.EncHash2.TabIndex = 50;
            // 
            // CalHash
            // 
            this.CalHash.Location = new System.Drawing.Point(1099, 496);
            this.CalHash.Name = "CalHash";
            this.CalHash.Size = new System.Drawing.Size(75, 23);
            this.CalHash.TabIndex = 52;
            this.CalHash.Text = "计算哈希";
            this.CalHash.UseVisualStyleBackColor = true;
            this.CalHash.Click += new System.EventHandler(this.CalHash_Click);
            // 
            // CompareHash
            // 
            this.CompareHash.Location = new System.Drawing.Point(1240, 496);
            this.CompareHash.Name = "CompareHash";
            this.CompareHash.Size = new System.Drawing.Size(75, 23);
            this.CompareHash.TabIndex = 53;
            this.CompareHash.Text = "对比哈希";
            this.CompareHash.UseVisualStyleBackColor = true;
            this.CompareHash.Click += new System.EventHandler(this.CompareHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 757);
            this.Controls.Add(this.CompareHash);
            this.Controls.Add(this.CalHash);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.EncHash2);
            this.Controls.Add(this.DecChooseFile2);
            this.Controls.Add(this.DecFile2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ARsaKey);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DecRsaHash);
            this.Controls.Add(this.DecAlgHash);
            this.Controls.Add(this.DecHash);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EncAlgHash);
            this.Controls.Add(this.EncRsaHash);
            this.Controls.Add(this.EncHash);
            this.Controls.Add(this.CalDecHash);
            this.Controls.Add(this.CalEncHash);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.DecKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecHashAlg);
            this.Controls.Add(this.DecAlg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RsaDecKey);
            this.Controls.Add(this.DecRsaKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DecChooseFile);
            this.Controls.Add(this.DecFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Encrpt);
            this.Controls.Add(this.EncKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HashAlg);
            this.Controls.Add(this.EncAlg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BRsaKey);
            this.Controls.Add(this.RsaEncKey);
            this.Controls.Add(this.EncRsaKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncChooseFile);
            this.Controls.Add(this.EncFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EncFile;
        private System.Windows.Forms.Button EncChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncRsaKey;
        private System.Windows.Forms.Button RsaEncKey;
        private System.Windows.Forms.TextBox BRsaKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EncAlg;
        private System.Windows.Forms.ComboBox HashAlg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EncKey;
        private System.Windows.Forms.Button Encrpt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox DecKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DecHashAlg;
        private System.Windows.Forms.ComboBox DecAlg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RsaDecKey;
        private System.Windows.Forms.TextBox DecRsaKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DecChooseFile;
        private System.Windows.Forms.TextBox DecFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CalEncHash;
        private System.Windows.Forms.Button CalDecHash;
        private System.Windows.Forms.TextBox EncHash;
        private System.Windows.Forms.TextBox EncRsaHash;
        private System.Windows.Forms.TextBox EncAlgHash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DecRsaHash;
        private System.Windows.Forms.TextBox DecAlgHash;
        private System.Windows.Forms.TextBox DecHash;
        private System.Windows.Forms.TextBox ARsaKey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button DecChooseFile2;
        private System.Windows.Forms.TextBox DecFile2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox EncHash2;
        private System.Windows.Forms.Button CalHash;
        private System.Windows.Forms.Button CompareHash;
    }
}

