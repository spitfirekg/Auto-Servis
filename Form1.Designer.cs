namespace Auto_Servis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            buttonAdmin = new Button();
            buttonPretraziAuto = new Button();
            buttonDodajAuto = new Button();
            buttonPocetna = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dodajAuto1 = new dodajAuto();
            pretragaAutomobila1 = new PretragaAutomobila();
            administracija1 = new Administracija();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(buttonAdmin);
            panel1.Controls.Add(buttonPretraziAuto);
            panel1.Controls.Add(buttonDodajAuto);
            panel1.Controls.Add(buttonPocetna);
            panel1.Location = new Point(6, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 602);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 151);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.LightSalmon;
            buttonAdmin.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdmin.ForeColor = Color.Black;
            buttonAdmin.Location = new Point(6, 496);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(146, 103);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Administracija";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonPretraziAuto
            // 
            buttonPretraziAuto.BackColor = Color.Gold;
            buttonPretraziAuto.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPretraziAuto.ForeColor = Color.Black;
            buttonPretraziAuto.Location = new Point(6, 387);
            buttonPretraziAuto.Name = "buttonPretraziAuto";
            buttonPretraziAuto.Size = new Size(146, 103);
            buttonPretraziAuto.TabIndex = 0;
            buttonPretraziAuto.Text = "Pretraga";
            buttonPretraziAuto.UseVisualStyleBackColor = false;
            buttonPretraziAuto.Click += buttonPretraziAuto_Click;
            // 
            // buttonDodajAuto
            // 
            buttonDodajAuto.BackColor = Color.DeepSkyBlue;
            buttonDodajAuto.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDodajAuto.ForeColor = Color.Black;
            buttonDodajAuto.Location = new Point(6, 278);
            buttonDodajAuto.Name = "buttonDodajAuto";
            buttonDodajAuto.Size = new Size(146, 103);
            buttonDodajAuto.TabIndex = 0;
            buttonDodajAuto.Text = "Dodaj Auto";
            buttonDodajAuto.UseVisualStyleBackColor = false;
            buttonDodajAuto.Click += buttonDodajAuto_Click;
            // 
            // buttonPocetna
            // 
            buttonPocetna.BackColor = Color.Turquoise;
            buttonPocetna.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPocetna.ForeColor = Color.Black;
            buttonPocetna.Location = new Point(6, 169);
            buttonPocetna.Name = "buttonPocetna";
            buttonPocetna.Size = new Size(146, 103);
            buttonPocetna.TabIndex = 0;
            buttonPocetna.Text = "HOME";
            buttonPocetna.UseVisualStyleBackColor = false;
            buttonPocetna.Click += buttonPocetna_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(756, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(176, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1160, 602);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dodajAuto1
            // 
            dodajAuto1.BackColor = Color.DeepSkyBlue;
            dodajAuto1.ForeColor = Color.Black;
            dodajAuto1.Location = new Point(176, 107);
            dodajAuto1.Name = "dodajAuto1";
            dodajAuto1.Size = new Size(1160, 602);
            dodajAuto1.TabIndex = 3;
            // 
            // pretragaAutomobila1
            // 
            pretragaAutomobila1.BackColor = Color.Gold;
            pretragaAutomobila1.ForeColor = Color.Black;
            pretragaAutomobila1.Location = new Point(176, 107);
            pretragaAutomobila1.Name = "pretragaAutomobila1";
            pretragaAutomobila1.Size = new Size(1160, 602);
            pretragaAutomobila1.TabIndex = 4;
            // 
            // administracija1
            // 
            administracija1.BackColor = Color.LightSalmon;
            administracija1.ForeColor = Color.Black;
            administracija1.Location = new Point(176, 104);
            administracija1.Name = "administracija1";
            administracija1.Size = new Size(1160, 602);
            administracija1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1348, 721);
            Controls.Add(administracija1);
            Controls.Add(pretragaAutomobila1);
            Controls.Add(dodajAuto1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = Color.PaleTurquoise;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto servis Jurišević";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonAdmin;
        private Button buttonPretraziAuto;
        private Button buttonDodajAuto;
        private Button buttonPocetna;
        private dodajAuto dodajAuto1;
        private PretragaAutomobila pretragaAutomobila1;
        private Administracija administracija1;
    }
}