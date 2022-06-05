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

namespace WpfApp_HomeWork_from20220522
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Navy_1.Background == Brushes.Navy)
            {
                Navy_1.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Navy_1.Background = Brushes.Navy; 
        }

        private void Blue_2_Click(object sender, RoutedEventArgs e)
        {
            if (Blue_2.Background == Brushes.Blue)
            {
                Blue_2.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Blue_2.Background = Brushes.Blue;
        }

        private void Aqua_3_Click(object sender, RoutedEventArgs e)
        {
            if (Aqua_3.Background == Brushes.Aqua)
            {
                Aqua_3.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Aqua_3.Background = Brushes.Aqua;
        }

        private void Teal_4_Click(object sender, RoutedEventArgs e)
        {
            if (Teal_4.Background == Brushes.Teal)
            {
                Teal_4.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Teal_4.Background = Brushes.Teal;
        }

        private void Olive_5_Click(object sender, RoutedEventArgs e)
        {
            if (Olive_5.Background == Brushes.Olive)
            {
                Olive_5.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF9FC0BB");
            }
            else Olive_5.Background = Brushes.Olive;
        }

        private void Green_6_Click(object sender, RoutedEventArgs e)
        {
            if (Green_6.Background == Brushes.Green)
            {
                Green_6.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Green_6.Background = Brushes.Green;
        }

        private void Lime_7_Click(object sender, RoutedEventArgs e)
        {
            if (Lime_7.Background == Brushes.Lime)
            {
                Lime_7.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Lime_7.Background = Brushes.Lime;
        }

        private void Yellow_8_Click(object sender, RoutedEventArgs e)
        {
            if (Yellow_8.Background == Brushes.Yellow)
            {
                Yellow_8.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Yellow_8.Background = Brushes.Yellow;
        }

        private void Orange_9_Click(object sender, RoutedEventArgs e)
        {
            if (Orange_9.Background == Brushes.Orange)
            {
                Orange_9.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Orange_9.Background = Brushes.Orange;
        }

        private void Red_10_Click(object sender, RoutedEventArgs e)
        {
            if (Red_10.Background == Brushes.Red)
            {
                Red_10.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Red_10.Background = Brushes.Red;
        }

        private void Maroon_11_Click(object sender, RoutedEventArgs e)
        {
            if (Maroon_11.Background == Brushes.Maroon)
            {
                Maroon_11.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Maroon_11.Background = Brushes.Maroon;
        }

        private void Fuchsia_12_Click(object sender, RoutedEventArgs e)
        {
            if (Fuchsia_12.Background == Brushes.Fuchsia)
            {
                Fuchsia_12.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Fuchsia_12.Background = Brushes.Fuchsia;
        }

        private void Purple_13_Click(object sender, RoutedEventArgs e)
        {
            if (Purple_13.Background == Brushes.Purple)
            {
                Purple_13.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Purple_13.Background = Brushes.Purple;
        }

        private void Black_14_Click(object sender, RoutedEventArgs e)
        {
            if (Black_14.Background == Brushes.Black)
            {
                Black_14.Background = Brushes.Gray; //new SolidColorBrush(Colors.Gray);
            }
            else Black_14.Background = Brushes.Black;
        }

        private void Silver_15_Click(object sender, RoutedEventArgs e)
        {
            if (Silver_15.Background == Brushes.Silver)
            {
                Silver_15.Background = Brushes.Gray; 
            }
            else Silver_15.Background = Brushes.Silver;
        }

        private void Grey_16_Click(object sender, RoutedEventArgs e)
        {
            if (Grey_16.Background == Brushes.Gray)
            {
                Grey_16.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE8CC49");
            }
            else Grey_16.Background = Brushes.Gray;
        }

        private void White_17_Click(object sender, RoutedEventArgs e)
        {
            if (White_17.Background == Brushes.White)
            {
                White_17.Background = Brushes.Gray;
            }
            else White_17.Background = Brushes.White;
        }
    }
}
