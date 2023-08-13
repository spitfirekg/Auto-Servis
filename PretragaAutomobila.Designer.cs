namespace Auto_Servis
{
    partial class PretragaAutomobila
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            tbPretraga = new TextBox();
            buttonPretragaVozila = new Button();
            panelRezPretrage = new Panel();
            tbId1 = new TextBox();
            buttonServisInfo = new Button();
            buttonIzbrisi = new Button();
            buttonIzmeni = new Button();
            tbTelefon1 = new TextBox();
            tbMotor1 = new TextBox();
            tbVlasnik1 = new TextBox();
            tbGorivo1 = new TextBox();
            tbSasija1 = new TextBox();
            tbGodiste1 = new TextBox();
            tbKilometraza1 = new TextBox();
            tbModel1 = new TextBox();
            tbRegistracija1 = new TextBox();
            tbMarka1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelServisInfo = new Panel();
            labelCena = new Label();
            tbCena = new TextBox();
            buttonServisPdf = new Button();
            buttonSacuvajServis = new Button();
            tbDodajServis = new TextBox();
            buttonDodajServis = new Button();
            dgServisInfo = new DataGridView();
            panelRezPretrage.SuspendLayout();
            panelServisInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgServisInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(186, 11);
            label1.Name = "label1";
            label1.Size = new Size(748, 28);
            label1.TabIndex = 1;
            label1.Text = "Pretraga je omogućena po registraciji,imenu vlasnika ili broju šasije vozila";
            // 
            // tbPretraga
            // 
            tbPretraga.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbPretraga.Location = new Point(28, 53);
            tbPretraga.Name = "tbPretraga";
            tbPretraga.Size = new Size(485, 31);
            tbPretraga.TabIndex = 2;
            tbPretraga.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonPretragaVozila
            // 
            buttonPretragaVozila.BackColor = Color.Aqua;
            buttonPretragaVozila.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPretragaVozila.Location = new Point(528, 53);
            buttonPretragaVozila.Name = "buttonPretragaVozila";
            buttonPretragaVozila.Size = new Size(141, 29);
            buttonPretragaVozila.TabIndex = 3;
            buttonPretragaVozila.Text = "Pretraga";
            buttonPretragaVozila.UseVisualStyleBackColor = false;
            buttonPretragaVozila.Click += buttonPretragaVozila_Click;
            // 
            // panelRezPretrage
            // 
            panelRezPretrage.Controls.Add(tbId1);
            panelRezPretrage.Controls.Add(buttonServisInfo);
            panelRezPretrage.Controls.Add(buttonIzbrisi);
            panelRezPretrage.Controls.Add(buttonIzmeni);
            panelRezPretrage.Controls.Add(tbTelefon1);
            panelRezPretrage.Controls.Add(tbMotor1);
            panelRezPretrage.Controls.Add(tbVlasnik1);
            panelRezPretrage.Controls.Add(tbGorivo1);
            panelRezPretrage.Controls.Add(tbSasija1);
            panelRezPretrage.Controls.Add(tbGodiste1);
            panelRezPretrage.Controls.Add(tbKilometraza1);
            panelRezPretrage.Controls.Add(tbModel1);
            panelRezPretrage.Controls.Add(tbRegistracija1);
            panelRezPretrage.Controls.Add(tbMarka1);
            panelRezPretrage.Controls.Add(label11);
            panelRezPretrage.Controls.Add(label10);
            panelRezPretrage.Controls.Add(label6);
            panelRezPretrage.Controls.Add(label9);
            panelRezPretrage.Controls.Add(label5);
            panelRezPretrage.Controls.Add(label8);
            panelRezPretrage.Controls.Add(label4);
            panelRezPretrage.Controls.Add(label7);
            panelRezPretrage.Controls.Add(label3);
            panelRezPretrage.Controls.Add(label2);
            panelRezPretrage.Location = new Point(28, 86);
            panelRezPretrage.Name = "panelRezPretrage";
            panelRezPretrage.Size = new Size(1106, 203);
            panelRezPretrage.TabIndex = 4;
            // 
            // tbId1
            // 
            tbId1.Location = new Point(119, 172);
            tbId1.Name = "tbId1";
            tbId1.Size = new Size(125, 27);
            tbId1.TabIndex = 5;
            tbId1.Visible = false;
            // 
            // buttonServisInfo
            // 
            buttonServisInfo.BackColor = Color.LightGreen;
            buttonServisInfo.FlatAppearance.BorderSize = 0;
            buttonServisInfo.FlatStyle = FlatStyle.Flat;
            buttonServisInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonServisInfo.Location = new Point(865, 117);
            buttonServisInfo.Name = "buttonServisInfo";
            buttonServisInfo.Size = new Size(238, 54);
            buttonServisInfo.TabIndex = 2;
            buttonServisInfo.Text = "SERVIS INFO";
            buttonServisInfo.UseVisualStyleBackColor = false;
            buttonServisInfo.Click += buttonServisInfo_Click;
            // 
            // buttonIzbrisi
            // 
            buttonIzbrisi.BackColor = Color.Red;
            buttonIzbrisi.FlatAppearance.BorderSize = 0;
            buttonIzbrisi.FlatStyle = FlatStyle.Flat;
            buttonIzbrisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIzbrisi.Location = new Point(865, 62);
            buttonIzbrisi.Name = "buttonIzbrisi";
            buttonIzbrisi.Size = new Size(238, 49);
            buttonIzbrisi.TabIndex = 2;
            buttonIzbrisi.Text = "IZBRIŠI";
            buttonIzbrisi.UseVisualStyleBackColor = false;
            buttonIzbrisi.Click += buttonIzbrisi_Click;
            // 
            // buttonIzmeni
            // 
            buttonIzmeni.BackColor = Color.DarkOrange;
            buttonIzmeni.FlatAppearance.BorderSize = 0;
            buttonIzmeni.FlatStyle = FlatStyle.Flat;
            buttonIzmeni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIzmeni.Location = new Point(865, 5);
            buttonIzmeni.Name = "buttonIzmeni";
            buttonIzmeni.Size = new Size(238, 51);
            buttonIzmeni.TabIndex = 2;
            buttonIzmeni.Text = "IZMENI";
            buttonIzmeni.UseVisualStyleBackColor = false;
            buttonIzmeni.Click += buttonIzmeni_Click;
            // 
            // tbTelefon1
            // 
            tbTelefon1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbTelefon1.Location = new Point(538, 144);
            tbTelefon1.Name = "tbTelefon1";
            tbTelefon1.Size = new Size(310, 27);
            tbTelefon1.TabIndex = 1;
            tbTelefon1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMotor1
            // 
            tbMotor1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbMotor1.Location = new Point(119, 144);
            tbMotor1.Name = "tbMotor1";
            tbMotor1.Size = new Size(310, 27);
            tbMotor1.TabIndex = 1;
            tbMotor1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbVlasnik1
            // 
            tbVlasnik1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbVlasnik1.Location = new Point(538, 110);
            tbVlasnik1.Name = "tbVlasnik1";
            tbVlasnik1.Size = new Size(310, 27);
            tbVlasnik1.TabIndex = 1;
            tbVlasnik1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbGorivo1
            // 
            tbGorivo1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbGorivo1.Location = new Point(119, 110);
            tbGorivo1.Name = "tbGorivo1";
            tbGorivo1.Size = new Size(310, 27);
            tbGorivo1.TabIndex = 1;
            tbGorivo1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSasija1
            // 
            tbSasija1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbSasija1.Location = new Point(538, 77);
            tbSasija1.Name = "tbSasija1";
            tbSasija1.Size = new Size(310, 27);
            tbSasija1.TabIndex = 1;
            tbSasija1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbGodiste1
            // 
            tbGodiste1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbGodiste1.Location = new Point(119, 77);
            tbGodiste1.Name = "tbGodiste1";
            tbGodiste1.Size = new Size(310, 27);
            tbGodiste1.TabIndex = 1;
            tbGodiste1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbKilometraza1
            // 
            tbKilometraza1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbKilometraza1.Location = new Point(538, 42);
            tbKilometraza1.Name = "tbKilometraza1";
            tbKilometraza1.Size = new Size(310, 27);
            tbKilometraza1.TabIndex = 1;
            tbKilometraza1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbModel1
            // 
            tbModel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbModel1.Location = new Point(119, 42);
            tbModel1.Name = "tbModel1";
            tbModel1.Size = new Size(310, 27);
            tbModel1.TabIndex = 1;
            tbModel1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRegistracija1
            // 
            tbRegistracija1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbRegistracija1.Location = new Point(538, 7);
            tbRegistracija1.Name = "tbRegistracija1";
            tbRegistracija1.Size = new Size(310, 27);
            tbRegistracija1.TabIndex = 1;
            tbRegistracija1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMarka1
            // 
            tbMarka1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbMarka1.Location = new Point(119, 7);
            tbMarka1.Name = "tbMarka1";
            tbMarka1.Size = new Size(310, 27);
            tbMarka1.TabIndex = 1;
            tbMarka1.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(435, 151);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 0;
            label11.Text = "Telefon : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(435, 117);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 0;
            label10.Text = "Ime Vlasnika : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 151);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 0;
            label6.Text = "Motor : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 84);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 0;
            label9.Text = "Br. Sasije";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 117);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 0;
            label5.Text = "Gorivo : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 49);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 0;
            label8.Text = "Kilometraza : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 84);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 0;
            label4.Text = "Godiste : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 14);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 0;
            label7.Text = "Registracija : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 49);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Model : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 14);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Marka : ";
            // 
            // panelServisInfo
            // 
            panelServisInfo.Controls.Add(labelCena);
            panelServisInfo.Controls.Add(tbCena);
            panelServisInfo.Controls.Add(buttonServisPdf);
            panelServisInfo.Controls.Add(buttonSacuvajServis);
            panelServisInfo.Controls.Add(tbDodajServis);
            panelServisInfo.Controls.Add(buttonDodajServis);
            panelServisInfo.Controls.Add(dgServisInfo);
            panelServisInfo.Location = new Point(28, 295);
            panelServisInfo.Name = "panelServisInfo";
            panelServisInfo.Size = new Size(1103, 291);
            panelServisInfo.TabIndex = 5;
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCena.Location = new Point(879, 240);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(71, 23);
            labelCena.TabIndex = 5;
            labelCena.Text = "CENA : ";
            // 
            // tbCena
            // 
            tbCena.Location = new Point(956, 236);
            tbCena.Name = "tbCena";
            tbCena.Size = new Size(144, 27);
            tbCena.TabIndex = 4;
            // 
            // buttonServisPdf
            // 
            buttonServisPdf.BackColor = Color.Violet;
            buttonServisPdf.FlatAppearance.BorderSize = 0;
            buttonServisPdf.FlatStyle = FlatStyle.Flat;
            buttonServisPdf.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonServisPdf.Location = new Point(865, 83);
            buttonServisPdf.Name = "buttonServisPdf";
            buttonServisPdf.Size = new Size(235, 75);
            buttonServisPdf.TabIndex = 3;
            buttonServisPdf.Text = "Sačuvaj PDF";
            buttonServisPdf.UseVisualStyleBackColor = false;
            buttonServisPdf.Click += buttonServisPdf_Click;
            // 
            // buttonSacuvajServis
            // 
            buttonSacuvajServis.BackColor = Color.Aqua;
            buttonSacuvajServis.FlatAppearance.BorderSize = 0;
            buttonSacuvajServis.FlatStyle = FlatStyle.Flat;
            buttonSacuvajServis.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSacuvajServis.Location = new Point(865, 3);
            buttonSacuvajServis.Name = "buttonSacuvajServis";
            buttonSacuvajServis.Size = new Size(235, 74);
            buttonSacuvajServis.TabIndex = 3;
            buttonSacuvajServis.Text = "Sačuvaj Servis";
            buttonSacuvajServis.UseVisualStyleBackColor = false;
            buttonSacuvajServis.Click += buttonSacuvajServis_Click;
            // 
            // tbDodajServis
            // 
            tbDodajServis.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            tbDodajServis.Location = new Point(0, 0);
            tbDodajServis.Multiline = true;
            tbDodajServis.Name = "tbDodajServis";
            tbDodajServis.Size = new Size(848, 291);
            tbDodajServis.TabIndex = 2;
            // 
            // buttonDodajServis
            // 
            buttonDodajServis.BackColor = Color.DeepSkyBlue;
            buttonDodajServis.FlatAppearance.BorderSize = 0;
            buttonDodajServis.FlatStyle = FlatStyle.Flat;
            buttonDodajServis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDodajServis.Location = new Point(865, 3);
            buttonDodajServis.Name = "buttonDodajServis";
            buttonDodajServis.Size = new Size(235, 74);
            buttonDodajServis.TabIndex = 1;
            buttonDodajServis.Text = "Dodaj Servis";
            buttonDodajServis.UseVisualStyleBackColor = false;
            buttonDodajServis.Click += buttonDodajServis_Click;
            // 
            // dgServisInfo
            // 
            dgServisInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgServisInfo.BackgroundColor = Color.White;
            dgServisInfo.BorderStyle = BorderStyle.Fixed3D;
            dgServisInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgServisInfo.DefaultCellStyle = dataGridViewCellStyle1;
            dgServisInfo.Location = new Point(0, 0);
            dgServisInfo.Name = "dgServisInfo";
            dgServisInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgServisInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgServisInfo.RowTemplate.Height = 29;
            dgServisInfo.Size = new Size(848, 291);
            dgServisInfo.TabIndex = 0;
            // 
            // PretragaAutomobila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panelServisInfo);
            Controls.Add(panelRezPretrage);
            Controls.Add(buttonPretragaVozila);
            Controls.Add(tbPretraga);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "PretragaAutomobila";
            Size = new Size(1156, 598);
            panelRezPretrage.ResumeLayout(false);
            panelRezPretrage.PerformLayout();
            panelServisInfo.ResumeLayout(false);
            panelServisInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgServisInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbPretraga;
        private Button buttonPretragaVozila;
        private Panel panelRezPretrage;
        private Label label3;
        private Label label2;
        private TextBox tbTelefon1;
        private TextBox tbMotor1;
        private TextBox tbVlasnik1;
        private TextBox tbGorivo1;
        private TextBox tbSasija1;
        private TextBox tbGodiste1;
        private TextBox tbKilometraza1;
        private TextBox tbModel1;
        private TextBox tbRegistracija1;
        private TextBox tbMarka1;
        private Label label11;
        private Label label10;
        private Label label6;
        private Label label9;
        private Label label5;
        private Label label8;
        private Label label4;
        private Label label7;
        private Button buttonServisInfo;
        private Button buttonIzbrisi;
        private Button buttonIzmeni;
        private TextBox tbId1;
        private Panel panelServisInfo;
        private Button buttonDodajServis;
        private DataGridView dgServisInfo;
        private Button buttonServisPdf;
        private Button buttonSacuvajServis;
        private TextBox tbDodajServis;
        private Label labelCena;
        private TextBox tbCena;
    }
}
