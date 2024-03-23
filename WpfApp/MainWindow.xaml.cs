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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{ 
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel ViewModel { get; set;}

        public MainWindow()
        {
        InitializeComponent();
        ViewModel = new ViewModel();
        this.DataContext = ViewModel;

        }

    }
    public class ViewModel
    {
        public double radius_okrujnosti { get; set; }
        public double radius_shara { get; set; }
        public double height { get; set; }
        public double Area
        {
            get
            {
                return TRPO_Lab3.Library.MathLib.CalculateSphereSectorSurfaceArea(radius_shara, radius_okrujnosti, height);
            }
        }
    }
}
