﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Layers.SplashScreen
{
    public class Class1
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen sp = new SplashScreen();
            if (sp.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
    }
} 