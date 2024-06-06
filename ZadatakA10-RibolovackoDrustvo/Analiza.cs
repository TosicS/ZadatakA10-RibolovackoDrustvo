using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakA10_RibolovackoDrustvo
{
    public partial class Analiza : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA10-RibolovackoDrustvo\ZadatakA10-RibolovackoDrustvo\A10.mdf;Integrated Security=True");

        public Analiza()
        {
            InitializeComponent();
        }
        public void PrikaziCB()
        {
            string sqlUpit = "Select PecarosID as sifra, concat(PecarosID, '-',Ime, ' ', Prezime) as imePrezime from Pecaros order by PecarosID asc";

            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);

                comboBoxPecaros.DataSource = tabela;
                comboBoxPecaros.DisplayMember = "imePrezime";
                comboBoxPecaros.ValueMember = "sifra";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            PrikaziCB();
            comboBoxPecaros.Text = "Izaberi pecaroša";
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (comboBoxPecaros.Text == "Izaberi pecaroša")
            {
                MessageBox.Show("Niste oznacili pecarosa");
                return;
            }
            string sqlUpit = "Select Vrsta_Ribe.Naziv as Vrsta, Count(Ulov.VrstaID) as Broj from Vrsta_Ribe " +
                "inner join Ulov on Ulov.VrstaID = Vrsta_Ribe.VrstaID " +
                "where Datum BETWEEN @parOd AND @parDd and Ulov.PecarosID = @parSifra " +
                "group by Vrsta_Ribe.Naziv";
            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            cmd.Parameters.AddWithValue("@parOd", dateTimePickerOdDatum.Value);
            cmd.Parameters.AddWithValue("@parDd", dateTimePickerDoDatuma.Value);
            cmd.Parameters.AddWithValue("@parSifra", comboBoxPecaros.SelectedValue);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;

                chart1.DataSource = tabela;
                chart1.Series[0].XValueMember = "Vrsta";
                chart1.Series[0].YValueMembers = "Broj";
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
