using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Servis
{
    public partial class dodajAuto : UserControl

    {

        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = Jurisevic.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        public dodajAuto()
        {
            InitializeComponent();
        }

        private void buttonDodajAuto1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMarka.Text) ||
                String.IsNullOrEmpty(tbModel.Text) ||
                String.IsNullOrEmpty(tbGodiste.Text) ||
                String.IsNullOrEmpty(tbGorivo.Text) ||
                String.IsNullOrEmpty(tbMotor.Text) ||
                String.IsNullOrEmpty(tbRegistracija.Text) ||
                String.IsNullOrEmpty(tbSasija.Text) ||
                String.IsNullOrEmpty(tbKilometraza.Text) ||
                String.IsNullOrEmpty(tbVlasnik.Text) ||
                String.IsNullOrEmpty(tbTelefon.Text))
            {
                MessageBox.Show("Sva polja za unos podataka o vozilu moraju biti popunjena !");
            }
            else if (tbSasija.Text.Length != 17)
            {
                MessageBox.Show("Polje za unos broja sasije mora imati 17 karaktera !");
            }
            else
            {

                string insertQuery = "INSERT INTO vozila (marka,model,godiste,gorivo,motor,registracija,kilometraza,sasija,vlasnik,telefon)" +
                                                             "VALUES ('" + tbMarka.Text + "','" + tbModel.Text + "','" + tbGodiste.Text + "','" + tbGorivo.Text + "'," +
                                                             "'" + tbMotor.Text + "','" + tbRegistracija.Text + "','" + tbKilometraza.Text + "','" + tbSasija.Text + "'," +
                                                             "'" + tbVlasnik.Text + "','" + tbTelefon.Text + "')";
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(insertQuery, conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste dodali vozilo u bazu podataka !");
                    conn.Close();
                    tbMarka.Clear();
                    tbModel.Clear();
                    tbGodiste.Clear();
                    tbGorivo.Clear();
                    tbVlasnik.Clear();
                    tbRegistracija.Clear();
                    tbKilometraza.Clear();
                    tbSasija.Clear();
                    tbVlasnik.Clear();
                    tbTelefon.Clear();
                    tbMotor.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                }


            }
        }

        private void buttonProveri_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbRegistracija.Text))
            {
                MessageBox.Show("Polje za unos registracije je prazno !");
            }
            else
            {
                string checkQuery = "SELECT * FROM vozila WHERE registracija='" + tbRegistracija.Text + "'";
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(checkQuery, conn);
                    reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Vozilo sa registarsom oznakom '" + tbRegistracija.Text + "' vec postoji !");
                        reader.Close();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vozilo sa registarsom oznakom '" + tbRegistracija.Text + "' ne postoji u bazi podataka, sada ga mozete sacuvati klikom na DODAJ VOZILO !");
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                }
            }
        }
    }
}
