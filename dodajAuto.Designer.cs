namespace Auto_Servis
{
    partial class dodajAuto
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
            label1 = new Label();
            panel1 = new Panel();
            buttonProveri = new Button();
            buttonDodajAuto1 = new Button();
            tbTelefon = new TextBox();
            tbMotor = new TextBox();
            tbVlasnik = new TextBox();
            tbGorivo = new TextBox();
            tbSasija = new TextBox();
            tbGodiste = new TextBox();
            tbKilometraza = new TextBox();
            tbModel = new TextBox();
            tbRegistracija = new TextBox();
            tbMarka = new TextBox();
            label11 = new Label();
            label6 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(391, 11);
            label1.Name = "label1";
            label1.Size = new Size(413, 28);
            label1.TabIndex = 0;
            label1.Text = "Popunite polja za dodavnje novog vozila";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonProveri);
            panel1.Controls.Add(buttonDodajAuto1);
            panel1.Controls.Add(tbTelefon);
            panel1.Controls.Add(tbMotor);
            panel1.Controls.Add(tbVlasnik);
            panel1.Controls.Add(tbGorivo);
            panel1.Controls.Add(tbSasija);
            panel1.Controls.Add(tbGodiste);
            panel1.Controls.Add(tbKilometraza);
            panel1.Controls.Add(tbModel);
            panel1.Controls.Add(tbRegistracija);
            panel1.Controls.Add(tbMarka);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 439);
            panel1.TabIndex = 1;
            // 
            // buttonProveri
            // 
            buttonProveri.BackColor = Color.Gold;
            buttonProveri.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonProveri.Location = new Point(918, 14);
            buttonProveri.Name = "buttonProveri";
            buttonProveri.Size = new Size(185, 73);
            buttonProveri.TabIndex = 3;
            buttonProveri.Text = "Provera Vozila";
            buttonProveri.UseVisualStyleBackColor = false;
            buttonProveri.Click += buttonProveri_Click;
            // 
            // buttonDodajAuto1
            // 
            buttonDodajAuto1.BackColor = Color.Coral;
            buttonDodajAuto1.FlatAppearance.BorderSize = 0;
            buttonDodajAuto1.FlatStyle = FlatStyle.Flat;
            buttonDodajAuto1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDodajAuto1.Location = new Point(918, 127);
            buttonDodajAuto1.Name = "buttonDodajAuto1";
            buttonDodajAuto1.Size = new Size(185, 68);
            buttonDodajAuto1.TabIndex = 2;
            buttonDodajAuto1.Text = "Dodaj Vozilo";
            buttonDodajAuto1.UseVisualStyleBackColor = false;
            buttonDodajAuto1.Click += buttonDodajAuto1_Click;
            // 
            // tbTelefon
            // 
            tbTelefon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbTelefon.Location = new Point(569, 167);
            tbTelefon.Name = "tbTelefon";
            tbTelefon.Size = new Size(333, 28);
            tbTelefon.TabIndex = 1;
            tbTelefon.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMotor
            // 
            tbMotor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbMotor.Location = new Point(122, 166);
            tbMotor.Name = "tbMotor";
            tbMotor.Size = new Size(333, 28);
            tbMotor.TabIndex = 1;
            tbMotor.TextAlign = HorizontalAlignment.Center;
            // 
            // tbVlasnik
            // 
            tbVlasnik.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbVlasnik.Location = new Point(569, 128);
            tbVlasnik.Name = "tbVlasnik";
            tbVlasnik.Size = new Size(333, 28);
            tbVlasnik.TabIndex = 1;
            tbVlasnik.TextAlign = HorizontalAlignment.Center;
            // 
            // tbGorivo
            // 
            tbGorivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbGorivo.Location = new Point(122, 127);
            tbGorivo.Name = "tbGorivo";
            tbGorivo.Size = new Size(333, 28);
            tbGorivo.TabIndex = 1;
            tbGorivo.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSasija
            // 
            tbSasija.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbSasija.Location = new Point(569, 89);
            tbSasija.Name = "tbSasija";
            tbSasija.Size = new Size(333, 28);
            tbSasija.TabIndex = 1;
            tbSasija.TextAlign = HorizontalAlignment.Center;
            // 
            // tbGodiste
            // 
            tbGodiste.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbGodiste.Location = new Point(122, 89);
            tbGodiste.Name = "tbGodiste";
            tbGodiste.Size = new Size(333, 28);
            tbGodiste.TabIndex = 1;
            tbGodiste.TextAlign = HorizontalAlignment.Center;
            // 
            // tbKilometraza
            // 
            tbKilometraza.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbKilometraza.Location = new Point(569, 50);
            tbKilometraza.Name = "tbKilometraza";
            tbKilometraza.Size = new Size(333, 28);
            tbKilometraza.TabIndex = 1;
            tbKilometraza.TextAlign = HorizontalAlignment.Center;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbModel.Location = new Point(122, 50);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(333, 28);
            tbModel.TabIndex = 1;
            tbModel.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRegistracija
            // 
            tbRegistracija.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbRegistracija.Location = new Point(569, 11);
            tbRegistracija.Name = "tbRegistracija";
            tbRegistracija.Size = new Size(333, 28);
            tbRegistracija.TabIndex = 1;
            tbRegistracija.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMarka
            // 
            tbMarka.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tbMarka.Location = new Point(122, 11);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(333, 28);
            tbMarka.TabIndex = 1;
            tbMarka.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(473, 174);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 0;
            label11.Text = "Telefon : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(20, 173);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 0;
            label6.Text = "Motor : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(469, 137);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 0;
            label10.Text = "Ime Vlasnika : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(20, 134);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Gorivo : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(473, 96);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 0;
            label9.Text = "Br.Sasije : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(20, 96);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 0;
            label4.Text = "Godiste ; ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(473, 57);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 0;
            label8.Text = "Kilometraza : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(20, 57);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Model : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(473, 18);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 0;
            label7.Text = "Registracija : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(20, 18);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Marka : ";
            // 
            // dodajAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "dodajAuto";
            Size = new Size(1156, 598);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox tbTelefon;
        private TextBox tbMotor;
        private TextBox tbVlasnik;
        private TextBox tbGorivo;
        private TextBox tbSasija;
        private TextBox tbGodiste;
        private TextBox tbKilometraza;
        private TextBox tbModel;
        private TextBox tbRegistracija;
        private TextBox tbMarka;
        private Label label11;
        private Label label6;
        private Label label10;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label3;
        private Label label7;
        private Label label2;
        private Button buttonDodajAuto1;
        private Button buttonProveri;
    }
}
