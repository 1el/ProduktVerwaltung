using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlausurLebedeva
{
    public partial class Form1 : Form
    {
        private List<Produkt> proList = new List<Produkt>();
        private double sum = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromDatToList();
            FromListToListBox();
        }

        private void FromDatToList()
        {
            try
            {
            FileStream fs = new FileStream("Produkte.dat", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] s;
            while (sr.Peek() != -1)
            {
                s = sr.ReadLine().Split('|');
                proList.Add(new Produkt(Convert.ToInt32(s[0]), s[1], Convert.ToDouble(s[2]), Convert.ToInt32(s[3])));
            }
            sr.Close();
            fs.Close();
            }
            catch
            {
                listBoxProdukte.Items.Add("Es gibt noch keine gespeicherte Produkte");
            }
        }

        private void FromListToListBox()
        {
            listBoxProdukte.Items.Clear();
            foreach(Produkt p in proList)
            {
                listBoxProdukte.Items.Add(p.ToString());
            }
        }

        private void FromListToDat()
        {
            FileStream fs = new FileStream("Produkte.dat", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Produkt p in proList)
            {
                sw.WriteLine(p.ToString());
            }
            sw.Close();
            fs.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            labelFehlerProduktverwaltung.Text = "";
            if (textBoxProduktNr.Text != "" && textBoxBezeichnung.Text != ""
                && textBoxPreis.Text != "" && textBoxLagerbestand.Text != "")
            {
                proList.Add(new Produkt(Convert.ToInt32(textBoxProduktNr.Text),
                                        textBoxBezeichnung.Text,
                                        Convert.ToDouble(textBoxPreis.Text),
                                        Convert.ToInt32(textBoxLagerbestand.Text)));
                FromListToListBox();
                FromListToDat();
                textBoxProduktNr.Text = "";
                textBoxBezeichnung.Text = "";
                textBoxPreis.Text = "";
                textBoxLagerbestand.Text = "";
            }
            else
            {
                labelFehlerProduktverwaltung.Text = "es fehlen Daten";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelFehlerBestellung.Text = "";
            if(listBoxProdukte.SelectedIndex != -1)
            {
                if (textBoxAnzahl.Text == "") textBoxAnzahl.Text = "1";

                int neuLagerbest = proList[listBoxProdukte.SelectedIndex].getLagerbest() - Convert.ToInt32(textBoxAnzahl.Text);

                if (neuLagerbest >= 0)
                {
                    proList[listBoxProdukte.SelectedIndex].setLagerbest(neuLagerbest);

                    double zwischenSum = proList[listBoxProdukte.SelectedIndex].getPreis() * Convert.ToInt32(textBoxAnzahl.Text);

                    listBoxBestellung.Items.Add(textBoxAnzahl.Text + " x "
                        + proList[listBoxProdukte.SelectedIndex].getBez() + " = "
                        + zwischenSum.ToString() );

                    sum += zwischenSum;
                    labelGesamtPreis.Text = "Gesamtpreis: " + sum + " EUR";
                    textBoxAnzahl.Text = "";
                    FromListToListBox();
                    FromListToDat();
                }
                else
                {
                    labelFehlerBestellung.Text = "nicht auf Lager";
                }
            }
            else
            {
                labelFehlerBestellung.Text = "kein Produkt gewaehlt";
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            textBoxAnzahl.Text = "";
            labelFehlerBestellung.Text = "";
            listBoxBestellung.Items.Clear();
            sum = 0;
            labelGesamtPreis.Text = "Gesamtpreis: " + sum + " EUR";
            listBoxProdukte.SelectedIndex = -1;
        }

        private void listBoxProdukte_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFehlerBestellung.Text = "";
        }
    }
}
