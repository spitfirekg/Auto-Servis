namespace Auto_Servis
{
    partial class SviServisiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SviServisiForm));
            dgSviServisi = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSviServisi).BeginInit();
            SuspendLayout();
            // 
            // dgSviServisi
            // 
            dgSviServisi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgSviServisi.BackgroundColor = Color.White;
            dgSviServisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSviServisi.Location = new Point(12, 40);
            dgSviServisi.Name = "dgSviServisi";
            dgSviServisi.RowHeadersWidth = 51;
            dgSviServisi.RowTemplate.Height = 29;
            dgSviServisi.Size = new Size(1158, 701);
            dgSviServisi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista svih servisa";
            // 
            // SviServisiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 753);
            Controls.Add(label1);
            Controls.Add(dgSviServisi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SviServisiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SviServisiForm";
            Load += SviServisiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgSviServisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSviServisi;
        private Label label1;
    }
}