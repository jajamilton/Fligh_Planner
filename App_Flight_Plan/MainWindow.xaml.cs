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
using App_Flight_Plan.Paginas;

namespace App_Flight_Plan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Myframe.NavigationService.Navigate(new Inicio());
        }

        private void Btn_Hangar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Myframe.NavigationService.Navigate(new Hangar());

            }
            catch(Exception ex){ }
        }

        private void Btn_Inicio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Myframe.NavigationService.Navigate(new Inicio());

            }
            catch(Exception ex) { }
        }

        private void Btn_Plan_Vuelo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Myframe.NavigationService.Navigate(new PlanVuelo());

            }
            catch (Exception ex) { }
        }
    }
}
