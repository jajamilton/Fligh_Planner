﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App_Flight_Plan.Paginas
{
    /// <summary>
    /// Lógica de interacción para Tanques.xaml
    /// </summary>
    public partial class Tanques : Window
    {
        public Tanques()
        {
            InitializeComponent();
        }

        private void CerrarVentanaTanques(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    
}
