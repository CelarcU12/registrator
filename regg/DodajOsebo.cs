using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regg
{
    public partial class DodajOsebo : Form
    {
        public DodajOsebo()
        {
            InitializeComponent();
        }

        private void btnVstavi_Click(object sender, EventArgs e)
        {
            dataAccess db = new dataAccess();
            dataAccess db2 = new dataAccess();
            if (IDBox.Text !="")
            {
                db2.getOseboById(IDBox.Text);
            }
            else
            {
                MessageBox.Show("Manjkajo podatki");
                IDBox.BackColor = Color.Red;
                return;
            }
                if (imeBox.Text != "" && priimekBox.Text != "" && IDBox.Text != "")
                {
                    try
                    {
                        db.VstaviOsebo(imeBox.Text, priimekBox.Text,IDBox.Text);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally
                    {
                        MessageBox.Show("Oseba " + imeBox.Text + " je uspešno dodana!");
                    
                        this.Close();
                    }
                    imeBox.Text = "";
                    priimekBox.Text = "";
                    IDBox.Text = "";
                return;
                }
           
            else
            {
                MessageBox.Show("Oseba s to kartico je že v bazi!");
            }

        }
    }
}
