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
    public partial class SviServisiForm : Form
    {
        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = Jurisevic.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        public SviServisiForm()
        {
            InitializeComponent();
        }

        private void SviServisiForm_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM servis";

            try
            {
                conn.Open();
                com = new SQLiteCommand(selectQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgSviServisi.DataSource = dt;

                dgSviServisi.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSviServisi.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSviServisi.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSviServisi.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgSviServisi.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgSviServisi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgSviServisi.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgSviServisi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgSviServisi.Columns[0].Width = 50;
                dgSviServisi.Columns[1].Width = 60;
                dgSviServisi.Columns[2].Width = 755;
                dgSviServisi.Columns[3].Width = 120;
                dgSviServisi.Columns[4].Width = 120;
                dgSviServisi.Columns[4].DefaultCellStyle.Format = "N2";



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
