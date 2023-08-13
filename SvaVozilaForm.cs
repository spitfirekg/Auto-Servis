using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Servis
{
    public partial class SvaVozilaForm : Form
    {

        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = Jurisevic.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        public SvaVozilaForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SvaVozilaForm_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM vozila";

            try
            {
                conn.Open();
                com = new SQLiteCommand(selectQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgSvaVozila.DataSource = dt;

                dgSvaVozila.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSvaVozila.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgSvaVozila.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgSvaVozila.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgSvaVozila.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgSvaVozila.Columns[0].Width = 50;
                dgSvaVozila.Columns[1].Width = 100;
                dgSvaVozila.Columns[2].Width = 100;
                dgSvaVozila.Columns[3].Width = 60;
                dgSvaVozila.Columns[4].Width = 70;
                dgSvaVozila.Columns[5].Width = 70;
                dgSvaVozila.Columns[6].Width = 100;
                dgSvaVozila.Columns[7].Width = 100;
                dgSvaVozila.Columns[8].Width = 160;
                dgSvaVozila.Columns[9].Width = 180;
                dgSvaVozila.Columns[10].Width = 115;


                conn.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }
        }
    }
}
