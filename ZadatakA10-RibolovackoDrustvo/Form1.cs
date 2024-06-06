using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZadatakA10_RibolovackoDrustvo
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA10-RibolovackoDrustvo\ZadatakA10-RibolovackoDrustvo\A10.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public void PrikaziLB()
        {
            string sqlUpit = "Select PecarosID, Ime, Prezime, Adresa, Grad, Telefon from Pecaros " +
                "inner join Grad on Grad.GradID = Pecaros.GradID order by PecarosID asc";

            SqlCommand cmd = new SqlCommand(sqlUpit,konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            try
            {
                listBox1.Items.Clear();
                dt.Clear();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(string.Format("{0,-7} {1,-15} {2,-15} {3,-25} {4,-15} {5,-10}", row[0], row[1], row[2], row[3], row[4], row[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrikaziCB() 
        {
            string sqlUpit = "Select GradID, Grad from Grad ORDER BY Grad ASC";

            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);

                comboBoxGrad.DataSource = tabela;
                comboBoxGrad.DisplayMember = "Grad";
                comboBoxGrad.ValueMember = "GradID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrikaziTB()
        {
            string sqlUpit = "Select PecarosID, Ime, Prezime, Adresa, Grad, Telefon from Pecaros " +
                            "inner join Grad on Grad.GradID = Pecaros.GradID order by PecarosID asc";

            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);

                textBoxSifra.Text = tabela.Rows[0][0].ToString();
                textBoxIme.Text = tabela.Rows[0][1].ToString();
                textBoxPrezime.Text = tabela.Rows[0][2].ToString();
                textBoxAdresa.Text = tabela.Rows[0][3].ToString();
                comboBoxGrad.Text = tabela.Rows[0][4].ToString();
                textBoxTelefon.Text = tabela.Rows[0][5].ToString();

                listBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearControls()
        {
            textBoxSifra.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            comboBoxGrad.Text = "";
            textBoxTelefon.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPrikaziLV.Text = string.Format("{0,-7} {1,-15} {2,-15} {3,-25} {4,-15} {5,-10}", "Sifra", "Ime", "Prezime", "Adresa", "Grad", "Telefon");
            textBoxIme.Focus();
            PrikaziLB();
            PrikaziCB();
            PrikaziTB();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSifra.Text = dt.Rows[listBox1.SelectedIndex][0].ToString();
            textBoxIme.Text = dt.Rows[listBox1.SelectedIndex][1].ToString();
            textBoxPrezime.Text = dt.Rows[listBox1.SelectedIndex][2].ToString();
            textBoxAdresa.Text = dt.Rows[listBox1.SelectedIndex][3].ToString();
            comboBoxGrad.Text = dt.Rows[listBox1.SelectedIndex][4].ToString();
            textBoxTelefon.Text = dt.Rows[listBox1.SelectedIndex][5].ToString();
        }

        private void toolStripButtonIzmena_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxAdresa.Text == "" || textBoxTelefon.Text == "")
            {
                MessageBox.Show("Morate uneti sve podatke!");
                return;
            }

            if (textBoxSifra.Text != "")
            {
                try
                {
                    string sqlUpit = "UPDATE Pecaros SET Ime = @Ime, Prezime = @Prezime, Adresa = @Adresa, GradID = @Grad, Telefon = @Telefon WHERE PecarosID = @PecarosID";

                    SqlCommand komandaIzmena = new SqlCommand(sqlUpit, konekcija);
                    komandaIzmena.Parameters.AddWithValue("@PecarosID", Convert.ToInt32(textBoxSifra.Text));
                    komandaIzmena.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                    komandaIzmena.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                    komandaIzmena.Parameters.AddWithValue("@Adresa", textBoxAdresa.Text);
                    komandaIzmena.Parameters.AddWithValue("@Grad", comboBoxGrad.SelectedValue);
                    komandaIzmena.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);

                    konekcija.Open();
                    komandaIzmena.ExecuteNonQuery();
                    konekcija.Close();

                    PrikaziLB();
                    ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati red koji zelite da izmenite!");
            }
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza forma = new Analiza();
            forma.Show();
        }

        private void toolStripButtonOAplikaciji_Click(object sender, EventArgs e)
        {
            OAplikaciji forma = new OAplikaciji();
            forma.Show();
        }

        private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
