﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Layers.SplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {

            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 3000;//Duracion en milisegundos

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
