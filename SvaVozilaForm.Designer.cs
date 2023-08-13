namespace Auto_Servis
{
    partial class SvaVozilaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvaVozilaForm));
            label1 = new Label();
            dgSvaVozila = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSvaVozila).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista svih vozila";
            // 
            // dgSvaVozila
            // 
            dgSvaVozila.BackgroundColor = Color.White;
            dgSvaVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSvaVozila.Location = new Point(12, 40);
            dgSvaVozila.Name = "dgSvaVozila";
            dgSvaVozila.RowHeadersWidth = 51;
            dgSvaVozila.RowTemplate.Height = 29;
            dgSvaVozila.Size = new Size(1158, 701);
            dgSvaVozila.TabIndex = 1;
            dgSvaVozila.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SvaVozilaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 753);
            Controls.Add(dgSvaVozila);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SvaVozilaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista svih vozila";
            Load += SvaVozilaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgSvaVozila).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgSvaVozila;
    }
}