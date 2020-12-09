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
        string useraccount;
        string userpassword;
        string username;
        string usertext;
        public Window2(string account, string password, string name, string text)
        {
            InitializeComponent();
            useraccount = account;
            userpassword = password;
            username = name;
            usertext = text;
            username_2.Content = account;
        }
        private void Window2_Load(object sender, EventArgs e)
        {
            //MainWindow mainWindow = (MainWindow)this.Owner;
            //MessageBox.Show("Welcome " + mainWindow.useraccount);
        }
       
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void personcenter_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3(useraccount, userpassword, username, usertext);
            window3.Show();
            this.Hide();
        }

        private void delivervote_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window4 window4 = new Window4(useraccount,userpassword,username,usertext);
            window4.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window5 window5 = new Window5(useraccount,userpassword,username,usertext);
            window5.Show();
        }
    }
}
