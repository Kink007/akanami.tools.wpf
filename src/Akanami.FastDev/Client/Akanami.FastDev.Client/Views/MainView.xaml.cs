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

namespace Akanami.FastDev.Client.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnWindowMinisize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnWindowMaxsize_Click(object sender, RoutedEventArgs e)
        {
            this.btnWindowShrink.Visibility = Visibility.Visible;
            this.btnWindowMaxsize.Visibility = Visibility.Collapsed;

            this.WindowState = WindowState.Maximized;
        }

        private void btnWindowShrink_Click(object sender, RoutedEventArgs e)
        {
            this.btnWindowShrink.Visibility = Visibility.Collapsed;
            this.btnWindowMaxsize.Visibility = Visibility.Visible;

            this.WindowState = WindowState.Normal;
        }

        private void btnWindowClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
