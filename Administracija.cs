using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto_Servis
{
    public partial class Administracija : UserControl
    {

        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = Jurisevic.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        public Administracija()
        {
            InitializeComponent();
            panelPoDatumu.Hide();
        }

        private void buttonSvaVozila_Click(object sender, EventArgs e)
        {
            SvaVozilaForm svaVozila = new SvaVozilaForm();
            svaVozila.Show();
        }

        private void buttonSviServisi_Click(object sender, EventArgs e)
        {
            SviServisiForm sviServisi = new SviServisiForm();
            sviServisi.Show();
        }

        private void Administracija_Load(object sender, EventArgs e)
        {

        }

        private void buttonPretragaPoDatumu_Click(object sender, EventArgs e)
        {
            string datum = dtDatum.Value.Date.ToString("MM/dd/yyyy");
            string byDateQuery = "SELECT * FROM servis WHERE datum='" + datum + "'";
            string cenaPodatumu = "SELECT SUM(cena) FROM servis WHERE datum='" + datum + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(byDateQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgPoDatumu.DataSource = dt;

                dgPoDatumu.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgPoDatumu.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgPoDatumu.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgPoDatumu.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgPoDatumu.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgPoDatumu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgPoDatumu.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgPoDatumu.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgPoDatumu.Columns[0].Width = 50;
                dgPoDatumu.Columns[1].Width = 60;
                dgPoDatumu.Columns[2].Width = 580;
                dgPoDatumu.Columns[3].Width = 120;
                dgPoDatumu.Columns[4].Width = 120;
                dgPoDatumu.Columns[4].DefaultCellStyle.Format = "N2";

                conn.Close();
                reader.Close();

                int sum = 0;
                for (int i = 0; i < dgPoDatumu.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgPoDatumu.Rows[i].Cells[4].Value);
                }
                labDatum.Text = sum.ToString("N");

                panelPoDatumu.Show();
                dgPoDatumu.Show();
                buttonToPDF.Show();
                buttonToPDF1.Hide();
                labelDatum.Show();
                labelInterval.Hide();
                dgInterval.Hide();
                labDatum.Show();
                labInterval.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }


        }

        private void buttonPretragaPoIntervalu_Click(object sender, EventArgs e)
        {

            string datum1 = dtOdDatuma.Value.Date.ToString("MM/dd/yyyy");
            string datum2 = dtDoDatuma.Value.Date.ToString("MM/dd/yyyy");
            string byDateQuery = "SELECT * FROM servis WHERE datum>='" + datum1 + "' AND datum <='" + datum2 + "'";
            string byDateCena = "SELECT SUM(cena) FROM servis WHERE datum BETWEEN '" + datum1 + "' AND '" + datum2 + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(byDateQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgInterval.DataSource = dt;

                dgInterval.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgInterval.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgInterval.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgInterval.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgInterval.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgInterval.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgInterval.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgInterval.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgInterval.Columns[0].Width = 50;
                dgInterval.Columns[1].Width = 60;
                dgInterval.Columns[2].Width = 580;
                dgInterval.Columns[3].Width = 120;
                dgInterval.Columns[4].Width = 120;
                dgInterval.Columns[4].DefaultCellStyle.Format = "N2";



                conn.Close();
                reader.Close();

                int sum = 0;
                for (int i = 0; i < dgInterval.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgInterval.Rows[i].Cells[4].Value);
                }
                labInterval.Text = sum.ToString("N");

                panelPoDatumu.Show();
                labelDatum.Hide();
                labelInterval.Show();
                buttonToPDF.Hide();
                buttonToPDF1.Show();
                dgPoDatumu.Hide();
                dgInterval.Show();
                labDatum.Hide();
                labInterval.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUkupnoDatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonToPDF_Click(object sender, EventArgs e)
        {
            if (dgPoDatumu.Rows.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";


                string nazivDnevnogIzvestaja = "Izvestaj za datum - ";
                string datumDnevnogIzvestaja = dtDatum.Value.ToString("dd.MM.yyyy");
                sf.FileName = nazivDnevnogIzvestaja + datumDnevnogIzvestaja;
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
                            MessageBox.Show("GRESKA : " + ex);
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


                        string datum = dtDatum.Value.ToString("dd/MM/yyyy");

                        //Dodavanje paragrafa za dokument
                        Paragraph p1 = new Paragraph("Izvestaj servisa za dan - " + datum, f1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        p1.SpacingAfter = 30;


                        Paragraph p2 = new Paragraph("    ID       ID Vozila                             Informacije o servisu                                    Datum                Cena");
                        p2.Alignment = Element.ALIGN_LEFT;
                        p2.SpacingAfter = 15;


                        string datumizvestaja1 = DateTime.Now.ToString("dd/MM/yyyy");
                        Paragraph p3 = new Paragraph("Datum izvestaja : " + datumizvestaja1);
                        p3.Alignment = Element.ALIGN_CENTER;
                        p3.SpacingBefore = 5;




                        PdfPTable pdftable1 = new PdfPTable(dgPoDatumu.Columns.Count);
                        pdftable1.DefaultCell.Padding = 3;
                        pdftable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdftable1.TotalWidth = 570f;
                        pdftable1.LockedWidth = true;
                        float[] widths = new float[] { 50f, 50f, 310f, 80f, 80f };
                        pdftable1.SetWidths(widths);
                        pdftable1.HorizontalAlignment = Element.ALIGN_CENTER;

                        foreach (DataGridViewRow row in dgPoDatumu.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {

                                pdftable1.AddCell(Convert.ToString(cell.Value));
                            }
                        }

                        int sum = 0;
                        for (int i = 0; i < dgPoDatumu.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(dgPoDatumu.Rows[i].Cells[4].Value);
                        }
                        labDatum.Text = sum.ToString("N");


                        Paragraph p4 = new Paragraph("UKUPNO : " + labDatum.Text);
                        p4.Alignment = Element.ALIGN_RIGHT;
                        p4.SpacingBefore = 10;
                        p4.SpacingAfter = 10;

                        using (FileStream stream1 = new FileStream(sf.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(doc, stream1);
                            doc.Open();
                            doc.Add(itextImage);
                            doc.Add(itextImage2);
                            doc.Add(p1);
                            doc.Add(p2);
                            doc.Add(pdftable1);
                            doc.Add(p4);
                            doc.Add(p3);
                            doc.Close();
                            stream1.Close();

                        }

                        MessageBox.Show("Uspesno ste kreirali PDF dokument");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("GRESKA : " + ex);
                    }
                }
            }
        }

        private void buttonToPDF1_Click(object sender, EventArgs e)
        {

            if (dgInterval.Rows.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";
                string periodicniIzvestaj = "Periodicni izvestaj od - ";
                string datumOd = dtOdDatuma.Value.ToString("dd.MM.yyyy");
                string datumDo = dtDoDatuma.Value.ToString("dd.MM.yyyy");
                sf.FileName = periodicniIzvestaj + datumOd + " do " + datumDo;
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
                            MessageBox.Show("GRESKA : " + ex);
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


                        string datum = dtDatum.Value.ToString("dd/MM/yyyy");

                        string datum1 = dtOdDatuma.Value.Date.ToString("MM/dd/yyyy");
                        string datum2 = dtDoDatuma.Value.Date.ToString("MM/dd/yyyy");

                        //Dodavanje paragrafa za dokument
                        Paragraph p1 = new Paragraph("Izvestaj servisa za period od " + datum1 + " do " + datum2, f1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        p1.SpacingAfter = 30;


                        Paragraph p2 = new Paragraph("    ID       ID Vozila                             Informacije o servisu                                    Datum                Cena");
                        p2.Alignment = Element.ALIGN_LEFT;
                        p2.SpacingAfter = 15;


                        string datumizvestaja1 = DateTime.Now.ToString("dd/MM/yyyy");
                        Paragraph p3 = new Paragraph("Datum izvestaja : " + datumizvestaja1);
                        p3.Alignment = Element.ALIGN_CENTER;
                        p3.SpacingBefore = 5;




                        PdfPTable pdftable1 = new PdfPTable(dgInterval.Columns.Count);
                        pdftable1.DefaultCell.Padding = 3;
                        pdftable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdftable1.TotalWidth = 570f;
                        pdftable1.LockedWidth = true;
                        float[] widths = new float[] { 50f, 50f, 310f, 80f, 80f };
                        pdftable1.SetWidths(widths);
                        pdftable1.HorizontalAlignment = Element.ALIGN_CENTER;

                        foreach (DataGridViewRow row in dgInterval.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {

                                pdftable1.AddCell(Convert.ToString(cell.Value));
                            }
                        }

                        int sum = 0;
                        for (int i = 0; i < dgInterval.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(dgInterval.Rows[i].Cells[4].Value);
                        }
                        labDatum.Text = sum.ToString("N");


                        Paragraph p4 = new Paragraph("UKUPNO : " + labDatum.Text);
                        p4.Alignment = Element.ALIGN_RIGHT;
                        p4.SpacingBefore = 10;
                        p4.SpacingAfter = 10;

                        using (FileStream stream1 = new FileStream(sf.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(doc, stream1);
                            doc.Open();
                            doc.Add(itextImage);
                            doc.Add(itextImage2);
                            doc.Add(p1);
                            doc.Add(p2);
                            doc.Add(pdftable1);
                            doc.Add(p4);
                            doc.Add(p3);
                            doc.Close();
                            stream1.Close();

                        }

                        MessageBox.Show("Uspesno ste kreirali PDF dokument");

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
