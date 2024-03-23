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
using System.ComponentModel;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new ViewModel();
            this.DataContext = ViewModel;

        }

    }
    public class ViewModel : INotifyPropertyChanged

    {
        public double _radius_okrujnosti;
        public double _radius_shara;
        public double _height;

        public double radius_okrujnosti
        {
            get { return _radius_okrujnosti; } set
            {
                _radius_okrujnosti = value;
                RaisePropertyChanged(nameof(radius_okrujnosti));
                RaisePropertyChanged(nameof(Area));
            }
        }
           
        public double radius_shara
        {
            get { return _radius_shara; } set
            {
                _radius_shara = value;
                RaisePropertyChanged(nameof(radius_shara));
                RaisePropertyChanged(nameof(Area));
            }

        }
        public double height 
        {
            get { return _height; } set
            {
                _height = value;
                RaisePropertyChanged(nameof(height));
                RaisePropertyChanged(nameof(Area));
            }
        }
        public double Area
        {
            get
            {
                try
                {
                    return TRPO_Lab3.Library.MathLib.CalculateSphereSectorSurfaceArea(radius_shara, radius_okrujnosti, height);
                }
                catch (Exception ex)
                {  
                    return 0;
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
