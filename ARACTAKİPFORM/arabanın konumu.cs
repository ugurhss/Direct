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
    public partial class arabanın_konumu : Form
    {
        public arabanın_konumu()
        {
            InitializeComponent();
        }

        private void arabanın_konumu_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap gMaps = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["AYD"] = 100;
            keyValues["ML"] = 999;
           
            gMaps.HeatMap = keyValues;
            gMaps.Source = "XmlFile1.xml";
     

            this.Controls.Add(gMaps);
            gMaps.Dock = DockStyle.Fill;

        }
    }
}
