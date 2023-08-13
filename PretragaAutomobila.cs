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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Auto_Servis
{
    public partial class PretragaAutomobila : UserControl
    {
        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = Jurisevic.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        private object baseFont;

        public object DEFAULT_FONTSIZE { get; private set; }

        public PretragaAutomobila()
        {
            InitializeComponent();
            panelRezPretrage.Hide();
            panelServisInfo.Hide();
        }

        private void buttonPretragaVozila_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPretraga.Text))
            {
                MessageBox.Show("Niste uneli parametar za pretragu !");
            }
            else
            {
                string searchQuery = "SELECT * FROM vozila WHERE registracija = '" + tbPretraga.Text + "' OR vlasnik = '" + tbPretraga.Text + "' OR sasija = '" + tbPretraga.Text + "' ";
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(searchQuery, conn);
                    reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        tbId1.Text = Convert.ToString((int)reader.GetInt32(0));
                        tbMarka1.Text = reader.GetString(1);
                        tbModel1.Text = reader.GetString(2);
                        tbGodiste1.Text = Convert.ToString((int)reader.GetInt32(3));
                        tbGorivo1.Text = reader.GetString(4);
                        tbMotor1.Text = reader.GetString(5);
                        tbRegistracija1.Text = reader.GetString(6);
                        tbKilometraza1.Text = Convert.ToString((int)reader.GetInt32(7));
                        tbSasija1.Text = reader.GetString(8);
                        tbVlasnik1.Text = reader.GetString(9);
                        tbTelefon1.Text = reader.GetString(10);
                        panelRezPretrage.Show();
                        panelServisInfo.Hide();
                        reader.Close();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vozilo nije pronadjeno !");
                        tbPretraga.Clear();
                        conn.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                }

            }

        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMarka1.Text) ||
                String.IsNullOrEmpty(tbModel1.Text) ||
                String.IsNullOrEmpty(tbGodiste1.Text) ||
                String.IsNullOrEmpty(tbGorivo1.Text) ||
                String.IsNullOrEmpty(tbMotor1.Text) ||
                String.IsNullOrEmpty(tbRegistracija1.Text) ||
                String.IsNullOrEmpty(tbKilometraza1.Text) ||
                String.IsNullOrEmpty(tbSasija1.Text) ||
                String.IsNullOrEmpty(tbVlasnik1.Text) ||
                String.IsNullOrEmpty(tbTelefon1.Text))
            {
                MessageBox.Show("Polja za unos podataka moraju biti popunjena !");
            }
            else if (tbSasija1.Text.Length != 17)
            {
                MessageBox.Show("Polje za unos broja sasije mora sadrzati 17 karaktera !");
            }
            else
            {
                string updateQuery = "UPDATE vozila SET marka = '" + tbMarka1.Text + "'," +
                                                       "model = '" + tbModel1.Text + "'," +
                                                       "godiste = '" + tbGodiste1.Text + "'," +
                                                       "gorivo = '" + tbGorivo1.Text + "'," +
                                                       "motor = '" + tbMotor1.Text + "'," +
                                                       "registracija = '" + tbRegistracija1.Text + "'," +
                                                       "kilometraza = '" + tbKilometraza1.Text + "'," +
                                                       "sasija = '" + tbSasija1.Text + "'," +
                                                       "vlasnik = '" + tbVlasnik1.Text + "'," +
                                                       "telefon = '" + tbTelefon1.Text + "'" +
                                                       " WHERE id = '" + tbId1.Text + "'";
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(updateQuery, conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Uspesni ste promenili podatke za vozilo sa registarskom oznakom '" + tbRegistracija1.Text + "'");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                }
            }
        }

        private void buttonServisInfo_Click(object sender, EventArgs e)
        {
            string dataQuery = "SELECT * FROM servis WHERE idVozila = '" + tbId1.Text + "'";
            try
            {
                conn.Open();
                com = new SQLiteCommand(dataQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgServisInfo.DataSource = dt;

                dgServisInfo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgServisInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgServisInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgServisInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgServisInfo.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 15.5F, GraphicsUnit.Pixel);


                dgServisInfo.Columns[0].Width = 50;
                dgServisInfo.Columns[1].Width = 70;
                dgServisInfo.Columns[2].Width = 455;
                dgServisInfo.Columns[3].Width = 110;
                dgServisInfo.Columns[4].Width = 110;
                dgServisInfo.Columns[4].DefaultCellStyle.Format = "N2";
                conn.Close();


                panelServisInfo.Show();
                dgServisInfo.Show();
                buttonDodajServis.Show();
                tbDodajServis.Hide();
                buttonSacuvajServis.Hide();
                buttonServisPdf.Hide();
                tbCena.Hide();
                labelCena.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }

        }

        private void buttonDodajServis_Click(object sender, EventArgs e)
        {
            tbDodajServis.Show();
            buttonSacuvajServis.Show();
            buttonServisPdf.Show();
            dgServisInfo.Hide();
            buttonDodajServis.Hide();
            labelCena.Show();
            tbCena.Show();
        }

        private void buttonSacuvajServis_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDodajServis.Text) || String.IsNullOrEmpty(tbCena.Text))
            {
                MessageBox.Show("Polja za servisne informacije ili cenu nisu popunjena !");
            }
            else
            {
                string datum = DateTime.Now.ToString("MM/dd/yyyy");
                string insertServiceQuery = "INSERT INTO servis (idVozila,servisInfo,datum,cena)" +
                    " VALUES ('" + tbId1.Text + "','" + tbDodajServis.Text + "','" + datum + "','" + tbCena.Text + "')";

                try
                {
                    conn.Open();
                    com = new SQLiteCommand(insertServiceQuery, conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste dodali servis za vozilo sa registarkom oznakom '" + tbRegistracija1.Text + "'");
                    conn.Close();
                    //tbDodajServis.Clear();
                    //tbCena.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                }
            }




            
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM vozila WHERE id='" + tbId1.Text + "'";
            string deleteQuery1 = "DELETE FROM servis WHERE idVozila = '" + tbId1.Text + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(deleteQuery, conn);
                com.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SQLiteCommand com1 = new SQLiteCommand(deleteQuery1, conn);
                com1.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste izbrisali sve podatke o servise o vozilu sa registracijom '" + tbRegistracija1.Text + "'");
                conn.Close();
                tbMarka1.Clear();
                tbModel1.Clear();
                tbGodiste1.Clear();
                tbGorivo1.Clear();
                tbMotor1.Clear();
                tbRegistracija1.Clear();
                tbKilometraza1.Clear();
                tbSasija1.Clear();
                tbVlasnik1.Clear();
                tbTelefon1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }
        }

        private void buttonServisPdf_Click(object sender, EventArgs e)
        {

            /* SaveFileDialog sf = new SaveFileDialog();
             sf.Filter = "PDF (*.pdf)|*.pdf";
             sf.FileName = "Izvestaj o servisu '" + tbRegistracija1.Text + "'.pdf";
             Random rnd = new Random();

             var datum = DateTime.Now.ToString("dd/MM/yyyy");
             var docName = tbRegistracija1.Text.ToString();
             Document doc = new Document();
             for (int i = 0; i < 1; i++)
             {
                 var broj = rnd.Next();
                 PdfWriter.GetInstance(doc, new FileStream("C:/PDF/'" + broj + "''" + docName + "'.pdf", FileMode.Create));


                 // PdfWriter.GetInstance(doc, new FileStream("C:/PDF/'"+broj+"''"+docName+"'.pdf", FileMode.Create));
                 doc.Open();

                 //Dodavanje slike u dokument
                 System.Drawing.Image pImage = System.Drawing.Image.FromFile("C:/images/Atyourservice-Service-Categories-Car-Repair.512.png");
                 iTextSharp.text.Image itextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Png);
                 itextImage.Alignment = Element.ALIGN_CENTER;
                 itextImage.ScaleAbsolute(200f, 100f);




                 System.Drawing.Image pImage2 = System.Drawing.Image.FromFile("C:/images/Auto Servis Jurišević.png");
                 iTextSharp.text.Image itextImage2 = iTextSharp.text.Image.GetInstance(pImage2, System.Drawing.Imaging.ImageFormat.Png);
                 itextImage2.Alignment = Element.ALIGN_CENTER;
                 itextImage2.ScaleAbsolute(300, 100);

                 doc.Add(itextImage);
                 doc.Add(itextImage2);

                 //Podesavanje fontova za paragrafe
                 iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);


                 //Dodavanje sadrzaja u paragrafe


                 Paragraph p1 = new Paragraph("Izveštaj servisa za vozilo : '" + tbRegistracija1.Text + "'", f1);
                 Paragraph p2 = new Paragraph("Datum izveštaja : " + datum);
                 Paragraph p3 = new Paragraph(tbDodajServis.Text);
                 var ukupno = Convert.ToDouble(tbCena.Text);
                 Paragraph pLine = new Paragraph("_________________________________________________________________");
                 Paragraph p4 = new Paragraph("UKUPNO : " + ukupno.ToString("N") + " / RSD");
                 Paragraph p5 = new Paragraph("Dokument izdao : _____________________________");



                 //Podesavanje pozicija i izgleda paragrafa u dokumentu
                 p1.Alignment = Element.ALIGN_CENTER;
                 p2.Alignment = Element.ALIGN_CENTER;
                 p3.Alignment = Element.ALIGN_CENTER;
                 p3.SpacingAfter = 20;
                 pLine.Alignment = Element.ALIGN_CENTER;
                 //pLine.PaddingTop = 50;
                 pLine.SpacingBefore = 20;
                 pLine.SpacingAfter = 50;
                 p4.Alignment = Element.ALIGN_CENTER;
                 p5.Alignment = Element.ALIGN_CENTER;
                 p5.SpacingBefore = 30;



                 //Dodavanje paragrafa u dokument

                doc.Add(p1);
                 doc.Add(p2);
                 doc.Add(pLine);
                 doc.Add(p3);
                 doc.Add(pLine);
                 doc.Add(p4);
                 doc.Add(p5);

                 doc.Close();
                 MessageBox.Show("Uspesno ste kreirali PDF dokument");

                 using (FileStream stream1 = new FileStream(sf.FileName, FileMode.Create))
                 {
                     iTextSharp.text.Document doc1 = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                     PdfWriter.GetInstance(doc1, stream1);
                    // doc.Open();
                     doc.Add(p1);
                     doc.Add(p2);
                     doc.Add(pLine);
                     doc.Add(p3);
                     doc.Add(pLine);
                     doc.Add(p4);
                     doc.Add(p5);
                     doc.Close();
                     stream1.Close();

                 }

                 MessageBox.Show("Uspesno ste kreirali PDF dokument");

             }*/

            //Novi kod za kreiranje PDF fajla 
            if (String.IsNullOrEmpty(tbDodajServis.Text))
            {
                MessageBox.Show("Niste uneli podatke o servisu !");
            }
            else if (String.IsNullOrEmpty(tbCena.Text))
            {
                MessageBox.Show("Niste uneli cenu servisa !");
            }
            else
            {
                string registracija = tbRegistracija1.Text.ToString();
                string datumRacuna = Convert.ToString(DateTime.Now);
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";
                sf.FileName = "Izvod servisa za vozilo " + registracija;
                bool fileError = false;

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sf.FileName))
                    {
                        try
                        {
                            File.Delete(sf.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("GRESKA : " + ex.Message);
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        //Podesavanje fontova za paragrafe
                        iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);


                        //Dodavanje slike u dokument
                        System.Drawing.Image pImage = System.Drawing.Image.FromFile("C:/images/Atyourservice-Service-Categories-Car-Repair.512.png");
                        iTextSharp.text.Image itextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Png);
                        itextImage.Alignment = Element.ALIGN_CENTER;
                        itextImage.ScaleAbsolute(200f, 100f);




                        System.Drawing.Image pImage2 = System.Drawing.Image.FromFile("C:/images/Auto Servis Jurišević.png");
                        iTextSharp.text.Image itextImage2 = iTextSharp.text.Image.GetInstance(pImage2, System.Drawing.Imaging.ImageFormat.Png);
                        itextImage2.Alignment = Element.ALIGN_CENTER;
                        itextImage2.ScaleAbsolute(300, 100);

                        string datum = DateTime.Now.ToString("dd/MM/yyyy");

                        //Kreiranje paragrafa
                        Paragraph p1 = new Paragraph("Izvestaj servisa za vozilo : " + tbRegistracija1.Text, f1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        p1.SpacingBefore = 5;


                        Paragraph p2 = new Paragraph(tbDodajServis.Text);
                        p2.Alignment = Element.ALIGN_CENTER;
                        p2.SpacingBefore = 20;

                        Paragraph p3 = new Paragraph("Izvestaj izdao : ______________________________");
                        p3.Alignment = Element.ALIGN_CENTER;
                        p3.SpacingBefore = 30;

                        Paragraph p4 = new Paragraph("Datum : " + datum);
                        p4.Alignment = Element.ALIGN_CENTER;
                        p4.SpacingBefore = 20;

                        using (FileStream fs = new FileStream(sf.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(doc, fs);

                            doc.Open();
                            doc.Add(itextImage);
                            doc.Add(itextImage2);
                            doc.Add(p1);
                            doc.Add(p2);
                            doc.Add(p3);
                            doc.Add(p4);
                            doc.Close();
                            fs.Close();
                        }

                        MessageBox.Show("Uspesno ste kreirali PDF dokument !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("GRESKA : " + ex);
                    }
                }
            }
        }
    }
}
