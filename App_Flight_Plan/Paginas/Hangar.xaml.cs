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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Flight_Plan.Paginas
{
    /// <summary>
    /// Lógica de interacción para Hangar.xaml
    /// </summary>
    public partial class Hangar : Page
    {
        public Hangar()
        {
            InitializeComponent();

            HangarRegistrado.ItemsSource= CargarAronave();

        }



        public class Aeronave
        {
            public string Nombre { get; set; }
            public string Cod { get; set; }
            public string velocidad { get; set; }
        }



        public List<Aeronave> CargarAronave()
        {
            List<Aeronave> hangar = new List<Aeronave>();
            hangar.Add(new Aeronave()
            {
                Nombre = "CESSNA 208",
                Cod = "c208",
                velocidad="140"
            }) ;

            hangar.Add(new Aeronave()
            {
                Nombre = "Baron 58",
                Cod = "BE58",
                velocidad = "140"
            });

            return hangar;
        }

    }


  


}
