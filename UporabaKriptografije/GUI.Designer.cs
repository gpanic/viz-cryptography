namespace UporabaKriptografije
{
    partial class GUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AESDecButton = new System.Windows.Forms.Button();
            this.selectedAESDecKey = new System.Windows.Forms.Label();
            this.selectedAESDecFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openAESDecKeyButton = new System.Windows.Forms.Button();
            this.openAESDecFileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AESEncButton = new System.Windows.Forms.Button();
            this.selectedAESEncKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openAESEncKeyButton = new System.Windows.Forms.Button();
            this.selectedAESEncFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openAESEncFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectAESKeySize = new System.Windows.Forms.ComboBox();
            this.generateAESKeyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RSADecButton = new System.Windows.Forms.Button();
            this.selectedRSADecKey = new System.Windows.Forms.Label();
            this.selectedRSADecFile = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openRSADecKeyButton = new System.Windows.Forms.Button();
            this.openRSADecFileButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RSAEncButton = new System.Windows.Forms.Button();
            this.selectedRSAEncKey = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openRSAEncKeyButton = new System.Windows.Forms.Button();
            this.selectedRSAEncFile = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openRSAEncFileButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectRSAKeySize = new System.Windows.Forms.ComboBox();
            this.generateRSAKeysButton = new System.Windows.Forms.Button();
            this.saveAESKeyDialog = new System.Windows.Forms.SaveFileDialog();
            this.openAESEncFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAESEncKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAESEncFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openAESDecFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAESDecKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAESDecFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveRSAKeysDialog = new System.Windows.Forms.SaveFileDialog();
            this.openRSAEncFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openRSAEncKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRSAEncFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openRSADecFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openRSADecKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRSADecFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "AES Kriptografija";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AESDecButton);
            this.groupBox3.Controls.Add(this.selectedAESDecKey);
            this.groupBox3.Controls.Add(this.selectedAESDecFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.openAESDecKeyButton);
            this.groupBox3.Controls.Add(this.openAESDecFileButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dešifriranje";
            // 
            // AESDecButton
            // 
            this.AESDecButton.Location = new System.Drawing.Point(155, 131);
            this.AESDecButton.Name = "AESDecButton";
            this.AESDecButton.Size = new System.Drawing.Size(75, 23);
            this.AESDecButton.TabIndex = 8;
            this.AESDecButton.Text = "Dešifriraj";
            this.AESDecButton.UseVisualStyleBackColor = true;
            this.AESDecButton.Click += new System.EventHandler(this.AESDecButton_Click);
            // 
            // selectedAESDecKey
            // 
            this.selectedAESDecKey.Location = new System.Drawing.Point(177, 82);
            this.selectedAESDecKey.Name = "selectedAESDecKey";
            this.selectedAESDecKey.Size = new System.Drawing.Size(197, 35);
            this.selectedAESDecKey.TabIndex = 7;
            this.selectedAESDecKey.Text = "n/a";
            // 
            // selectedAESDecFile
            // 
            this.selectedAESDecFile.Location = new System.Drawing.Point(177, 25);
            this.selectedAESDecFile.Name = "selectedAESDecFile";
            this.selectedAESDecFile.Size = new System.Drawing.Size(197, 35);
            this.selectedAESDecFile.TabIndex = 7;
            this.selectedAESDecFile.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izbran ključ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izbrana datoteka:";
            // 
            // openAESDecKeyButton
            // 
            this.openAESDecKeyButton.Location = new System.Drawing.Point(7, 77);
            this.openAESDecKeyButton.Name = "openAESDecKeyButton";
            this.openAESDecKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openAESDecKeyButton.TabIndex = 1;
            this.openAESDecKeyButton.Text = "Ključ";
            this.openAESDecKeyButton.UseVisualStyleBackColor = true;
            this.openAESDecKeyButton.Click += new System.EventHandler(this.openAESDecKeyButton_Click);
            // 
            // openAESDecFileButton
            // 
            this.openAESDecFileButton.Location = new System.Drawing.Point(7, 20);
            this.openAESDecFileButton.Name = "openAESDecFileButton";
            this.openAESDecFileButton.Size = new System.Drawing.Size(75, 23);
            this.openAESDecFileButton.TabIndex = 0;
            this.openAESDecFileButton.Text = "Datoteka";
            this.openAESDecFileButton.UseVisualStyleBackColor = true;
            this.openAESDecFileButton.Click += new System.EventHandler(this.openAESDecFileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AESEncButton);
            this.groupBox2.Controls.Add(this.selectedAESEncKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.openAESEncKeyButton);
            this.groupBox2.Controls.Add(this.selectedAESEncFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.openAESEncFileButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Šifriranje";
            // 
            // AESEncButton
            // 
            this.AESEncButton.Location = new System.Drawing.Point(158, 128);
            this.AESEncButton.Name = "AESEncButton";
            this.AESEncButton.Size = new System.Drawing.Size(75, 23);
            this.AESEncButton.TabIndex = 6;
            this.AESEncButton.Text = "Šifriraj";
            this.AESEncButton.UseVisualStyleBackColor = true;
            this.AESEncButton.Click += new System.EventHandler(this.AESEncButton_Click);
            // 
            // selectedAESEncKey
            // 
            this.selectedAESEncKey.Location = new System.Drawing.Point(183, 77);
            this.selectedAESEncKey.Name = "selectedAESEncKey";
            this.selectedAESEncKey.Size = new System.Drawing.Size(197, 35);
            this.selectedAESEncKey.TabIndex = 5;
            this.selectedAESEncKey.Text = "n/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izbran ključ:";
            // 
            // openAESEncKeyButton
            // 
            this.openAESEncKeyButton.Location = new System.Drawing.Point(6, 72);
            this.openAESEncKeyButton.Name = "openAESEncKeyButton";
            this.openAESEncKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openAESEncKeyButton.TabIndex = 3;
            this.openAESEncKeyButton.Text = "Ključ";
            this.openAESEncKeyButton.UseVisualStyleBackColor = true;
            this.openAESEncKeyButton.Click += new System.EventHandler(this.openAESEncKeyButton_Click);
            // 
            // selectedAESEncFile
            // 
            this.selectedAESEncFile.Location = new System.Drawing.Point(183, 26);
            this.selectedAESEncFile.Name = "selectedAESEncFile";
            this.selectedAESEncFile.Size = new System.Drawing.Size(197, 35);
            this.selectedAESEncFile.TabIndex = 2;
            this.selectedAESEncFile.Text = "n/a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izbrana datoteka:";
            // 
            // openAESEncFileButton
            // 
            this.openAESEncFileButton.Location = new System.Drawing.Point(6, 21);
            this.openAESEncFileButton.Name = "openAESEncFileButton";
            this.openAESEncFileButton.Size = new System.Drawing.Size(75, 23);
            this.openAESEncFileButton.TabIndex = 0;
            this.openAESEncFileButton.Text = "Datoteka";
            this.openAESEncFileButton.UseVisualStyleBackColor = true;
            this.openAESEncFileButton.Click += new System.EventHandler(this.openAESEncFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectAESKeySize);
            this.groupBox1.Controls.Add(this.generateAESKeyButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generiranje ključa";
            // 
            // selectAESKeySize
            // 
            this.selectAESKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAESKeySize.FormattingEnabled = true;
            this.selectAESKeySize.ItemHeight = 13;
            this.selectAESKeySize.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.selectAESKeySize.Location = new System.Drawing.Point(6, 19);
            this.selectAESKeySize.Name = "selectAESKeySize";
            this.selectAESKeySize.Size = new System.Drawing.Size(45, 21);
            this.selectAESKeySize.TabIndex = 1;
            this.selectAESKeySize.SelectedIndexChanged += new System.EventHandler(this.selectAESKeySize_SelectedIndexChanged);
            // 
            // generateAESKeyButton
            // 
            this.generateAESKeyButton.Location = new System.Drawing.Point(62, 18);
            this.generateAESKeyButton.Name = "generateAESKeyButton";
            this.generateAESKeyButton.Size = new System.Drawing.Size(91, 23);
            this.generateAESKeyButton.TabIndex = 0;
            this.generateAESKeyButton.Text = "Shrani ključ";
            this.generateAESKeyButton.UseVisualStyleBackColor = true;
            this.generateAESKeyButton.Click += new System.EventHandler(this.generateAESKeyButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "RSA Kriptografija";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RSADecButton);
            this.groupBox6.Controls.Add(this.selectedRSADecKey);
            this.groupBox6.Controls.Add(this.selectedRSADecFile);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.openRSADecKeyButton);
            this.groupBox6.Controls.Add(this.openRSADecFileButton);
            this.groupBox6.Location = new System.Drawing.Point(6, 279);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 165);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dešifriranje z zasebnim ključem";
            // 
            // RSADecButton
            // 
            this.RSADecButton.Location = new System.Drawing.Point(155, 131);
            this.RSADecButton.Name = "RSADecButton";
            this.RSADecButton.Size = new System.Drawing.Size(75, 23);
            this.RSADecButton.TabIndex = 8;
            this.RSADecButton.Text = "Dešifriraj";
            this.RSADecButton.UseVisualStyleBackColor = true;
            this.RSADecButton.Click += new System.EventHandler(this.RSADecButton_Click);
            // 
            // selectedRSADecKey
            // 
            this.selectedRSADecKey.Location = new System.Drawing.Point(177, 82);
            this.selectedRSADecKey.Name = "selectedRSADecKey";
            this.selectedRSADecKey.Size = new System.Drawing.Size(197, 35);
            this.selectedRSADecKey.TabIndex = 7;
            this.selectedRSADecKey.Text = "n/a";
            // 
            // selectedRSADecFile
            // 
            this.selectedRSADecFile.Location = new System.Drawing.Point(177, 25);
            this.selectedRSADecFile.Name = "selectedRSADecFile";
            this.selectedRSADecFile.Size = new System.Drawing.Size(197, 35);
            this.selectedRSADecFile.TabIndex = 7;
            this.selectedRSADecFile.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Izbran ključ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Izbrana datoteka:";
            // 
            // openRSADecKeyButton
            // 
            this.openRSADecKeyButton.Location = new System.Drawing.Point(7, 77);
            this.openRSADecKeyButton.Name = "openRSADecKeyButton";
            this.openRSADecKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openRSADecKeyButton.TabIndex = 1;
            this.openRSADecKeyButton.Text = "Ključ";
            this.openRSADecKeyButton.UseVisualStyleBackColor = true;
            this.openRSADecKeyButton.Click += new System.EventHandler(this.openRSADecKeyButton_Click);
            // 
            // openRSADecFileButton
            // 
            this.openRSADecFileButton.Location = new System.Drawing.Point(7, 20);
            this.openRSADecFileButton.Name = "openRSADecFileButton";
            this.openRSADecFileButton.Size = new System.Drawing.Size(75, 23);
            this.openRSADecFileButton.TabIndex = 0;
            this.openRSADecFileButton.Text = "Datoteka";
            this.openRSADecFileButton.UseVisualStyleBackColor = true;
            this.openRSADecFileButton.Click += new System.EventHandler(this.openRSADecFileButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RSAEncButton);
            this.groupBox5.Controls.Add(this.selectedRSAEncKey);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.openRSAEncKeyButton);
            this.groupBox5.Controls.Add(this.selectedRSAEncFile);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.openRSAEncFileButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 164);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Šifriranje z javnim ključem";
            // 
            // RSAEncButton
            // 
            this.RSAEncButton.Location = new System.Drawing.Point(158, 128);
            this.RSAEncButton.Name = "RSAEncButton";
            this.RSAEncButton.Size = new System.Drawing.Size(75, 23);
            this.RSAEncButton.TabIndex = 6;
            this.RSAEncButton.Text = "Šifriraj";
            this.RSAEncButton.UseVisualStyleBackColor = true;
            this.RSAEncButton.Click += new System.EventHandler(this.RSAEncButton_Click);
            // 
            // selectedRSAEncKey
            // 
            this.selectedRSAEncKey.Location = new System.Drawing.Point(183, 77);
            this.selectedRSAEncKey.Name = "selectedRSAEncKey";
            this.selectedRSAEncKey.Size = new System.Drawing.Size(197, 35);
            this.selectedRSAEncKey.TabIndex = 5;
            this.selectedRSAEncKey.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Izbran ključ:";
            // 
            // openRSAEncKeyButton
            // 
            this.openRSAEncKeyButton.Location = new System.Drawing.Point(6, 72);
            this.openRSAEncKeyButton.Name = "openRSAEncKeyButton";
            this.openRSAEncKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openRSAEncKeyButton.TabIndex = 3;
            this.openRSAEncKeyButton.Text = "Ključ";
            this.openRSAEncKeyButton.UseVisualStyleBackColor = true;
            this.openRSAEncKeyButton.Click += new System.EventHandler(this.openRSAEncKeyButton_Click);
            // 
            // selectedRSAEncFile
            // 
            this.selectedRSAEncFile.Location = new System.Drawing.Point(183, 26);
            this.selectedRSAEncFile.Name = "selectedRSAEncFile";
            this.selectedRSAEncFile.Size = new System.Drawing.Size(197, 35);
            this.selectedRSAEncFile.TabIndex = 2;
            this.selectedRSAEncFile.Text = "n/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Izbrana datoteka:";
            // 
            // openRSAEncFileButton
            // 
            this.openRSAEncFileButton.Location = new System.Drawing.Point(6, 21);
            this.openRSAEncFileButton.Name = "openRSAEncFileButton";
            this.openRSAEncFileButton.Size = new System.Drawing.Size(75, 23);
            this.openRSAEncFileButton.TabIndex = 0;
            this.openRSAEncFileButton.Text = "Datoteka";
            this.openRSAEncFileButton.UseVisualStyleBackColor = true;
            this.openRSAEncFileButton.Click += new System.EventHandler(this.openRSAEncFileButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selectRSAKeySize);
            this.groupBox4.Controls.Add(this.generateRSAKeysButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generiranje ključa";
            // 
            // selectRSAKeySize
            // 
            this.selectRSAKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRSAKeySize.FormattingEnabled = true;
            this.selectRSAKeySize.ItemHeight = 13;
            this.selectRSAKeySize.Items.AddRange(new object[] {
            "1024",
            "2048"});
            this.selectRSAKeySize.Location = new System.Drawing.Point(6, 19);
            this.selectRSAKeySize.Name = "selectRSAKeySize";
            this.selectRSAKeySize.Size = new System.Drawing.Size(50, 21);
            this.selectRSAKeySize.TabIndex = 1;
            this.selectRSAKeySize.SelectedIndexChanged += new System.EventHandler(this.selectRSAKeySize_SelectedIndexChanged);
            // 
            // generateRSAKeysButton
            // 
            this.generateRSAKeysButton.Location = new System.Drawing.Point(62, 18);
            this.generateRSAKeysButton.Name = "generateRSAKeysButton";
            this.generateRSAKeysButton.Size = new System.Drawing.Size(91, 23);
            this.generateRSAKeysButton.TabIndex = 0;
            this.generateRSAKeysButton.Text = "Shrani ključa";
            this.generateRSAKeysButton.UseVisualStyleBackColor = true;
            this.generateRSAKeysButton.Click += new System.EventHandler(this.generateRSAKeysButton_Click);
            // 
            // saveAESKeyDialog
            // 
            this.saveAESKeyDialog.Filter = "All files|*.*";
            this.saveAESKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESKeyDialog_FileOk);
            // 
            // openAESEncFileDialog
            // 
            this.openAESEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESEncFileDialog_FileOk);
            // 
            // openAESEncKeyDialog
            // 
            this.openAESEncKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESEncKeyDialog_FileOk);
            // 
            // saveAESEncFileDialog
            // 
            this.saveAESEncFileDialog.Filter = "All files|*.*";
            this.saveAESEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESEncFileDialog_FileOk);
            // 
            // openAESDecFileDialog
            // 
            this.openAESDecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESDecFileDialog_FileOk);
            // 
            // openAESDecKeyDialog
            // 
            this.openAESDecKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESDecKeyDialog_FileOk);
            // 
            // saveAESDecFileDialog
            // 
            this.saveAESDecFileDialog.Filter = "All files|*.*";
            this.saveAESDecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESDecFileDialog_FileOk);
            // 
            // saveRSAKeysDialog
            // 
            this.saveRSAKeysDialog.Filter = "All files|*.*";
            this.saveRSAKeysDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSAKeysDialog_FileOk);
            // 
            // openRSAEncFileDialog
            // 
            this.openRSAEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSAEncFileDialog_FileOk);
            // 
            // openRSAEncKeyDialog
            // 
            this.openRSAEncKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSAEncKeyDialog_FileOk);
            // 
            // saveRSAEncFileDialog
            // 
            this.saveRSAEncFileDialog.Filter = "All files|*.*";
            this.saveRSAEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSAEncFileDialog_FileOk);
            // 
            // openRSADecFileDialog
            // 
            this.openRSADecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSADecFileDialog_FileOk);
            // 
            // openRSADecKeyDialog
            // 
            this.openRSADecKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSADecKeyDialog_FileOk);
            // 
            // saveRSADecFileDialog
            // 
            this.saveRSADecFileDialog.Filter = "All files|*.*";
            this.saveRSADecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSADecFileDialog_FileOk);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 507);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriptografija";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button generateAESKeyButton;
        private System.Windows.Forms.SaveFileDialog saveAESKeyDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectAESKeySize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button openAESEncFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedAESEncFile;
        private System.Windows.Forms.OpenFileDialog openAESEncFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openAESEncKeyButton;
        private System.Windows.Forms.OpenFileDialog openAESEncKeyDialog;
        private System.Windows.Forms.Label selectedAESEncKey;
        private System.Windows.Forms.Button AESEncButton;
        private System.Windows.Forms.SaveFileDialog saveAESEncFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label selectedAESDecKey;
        private System.Windows.Forms.Label selectedAESDecFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openAESDecKeyButton;
        private System.Windows.Forms.Button openAESDecFileButton;
        private System.Windows.Forms.Button AESDecButton;
        private System.Windows.Forms.OpenFileDialog openAESDecFileDialog;
        private System.Windows.Forms.OpenFileDialog openAESDecKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveAESDecFileDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox selectRSAKeySize;
        private System.Windows.Forms.Button generateRSAKeysButton;
        private System.Windows.Forms.SaveFileDialog saveRSAKeysDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button RSAEncButton;
        private System.Windows.Forms.Label selectedRSAEncKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openRSAEncKeyButton;
        private System.Windows.Forms.Label selectedRSAEncFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openRSAEncFileButton;
        private System.Windows.Forms.OpenFileDialog openRSAEncFileDialog;
        private System.Windows.Forms.OpenFileDialog openRSAEncKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveRSAEncFileDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button RSADecButton;
        private System.Windows.Forms.Label selectedRSADecKey;
        private System.Windows.Forms.Label selectedRSADecFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button openRSADecKeyButton;
        private System.Windows.Forms.Button openRSADecFileButton;
        private System.Windows.Forms.OpenFileDialog openRSADecFileDialog;
        private System.Windows.Forms.OpenFileDialog openRSADecKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveRSADecFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

