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
    /// Window3.xaml 的交互逻辑
    /// </summary>
    public partial class Window3 : Window
    {
        string useraccount;
        string userpassword;
        string username;
        string usertext;
        public Window3(string account, string password, string name, string text)
        {
            InitializeComponent();
            useraccount = account;
            userpassword = password;
            username = name;
            usertext = text;
            centeraccount.Content = account;
            centername.Content = name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(useraccount, userpassword, username, usertext);
            this.Hide();
            window2.Show();
            //GetWindow().Show();
        }
    }
}
