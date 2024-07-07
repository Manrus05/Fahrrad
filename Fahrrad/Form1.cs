using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrrad
{
    public partial class Form1 : Form
    {
        Datenbank db;
        List<Fertigware> liFw;
        List<Rohware> liRw;
        List<DispRw> liDispRw;
        List<Lager> liLager;

        public Form1()
        {
            InitializeComponent();
            db = new Datenbank();
            
            dispFertigware();
            dispRohware();
            dispLager();
        }
        private void dispLager()
        {
            liLager = db.getLagerbestand();

            libLager.Items.Clear();

            foreach( Lager lager in liLager )
            {
                string s = liRw.Find(x => x.RwNr == lager.Lnr).RwBezeichnung;
                libLager.Items.Add(s + " " + lager.Lbestand);
            }
        }
        private void dispRohware()
        {
            liRw = db.holeRohware();

            if( liRw.Count > 0 )
            {
                dataGridView3.Rows.Clear();
                comboBox1.Items.Clear();
                cbRwLager.Items.Clear();

                foreach (Rohware rw in liRw)
                {
                    dataGridView3.Rows.Add(rw.RwNr, rw.RwBezeichnung, rw.RwPreis);
                    comboBox1.Items.Add(rw.RwBezeichnung);
                    cbRwLager.Items.Add(rw.RwBezeichnung);
                }
            }
        }
        private void dispFertigware()
        {
            liFw = db.holeFertigware();

            if ( liFw.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach( Fertigware fw in liFw)
                {
                    dataGridView1.Rows.Add(fw.FwNr, fw.FwModell, fw.FwPreis);
                    cbFahrradBestellen.Items.Add(fw.FwModell);
                }

            }
        }
        private void BtnFwSpeichern_Click(object sender, EventArgs e)
        {
            Fertigware fw =
                new Fertigware(-1, tbFwModell.Text, Convert.ToDouble(tbFwPreis.Text));
            db.speichereFertigware(fw);
            dispFertigware();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Rohware rw = new Rohware(-1, textBox3.Text, Convert.ToDouble(textBox4.Text));
            db.speichereRohware(rw);
            dispRohware();
        }
        private void DataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if( dataGridView3.SelectedRows.Count > 0)
            {
                textBox2.Text = 
                    dataGridView3.SelectedRows[0].Cells["rwNrCol"].Value.ToString();
                textBox3.Text =
                    dataGridView3.SelectedRows[0].Cells["rwBezeichnungCol"].Value.ToString();
                textBox4.Text =
                    dataGridView3.SelectedRows[0].Cells["rwPreisCol"].Value.ToString();
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbFwNr.Text = dataGridView1.SelectedRows[0].Cells["fwnrCol"].Value.ToString();
                tbFwModell.Text = dataGridView1.SelectedRows[0].Cells["ModellCol"].Value.ToString();
                tbFwPreis.Text = dataGridView1.SelectedRows[0].Cells["PreisCol"].Value.ToString();
                showPic(Convert.ToInt32(tbFwNr.Text));

                dispRwzuFw(Convert.ToInt32(tbFwNr.Text));
            }
        }
        private void showPic( int fwNr)
        {
            string path = @"Bilder\" + fwNr + ".jpg";

            if( File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void dispRwzuFw( int fwnr )
        {
            liDispRw = db.holeRwzuFw(fwnr);
            dataGridView2.Rows.Clear();

            foreach( DispRw dr in liDispRw )
            {
                double gesamt = dr.rwMenge * dr.rwPreis;
                dataGridView2.Rows.Add(dr.fwNr, dr.rwBezeichnung, 
                    dr.rwMenge.ToString(), gesamt.ToString("#0.00") );
            }

            double summe = liDispRw.Sum(x => (x.rwPreis * x.rwMenge));
            label1.Text = "Gesamtkosten: " + summe.ToString("#0.00");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int fwnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["fwNrCol"].Value.ToString());
            int rwnr = liRw[comboBox1.SelectedIndex].RwNr;
            int menge = Convert.ToInt32(textBox1.Text);

            FwRw fwrw = new FwRw(-1, fwnr, rwnr, menge );
            db.speichereFwRw(fwrw);
            dispRwzuFw(fwnr);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Lager lg = new Lager(liRw[cbRwLager.SelectedIndex].RwNr,
                        Convert.ToInt32(tbLagerbestand.Text));
            db.saveLagerbestand(lg);
            dispLager();
        }
        private void cbFahrradBestellen_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            liDispRw = 
                db.holeRwzuFw(liFw[cbFahrradBestellen.SelectedIndex].FwNr);
            int i = 0;
            Color color;
            foreach( DispRw dr in liDispRw )
            {
                int anLager = liLager.Where(x=>x.Lnr==dr.rwNr).Sum(x => x.Lbestand);
                dataGridView4.Rows.Add(dr.rwBezeichnung, dr.rwMenge, anLager);
                if (dr.rwMenge <= anLager)
                    color = Color.LightGreen;
                else
                    color = Color.LightPink;
                dataGridView4.Rows[i].Cells[2].Style.BackColor = color;
                i++;
            }
        }
    }
}
