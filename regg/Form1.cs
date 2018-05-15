using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regg
{
    public partial class GlavnoOkno : Form
    {
        List<oseba> osebe = new List<oseba>();

        public GlavnoOkno()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToShortDateString();
            ura.Text = DateTime.Now.ToLongTimeString();
            vnosBox.Focus();

            label1.Text =  dataAccess.aliBazaObstaja().ToString();

            if (!dataAccess.aliBazaObstaja())
            {
                string conStr = "Data Source=(LocalDb)/LocalDBDemo;Initial Catalog=registrator;Integrated Security=True";
                label1.Text ="Baza je bila ustvarjena"+ Helper.CreateDataBase(conStr).ToString();
            }
                   
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vnosBox.Focus();
            timer1.Interval = 1000;

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();
            izhod1.Hide();
            SkupnoStUr.Hide();

        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataAccess db = new dataAccess();

            osebe = db.getOsebe();
        }



        private void vnosBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.prihodIzhodMetoda();
            }

        }

        private void prihodIzhodMetoda()
        {
            //vnos tevilke kartice v vnosno polje

            dataAccess db = new dataAccess();
            string str = "";
            string stUr = "";
            string minute = "";
            string id = vnosBox.Text;
            if (vnosBox.Text != "")
            {
                id = vnosBox.Text;
            }
            else { MessageBox.Show("Vnos je prazen"); }
            lbl_casIzhod.Text = "";
            lbl_casSkupni.Text = "";

            oseba osebaById = db.getOseboById(id);


            //če je oseba v bazi, ji doda prihod
            if (osebaById != null)
            {

                //če osebe ni v stavni, pomeni da je prišla
                if (!db.aliJeOsebaVStavbi(id))

                {
                    try
                    {
                        db.dodaj_prihod(id);
                    }
                    catch
                    {
                        MessageBox.Show("Zaustavila se je metoda 'dodaj prihod'");
                    }
                    str = "Prihod";
                    lbl_casIzhod.Text = "";
                    lbl_casSkupni.Text = "";
                    lbl_prihod.Show();
                    var t = new Timer();
                    t.Interval = 7000;
                    t.Tick += (s, et) =>
                    {
                        lbl_prihod.Hide();
                    };
                    t.Start();

                }
                else
                {
                    db.izhod(id);
                    str = "Izhod";
                    prikaziKomponente();
                    lbl_prihod.Show();
                    stUr = db.skupnoStUr(id).ToString();
                    minute = db.skupnoStMinut(id).ToString();
                    lbl_casIzhod.Text = db.stUr(id).ToString() + ":" + db.stMin(id);
                    lbl_casSkupni.Text = db.skupnoStUr(id).ToString() + ":" + db.skupnoStMinut(id).ToString();
                    var t = new Timer();
                    t.Interval = 7000;
                    t.Tick += (s, et) =>
                    {
                        lbl_casSkupni.Hide();
                        lbl_prihod.Hide();
                        lbl_casIzhod.Hide();
                        izhod1.Hide();
                        SkupnoStUr.Hide();
                        t.Stop();
                    };
                    t.Start();
                }
                //izpis izhode osebe
                lbl_prihod.Text = str + " osebe : " + osebaById.ime + " " + osebaById.priimek;
                lbl_prihod.ForeColor = Color.Green;


            }
            else
            {
                lbl_prihod.Show();
                lbl_prihod.Text = "Osebe ni v bazi";
                lbl_prihod.ForeColor = Color.Red;
                lbl_casIzhod.Text = "";
                lbl_casSkupni.Text = "";
            }


            vnosBox.Text = "";

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DodajOsebo f2 = new DodajOsebo();
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ura.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void prikaziKomponente()
        {
            lbl_casIzhod.Show();
            lbl_casSkupni.Show();
            
            izhod1.Show();
            SkupnoStUr.Show();
        }

        private void st1_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "1";
        }

        private void st2_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "2";
        }
        private void st3_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "3";
        }
        private void st4_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "4";
        }
        private void st5_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "5";
        }
        private void st6_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "6";
        }
        private void st7_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "7";
        }
        private void st8_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "8";
        }
        private void st9_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "9";
        }
        private void st0_Click(object sender, EventArgs e)
        {
            vnosBox.Text += "0";
        }
        private void enter_Click(object sender, EventArgs e)
        {
            this.prihodIzhodMetoda();
        }

    }
}
