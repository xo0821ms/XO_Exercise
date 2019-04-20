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

namespace HeapSample
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Window> winList;
        private void Buttom1_Click(object sender, RoutedEventArgs e)
        {
            winList = new List<Window>();
            for (int i = 0; i < 15000; i++)
            {
                Window s = new Window();
                winList.Add(s);
            }
        }

        private void Buttom2_Click(object sender, RoutedEventArgs e)
        {
            winList.Clear();
        }
    }
}
