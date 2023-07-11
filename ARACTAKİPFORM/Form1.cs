using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARACTAKİPFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbxOnayliyorum_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxOnayliyorum.Checked) // Eger secilirse
            {
                // Yeni bir form oluşturun
                Onayliyorum yeniForm = new Onayliyorum();

                // Formu gösterin
                yeniForm.Show();
            }
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {

            // Yeni bir form oluşturun
            arabanın_konumu yeniForm = new arabanın_konumu();

            // Formu gösterin
            yeniForm.Show();
        }

        private void yazılımHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ugur can DOĞAN TARAFINDAN YAPILMİŞTIR ugurcandgn46@iclou.com");
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ugurcandgn46@iclou.com iletişime gec");
        }

        private void yeniSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pek yakında");
        }

        private void hataAyıklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pek yakıında");
        }
    }
}
