namespace Auto_Servis
{
    partial class Administracija
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
            buttonSvaVozila = new Button();
            buttonSviServisi = new Button();
            label2 = new Label();
            dtDatum = new DateTimePicker();
            label3 = new Label();
            dtOdDatuma = new DateTimePicker();
            dtDoDatuma = new DateTimePicker();
            label4 = new Label();
            buttonPretragaPoDatumu = new Button();
            buttonPretragaPoIntervalu = new Button();
            panelPoDatumu = new Panel();
            label5 = new Label();
            labInterval = new Label();
            labDatum = new Label();
            buttonToPDF1 = new Button();
            dgInterval = new DataGridView();
            labelInterval = new Label();
            buttonToPDF = new Button();
            labelDatum = new Label();
            dgPoDatumu = new DataGridView();
            panelPoDatumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPoDatumu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(500, 11);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 1;
            label1.Text = "Administracija";
            label1.Click += label1_Click;
            // 
            // buttonSvaVozila
            // 
            buttonSvaVozila.BackColor = Color.LightSkyBlue;
            buttonSvaVozila.FlatAppearance.BorderSize = 0;
            buttonSvaVozila.FlatStyle = FlatStyle.Flat;
            buttonSvaVozila.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSvaVozila.Location = new Point(18, 53);
            buttonSvaVozila.Name = "buttonSvaVozila";
            buttonSvaVozila.Size = new Size(243, 35);
            buttonSvaVozila.TabIndex = 2;
            buttonSvaVozila.Text = "Lista Svih Vozila";
            buttonSvaVozila.UseVisualStyleBackColor = false;
            buttonSvaVozila.Click += buttonSvaVozila_Click;
            // 
            // buttonSviServisi
            // 
            buttonSviServisi.BackColor = Color.MediumSpringGreen;
            buttonSviServisi.FlatAppearance.BorderSize = 0;
            buttonSviServisi.FlatStyle = FlatStyle.Flat;
            buttonSviServisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSviServisi.Location = new Point(287, 53);
            buttonSviServisi.Name = "buttonSviServisi";
            buttonSviServisi.Size = new Size(243, 35);
            buttonSviServisi.TabIndex = 2;
            buttonSviServisi.Text = "Lista svih servisa";
            buttonSviServisi.UseVisualStyleBackColor = false;
            buttonSviServisi.Click += buttonSviServisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(18, 105);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 3;
            label2.Text = "Lista servisa po datumu : ";
            // 
            // dtDatum
            // 
            dtDatum.CustomFormat = "";
            dtDatum.DropDownAlign = LeftRightAlignment.Right;
            dtDatum.Format = DateTimePickerFormat.Short;
            dtDatum.Location = new Point(216, 98);
            dtDatum.Name = "dtDatum";
            dtDatum.Size = new Size(140, 27);
            dtDatum.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(18, 140);
            label3.Name = "label3";
            label3.Size = new Size(366, 20);
            label3.TabIndex = 3;
            label3.Text = "Lista servisa u mesecnom intervalu- OD DATUMA \r\n";
            // 
            // dtOdDatuma
            // 
            dtOdDatuma.Format = DateTimePickerFormat.Short;
            dtOdDatuma.Location = new Point(396, 133);
            dtOdDatuma.Name = "dtOdDatuma";
            dtOdDatuma.Size = new Size(134, 27);
            dtOdDatuma.TabIndex = 5;
            // 
            // dtDoDatuma
            // 
            dtDoDatuma.Format = DateTimePickerFormat.Short;
            dtDoDatuma.Location = new Point(657, 131);
            dtDoDatuma.Name = "dtDoDatuma";
            dtDoDatuma.Size = new Size(128, 27);
            dtDoDatuma.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(546, 138);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "DO DATUMA ";
            // 
            // buttonPretragaPoDatumu
            // 
            buttonPretragaPoDatumu.Location = new Point(367, 96);
            buttonPretragaPoDatumu.Name = "buttonPretragaPoDatumu";
            buttonPretragaPoDatumu.Size = new Size(163, 29);
            buttonPretragaPoDatumu.TabIndex = 6;
            buttonPretragaPoDatumu.Text = "Pretraga";
            buttonPretragaPoDatumu.UseVisualStyleBackColor = true;
            buttonPretragaPoDatumu.Click += buttonPretragaPoDatumu_Click;
            // 
            // buttonPretragaPoIntervalu
            // 
            buttonPretragaPoIntervalu.Location = new Point(807, 129);
            buttonPretragaPoIntervalu.Name = "buttonPretragaPoIntervalu";
            buttonPretragaPoIntervalu.Size = new Size(163, 29);
            buttonPretragaPoIntervalu.TabIndex = 6;
            buttonPretragaPoIntervalu.Text = "Pretraga";
            buttonPretragaPoIntervalu.UseVisualStyleBackColor = true;
            buttonPretragaPoIntervalu.Click += buttonPretragaPoIntervalu_Click;
            // 
            // panelPoDatumu
            // 
            panelPoDatumu.Controls.Add(label5);
            panelPoDatumu.Controls.Add(labInterval);
            panelPoDatumu.Controls.Add(labDatum);
            panelPoDatumu.Controls.Add(buttonToPDF1);
            panelPoDatumu.Controls.Add(dgInterval);
            panelPoDatumu.Controls.Add(labelInterval);
            panelPoDatumu.Controls.Add(buttonToPDF);
            panelPoDatumu.Controls.Add(labelDatum);
            panelPoDatumu.Controls.Add(dgPoDatumu);
            panelPoDatumu.Location = new Point(18, 174);
            panelPoDatumu.Name = "panelPoDatumu";
            panelPoDatumu.Size = new Size(1135, 421);
            panelPoDatumu.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(998, 203);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 7;
            label5.Text = "Ukupna suma : ";
            // 
            // labInterval
            // 
            labInterval.AutoSize = true;
            labInterval.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labInterval.Location = new Point(994, 238);
            labInterval.Name = "labInterval";
            labInterval.Size = new Size(70, 28);
            labInterval.TabIndex = 6;
            labInterval.Text = "label5";
            // 
            // labDatum
            // 
            labDatum.AutoSize = true;
            labDatum.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labDatum.Location = new Point(994, 238);
            labDatum.Name = "labDatum";
            labDatum.Size = new Size(70, 28);
            labDatum.TabIndex = 6;
            labDatum.Text = "label5";
            // 
            // buttonToPDF1
            // 
            buttonToPDF1.BackColor = Color.Gold;
            buttonToPDF1.FlatAppearance.BorderSize = 0;
            buttonToPDF1.FlatStyle = FlatStyle.Flat;
            buttonToPDF1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonToPDF1.Location = new Point(994, 36);
            buttonToPDF1.Name = "buttonToPDF1";
            buttonToPDF1.Size = new Size(138, 61);
            buttonToPDF1.TabIndex = 5;
            buttonToPDF1.Text = "Izvezi u PDF";
            buttonToPDF1.UseVisualStyleBackColor = false;
            buttonToPDF1.Click += buttonToPDF1_Click;
            // 
            // dgInterval
            // 
            dgInterval.BackgroundColor = Color.White;
            dgInterval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInterval.Location = new Point(3, 36);
            dgInterval.Name = "dgInterval";
            dgInterval.RowHeadersWidth = 51;
            dgInterval.RowTemplate.Height = 29;
            dgInterval.Size = new Size(985, 370);
            dgInterval.TabIndex = 4;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelInterval.Location = new Point(3, 5);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(366, 28);
            labelInterval.TabIndex = 3;
            labelInterval.Text = "Prikaz servisa po izabranom intervalu : ";
            // 
            // buttonToPDF
            // 
            buttonToPDF.BackColor = Color.Orchid;
            buttonToPDF.FlatAppearance.BorderSize = 0;
            buttonToPDF.FlatStyle = FlatStyle.Flat;
            buttonToPDF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonToPDF.Location = new Point(994, 36);
            buttonToPDF.Name = "buttonToPDF";
            buttonToPDF.Size = new Size(138, 61);
            buttonToPDF.TabIndex = 2;
            buttonToPDF.Text = "Izvezi u PDF";
            buttonToPDF.UseVisualStyleBackColor = false;
            buttonToPDF.Click += buttonToPDF_Click;
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDatum.Location = new Point(3, 5);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(355, 28);
            labelDatum.TabIndex = 1;
            labelDatum.Text = "Prikaz servisa po izabranom datumu : ";
            // 
            // dgPoDatumu
            // 
            dgPoDatumu.BackgroundColor = Color.White;
            dgPoDatumu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPoDatumu.Location = new Point(3, 36);
            dgPoDatumu.Name = "dgPoDatumu";
            dgPoDatumu.RowHeadersWidth = 51;
            dgPoDatumu.RowTemplate.Height = 29;
            dgPoDatumu.Size = new Size(985, 370);
            dgPoDatumu.TabIndex = 0;
            // 
            // Administracija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panelPoDatumu);
            Controls.Add(buttonPretragaPoIntervalu);
            Controls.Add(buttonPretragaPoDatumu);
            Controls.Add(dtDoDatuma);
            Controls.Add(dtOdDatuma);
            Controls.Add(dtDatum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSviServisi);
            Controls.Add(buttonSvaVozila);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Administracija";
            Size = new Size(1156, 598);
            Load += Administracija_Load;
            panelPoDatumu.ResumeLayout(false);
            panelPoDatumu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPoDatumu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSvaVozila;
        private Button buttonSviServisi;
        private Label label2;
        private DateTimePicker dtDatum;
        private Label label3;
        private DateTimePicker dtOdDatuma;
        private DateTimePicker dtDoDatuma;
        private Label label4;
        private Button buttonPretragaPoDatumu;
        private Button buttonPretragaPoIntervalu;
        private Panel panelPoDatumu;
        private Label labelDatum;
        private DataGridView dgPoDatumu;
        private Button buttonToPDF;
        private Label labelInterval;
        private Button buttonToPDF1;
        private DataGridView dgInterval;
        private Label labInterval;
        private Label labDatum;
        private Label label5;
    }
}
