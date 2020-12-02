using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace voteapp
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(string account, string password)
        {
            InitializeComponent();
            username_2.Content = account;
        }
        private void Window2_Load(object sender, EventArgs e)
        {
            //MainWindow mainWindow = (MainWindow)this.Owner;
            //MessageBox.Show("Welcome " + mainWindow.useraccount);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void personcenter_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Hide();
        }

        private void delivervote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
