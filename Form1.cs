using System.Data.SQLite;

namespace Auto_Servis
{
    public partial class Form1 : Form
    {

        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = jurisevic.db");
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Show();
            dodajAuto1.Hide();
            pretragaAutomobila1.Hide();
            administracija1.Hide();


        }

        private void buttonPocetna_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            dodajAuto1.Hide();
            pretragaAutomobila1.Hide();
            administracija1.Hide();
        }

        private void buttonDodajAuto_Click(object sender, EventArgs e)
        {
            dodajAuto1.Show();
            pictureBox2.Hide();
            administracija1.Hide();
            pretragaAutomobila1.Hide();

        }

        private void buttonPretraziAuto_Click(object sender, EventArgs e)
        {
            pretragaAutomobila1.Show();
            pictureBox2.Hide();
            administracija1.Hide() ;
            dodajAuto1.Hide() ;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            administracija1.Show();
            pretragaAutomobila1.Hide();
            dodajAuto1.Hide();
            pictureBox2.Hide();

        }
    }
}