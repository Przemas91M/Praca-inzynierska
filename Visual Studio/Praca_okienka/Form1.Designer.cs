namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.przyciskFiltruj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataDoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KodKartyBox = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dataOdBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.kodKarty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.przyciskSprawdzKarte = new System.Windows.Forms.Button();
            this.przyciskDodajPracownika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.przyciskUsun = new System.Windows.Forms.Button();
            this.przyciskOdswiez = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nazwiskoUsunBox = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.NazwabazyBox = new System.Windows.Forms.TextBox();
            this.SerwerbazyBox = new System.Windows.Forms.TextBox();
            this.Polacz = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.stoperBox = new System.Windows.Forms.TextBox();
            this.port_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adres_IP = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Dataczas = new System.Windows.Forms.Label();
            this.Uruchom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Zamknij = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 500);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Podgląd ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(6, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Osoby logujące się w dniu dzisiejszym:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.przyciskFiltruj);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dataDoBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.KodKartyBox);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.dataOdBox);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.NazwiskoBox);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Przegladaj bazę logowań";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // przyciskFiltruj
            // 
            this.przyciskFiltruj.Location = new System.Drawing.Point(588, 285);
            this.przyciskFiltruj.Name = "przyciskFiltruj";
            this.przyciskFiltruj.Size = new System.Drawing.Size(164, 57);
            this.przyciskFiltruj.TabIndex = 13;
            this.przyciskFiltruj.Text = "Filtruj";
            this.przyciskFiltruj.UseVisualStyleBackColor = true;
            this.przyciskFiltruj.Click += new System.EventHandler(this.przyciskFiltruj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "rrrr-mm-dd gg:mm:ss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Format daty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Do:";
            // 
            // dataDoBox
            // 
            this.dataDoBox.Location = new System.Drawing.Point(585, 196);
            this.dataDoBox.Name = "dataDoBox";
            this.dataDoBox.Size = new System.Drawing.Size(167, 20);
            this.dataDoBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Od:";
            // 
            // KodKartyBox
            // 
            this.KodKartyBox.Location = new System.Drawing.Point(585, 245);
            this.KodKartyBox.Name = "KodKartyBox";
            this.KodKartyBox.Size = new System.Drawing.Size(167, 20);
            this.KodKartyBox.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(585, 222);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Kod karty dostępu";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // dataOdBox
            // 
            this.dataOdBox.Location = new System.Drawing.Point(585, 157);
            this.dataOdBox.Name = "dataOdBox";
            this.dataOdBox.Size = new System.Drawing.Size(167, 20);
            this.dataOdBox.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(585, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Po dacie";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(586, 55);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(167, 20);
            this.NazwiskoBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(586, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Po nazwisku";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(586, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filtrowanie bazy";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 461);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.kodKarty);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.przyciskSprawdzKarte);
            this.tabPage4.Controls.Add(this.przyciskDodajPracownika);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(760, 471);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dodaj nowego pracownika";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(6, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(301, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "Lista aktualnie zarejestrowanych pracowników:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(585, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Odczytany kod karty:";
            // 
            // kodKarty
            // 
            this.kodKarty.Location = new System.Drawing.Point(585, 336);
            this.kodKarty.Name = "kodKarty";
            this.kodKarty.ReadOnly = true;
            this.kodKarty.Size = new System.Drawing.Size(165, 20);
            this.kodKarty.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 377);
            this.label15.MaximumSize = new System.Drawing.Size(180, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 39);
            this.label15.TabIndex = 11;
            this.label15.Text = "Pamietaj, aby PRZED nacisnieciem przycisku, przylozyc karte do czytnika!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Uwaga!";
            // 
            // przyciskSprawdzKarte
            // 
            this.przyciskSprawdzKarte.Location = new System.Drawing.Point(584, 260);
            this.przyciskSprawdzKarte.Name = "przyciskSprawdzKarte";
            this.przyciskSprawdzKarte.Size = new System.Drawing.Size(169, 53);
            this.przyciskSprawdzKarte.TabIndex = 9;
            this.przyciskSprawdzKarte.Text = "Sprawdź kod karty";
            this.przyciskSprawdzKarte.UseVisualStyleBackColor = true;
            this.przyciskSprawdzKarte.Click += new System.EventHandler(this.przyciskSprawdzKarte_Click);
            // 
            // przyciskDodajPracownika
            // 
            this.przyciskDodajPracownika.Location = new System.Drawing.Point(585, 201);
            this.przyciskDodajPracownika.Name = "przyciskDodajPracownika";
            this.przyciskDodajPracownika.Size = new System.Drawing.Size(169, 53);
            this.przyciskDodajPracownika.TabIndex = 8;
            this.przyciskDodajPracownika.Text = "Dodaj pracownika";
            this.przyciskDodajPracownika.UseVisualStyleBackColor = true;
            this.przyciskDodajPracownika.Click += new System.EventHandler(this.przyciskDodajPracownika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Odśwież listę pracowników";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(588, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kod karty dostępu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(588, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Imię";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nazwisko";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(544, 435);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.przyciskUsun);
            this.tabPage5.Controls.Add(this.przyciskOdswiez);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.nazwiskoUsunBox);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(760, 471);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Usuń pracownika";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(301, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Lista aktualnie zarejestrowanych pracowników:";
            // 
            // przyciskUsun
            // 
            this.przyciskUsun.Location = new System.Drawing.Point(574, 136);
            this.przyciskUsun.Name = "przyciskUsun";
            this.przyciskUsun.Size = new System.Drawing.Size(181, 46);
            this.przyciskUsun.TabIndex = 6;
            this.przyciskUsun.Text = "Usuń pracownika";
            this.przyciskUsun.UseVisualStyleBackColor = true;
            this.przyciskUsun.Click += new System.EventHandler(this.przyciskUsun_Click);
            // 
            // przyciskOdswiez
            // 
            this.przyciskOdswiez.Location = new System.Drawing.Point(574, 70);
            this.przyciskOdswiez.Name = "przyciskOdswiez";
            this.przyciskOdswiez.Size = new System.Drawing.Size(181, 46);
            this.przyciskOdswiez.TabIndex = 5;
            this.przyciskOdswiez.Text = "Odśwież listę pracowników";
            this.przyciskOdswiez.UseVisualStyleBackColor = true;
            this.przyciskOdswiez.Click += new System.EventHandler(this.przyciskOdswiez_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kod karty dostępu pracownika";
            // 
            // nazwiskoUsunBox
            // 
            this.nazwiskoUsunBox.Location = new System.Drawing.Point(573, 22);
            this.nazwiskoUsunBox.Name = "nazwiskoUsunBox";
            this.nazwiskoUsunBox.Size = new System.Drawing.Size(181, 20);
            this.nazwiskoUsunBox.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 22);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(544, 445);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.NazwabazyBox);
            this.tabPage2.Controls.Add(this.SerwerbazyBox);
            this.tabPage2.Controls.Add(this.Polacz);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.stoperBox);
            this.tabPage2.Controls.Add(this.port_Text);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.adres_IP);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ustawienia";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(6, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(163, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Nazwa bazy danych:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(6, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(228, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "Nazwa serwera bazy danych:";
            // 
            // NazwabazyBox
            // 
            this.NazwabazyBox.Location = new System.Drawing.Point(10, 227);
            this.NazwabazyBox.Name = "NazwabazyBox";
            this.NazwabazyBox.Size = new System.Drawing.Size(224, 20);
            this.NazwabazyBox.TabIndex = 14;
            this.NazwabazyBox.Text = "SystemRejestracjiObecnosci";
            // 
            // SerwerbazyBox
            // 
            this.SerwerbazyBox.Location = new System.Drawing.Point(10, 160);
            this.SerwerbazyBox.Name = "SerwerbazyBox";
            this.SerwerbazyBox.Size = new System.Drawing.Size(224, 20);
            this.SerwerbazyBox.TabIndex = 13;
            this.SerwerbazyBox.Text = "LAPEK\\SQLEXPRESS";
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(585, 20);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(145, 27);
            this.Polacz.TabIndex = 3;
            this.Polacz.Text = "Połącz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.Polacz_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(6, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(423, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Czas ignorowania identycznych wpisów (w sekundach):";
            // 
            // stoperBox
            // 
            this.stoperBox.Location = new System.Drawing.Point(435, 93);
            this.stoperBox.Name = "stoperBox";
            this.stoperBox.Size = new System.Drawing.Size(30, 20);
            this.stoperBox.TabIndex = 11;
            this.stoperBox.Text = "5";
            // 
            // port_Text
            // 
            this.port_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.port_Text.Location = new System.Drawing.Point(184, 50);
            this.port_Text.Name = "port_Text";
            this.port_Text.Size = new System.Drawing.Size(71, 26);
            this.port_Text.TabIndex = 9;
            this.port_Text.Text = "23";
            this.port_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(197, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres IP:";
            // 
            // adres_IP
            // 
            this.adres_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres_IP.Location = new System.Drawing.Point(6, 50);
            this.adres_IP.Name = "adres_IP";
            this.adres_IP.Size = new System.Drawing.Size(123, 26);
            this.adres_IP.TabIndex = 0;
            this.adres_IP.Text = "192.168.0.100";
            this.adres_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(433, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data i godzina:";
            // 
            // Dataczas
            // 
            this.Dataczas.AutoSize = true;
            this.Dataczas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dataczas.Location = new System.Drawing.Point(433, 36);
            this.Dataczas.Name = "Dataczas";
            this.Dataczas.Size = new System.Drawing.Size(53, 20);
            this.Dataczas.TabIndex = 2;
            this.Dataczas.Text = "label2";
            // 
            // Uruchom
            // 
            this.Uruchom.Location = new System.Drawing.Point(12, 16);
            this.Uruchom.Name = "Uruchom";
            this.Uruchom.Size = new System.Drawing.Size(145, 53);
            this.Uruchom.TabIndex = 4;
            this.Uruchom.Text = "Uruchom";
            this.Uruchom.UseVisualStyleBackColor = true;
            this.Uruchom.Click += new System.EventHandler(this.Uruchom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(209, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.Location = new System.Drawing.Point(192, 36);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(96, 20);
            this.Status.TabIndex = 6;
            this.Status.Text = "Rozłączony";
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(635, 7);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(145, 62);
            this.Zamknij.TabIndex = 7;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 611);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Uruchom);
            this.Controls.Add(this.Dataczas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "System rejestracji obecnosci   ©Przemyslaw Mordyl";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dataczas;
        private System.Windows.Forms.Button Polacz;
        private System.Windows.Forms.Button Uruchom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox port_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adres_IP;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox KodKartyBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox dataOdBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button przyciskFiltruj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dataDoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button przyciskDodajPracownika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nazwiskoUsunBox;
        private System.Windows.Forms.Button przyciskUsun;
        private System.Windows.Forms.Button przyciskOdswiez;
        private System.Windows.Forms.Button przyciskSprawdzKarte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kodKarty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox stoperBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox NazwabazyBox;
        private System.Windows.Forms.TextBox SerwerbazyBox;
    }
}

