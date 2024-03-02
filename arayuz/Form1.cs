using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


public struct Rocket
{
    public float bme_alt, bme_pres, bme_temp;
    public float gps_alt, gps_lat, gps_lon;
    public float gyro_x, gyro_y, gyro_z, acc_x, acc_y, acc_z;
    public float rc_angx, rc_angy, rc_angz, rc_speed;
    public int rc_stat, rc_flag;
}

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void irtifa_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sayac = textBox2.Text;
            float.TryParse(sayac, out float floatValue);
            label48.Text = floatValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            double enlem = Convert.ToDouble(txtEnlem.Text);
            double boylam = Convert.ToDouble(txtBoylam.Text);
            map.Position = new GMap.NET.PointLatLng(enlem, boylam);
            map.Zoom = 10;
            map.MinZoom = 1;
            map.MaxZoom = 10;
            map.DragButton = MouseButtons.Left;
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
    }
}
