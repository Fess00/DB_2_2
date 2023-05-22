using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace UserInterfaceDB_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IPoint a1, b1, c1, d1, a2, b2, c2, d2;
        private Bezier bezier1, bezier2;

        private void Button_Click_Save_Cgd(object sender, RoutedEventArgs e)
        {
            if (File.Exists(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CGD.png"))
                bezier2.SaveSVG();
        }

        private void Button_Click_L_Cgd(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            a2 = new Point();
            a2.SetX((float)rand.Next(0, 1000));
            a2.SetY((float)rand.Next(0, 700));
            b2 = new Point();
            b2.SetX((float)rand.Next(0, 1000));
            b2.SetY((float)rand.Next(0, 700));
            c2 = new Point();
            c2.SetX((float)rand.Next(0, 1000));
            c2.SetY((float)rand.Next(0, 700));
            d2 = new Point();
            d2.SetX((float)rand.Next(0, 1000));
            d2.SetY((float)rand.Next(0, 700));

            bezier2 = new Bezier(a2, b2, c2, d2);
            bezier2.SetDrawer(new CGDrawer());
            scheme_s.Source = null;
            bezier2.Draw();
            scheme_s.Source = new BitmapImage(new Uri(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CGD.png"));
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_L_Cbd(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            a1 = new Point();
            a1.SetX((float)rand.Next(0, 1000));
            a1.SetY((float)rand.Next(0, 700));
            b1 = new Point();
            b1.SetX((float)rand.Next(0, 1000));
            b1.SetY((float)rand.Next(0, 700));
            c1 = new Point();
            c1.SetX((float)rand.Next(0, 1000));
            c1.SetY((float)rand.Next(0, 700));
            d1 = new Point();
            d1.SetX((float)rand.Next(0, 1000));
            d1.SetY((float)rand.Next(0, 700));

            bezier1 = new Bezier(a1, b1, c1, d1);
            bezier1.SetDrawer(new CBDrawer());
            scheme_f.Source = null;
            bezier1.Draw();
            scheme_f.Source = new BitmapImage(new Uri(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CBD.png"));
        }

        private void Button_Click_Save_Cbd(object sender, RoutedEventArgs e)
        {
            if (File.Exists(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CBD.png"))
                bezier1.SaveSVG();
        }
    }
}
