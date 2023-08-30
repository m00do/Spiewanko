using System.Diagnostics;

namespace SpiewnikHarce
{
    public partial class Form1 : Form
    {
        public bool wlonczone;
        public string haslo = "Vernon Roche";
        public string login = "Za temerie";



        public Form1()
        {
            InitializeComponent();
            autoCOmplitWiszukiwania();
            ActivePanel(EkranPowitalny);
            SprawdzDosemp();

            sprawdzanie();

        }


        void autoCOmplitWiszukiwania()
        {

            string[] piosenkiProp = File.ReadAllLines("PiosenkiTytuly.txt");

            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteCustomSource.AddRange(piosenkiProp);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            WyszukiwaniePiosenki();
            czyszczenie(textBox1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuPanelShow();


        }

        private void MainMenuPanelShow()
        {


            if (wlonczone == false)
            {
                panel1.Size = new Size(249, 566);
                panel1.Location = new Point(0, 2);
                panel1.Visible = true;
                wlonczone = true;
                MM.Location = new Point(284, 32);

            }
            else if (wlonczone == true)
            {
                panel1.Size = new Size(0, 0);
                panel1.Location = new Point(0, 2);
                panel1.Visible = false;
                wlonczone = false;
                MM.Location = new Point(70, 32);


            }


        }

        private void DisActivePanel(Panel dezaktywowne)
        {
            dezaktywowne.Visible = false;
            dezaktywowne.Location = new Point(0, 0);
            dezaktywowne.Size = new Size(0, 0);


        }

        private void ActivePanel(Panel aktywowany)
        {
            aktywowany.Visible = true;
            aktywowany.Location = new Point(346, -2);
            aktywowany.Size = new Size(633, 569);

        }

        private void WyszukiwaniePiosenki()
        {
            bool istnienie = File.Exists(textBox1.Text + ".txt");

            if (textBox1.Text == "")
            {
                MessageBox.Show("wpisz tytu³ w wyszukiwarce");

            }
            else if (istnienie == true)
            {
                DisActivePanel(EkranPowitalny);
                DisActivePanel(panel2);
                DisActivePanel(PanelLogowaniaWendroli);
                ActivePanel(PiosenkowyPanel);


                string TekstWPiosenki = File.ReadAllText(textBox1.Text.ToLower() + ".txt");

                richTextBox2.Text = TekstWPiosenki;

                textBox2.Text = textBox1.Text;


            }
            else if (istnienie == false)
            {
                MessageBox.Show("Brak Danej Piosenki :(");

            }


        }

        private void PiosenkowyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            czyszczenie(textBox1);
            czyszczenie(textBox2);
            czyszczonko(richTextBox1);

            if (LoginTextBox.Text == haslo && PassCodePanel.Text == login)
            {
                File.Create("Wendrol.txt");
                MessageBox.Show("Zyskano Dostêp");
                DisActivePanel(PanelLogowaniaWendroli);
                ActivePanel(EkranPowitalny);
                SprawdzDosemp();

            }
            else if (LoginTextBox.Text == "" || PassCodePanel.Text == "")
            {
                MessageBox.Show("Wype³nij Wszystkie Pola!");

            }
            else
            {
                MessageBox.Show("Acess Denet");

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisActivePanel(EkranPowitalny);
            DisActivePanel(PiosenkowyPanel);
            DisActivePanel(panel2);
            ActivePanel(PanelLogowaniaWendroli);

        }

        private void SprawdzDosemp()
        {
            bool Wendrownik = File.Exists("Wendrol");

            if (Wendrownik = false)
            {


            }
            else if (Wendrownik = true)
            {
                PokarzFunkcje();

            }


        }

        private void PokarzFunkcje()
        {
            button4.Visible = true;
            button4.Enabled = true;

            DodajPiosenkePrzycisk.Visible = true;
            DodajPiosenkePrzycisk.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja Jeszcze nie dzia³a");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Add(DodanaPiosenkaTytul.Text.ToLower());

            File.WriteAllText(DodanaPiosenkaTytul.Text.ToLower() + ".txt", TekstDodanejPiosenki.Text);

            File.WriteAllText(textBox1.AutoCompleteCustomSource.ToString(), "Piosenki.txt");

            File.AppendAllText("Piosenki.txt", "\n");
            File.AppendAllText("Piosenki.txt", DodanaPiosenkaTytul.Text);



        }

        private void DodajPiosenkePrzycisk_Click(object sender, EventArgs e)
        {

            DisActivePanel(EkranPowitalny);
            DisActivePanel(PanelLogowaniaWendroli);
            DisActivePanel(PiosenkowyPanel);
            ActivePanel(panel2);


        }

        void sprawdzanie()
        {
            string[] test = File.ReadAllLines("Piosenki.txt");


            for (int i = 0; i < test.Length; i++)
            {
                textBox1.AutoCompleteCustomSource.Add(test[i]);
            }

        }

        void czyszczenie(TextBox tekst)
        {
            tekst.Text = "";

        }

        void czyszczonko(RichTextBox tekst)
        {
            tekst.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MPH_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }






}