using System;
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
            TanquesAeronave.ItemsSource = cargarTanques();
        }

        private void CerrarVentanaTanques(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public List<Tanque> cargarTanques()
        {
            List<Tanque> tanques = new List<Tanque>();
            tanques.Add(
                new Tanque { CumbustibleTotal = "15658", PorcentajeTotal = "15" }
            );
            tanques.Add(
                new Tanque { CumbustibleTotal = "15658", PorcentajeTotal = "15" }
            );
            tanques.Add(
                new Tanque { CumbustibleTotal = "15658", PorcentajeTotal = "15" }
            );

            return tanques;
        }



        public class Tanque
        {
            public string CumbustibleTotal { get; set; }
            public string PorcentajeTotal { get; set; }
        }
    }

    
}
