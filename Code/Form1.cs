using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void AsignFromTextBox(ref int val, ref TextBox box)
        {
            try
            {
                val = int.Parse(box.Text);
            }
            catch (FormatException)
            {
                box.Text = val.ToString() + " (default)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitmapMaps b = new BitmapMaps();
            AsignFromTextBox(ref b.OceanDetails, ref OceanLayers);
            AsignFromTextBox(ref b.ShoreDetails, ref ShoreLayers);
            AsignFromTextBox(ref b.ForestDetails, ref ForestLayers);
            AsignFromTextBox(ref b.MountainDetails, ref MountainLayers);
            AsignFromTextBox(ref b.SnowDetails, ref SnowLayers);

            label1.BackgroundImage = b.CreateMap();
        }
    }
}
