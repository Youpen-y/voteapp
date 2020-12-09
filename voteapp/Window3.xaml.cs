using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        string connetStr;
        public Window3(string account, string password)
        {
            InitializeComponent();
            useraccount = account;
            userpassword = password;
            centeraccount.Content = account;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "select * from user_table where userAccount = '" + useraccount + "'";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            this.centeraccount.Content = ds.Tables[0].Rows[0][1].ToString();
            this.centername.Content= ds.Tables[0].Rows[0][3].ToString();
            this.centername1.Content= ds.Tables[0].Rows[0][3].ToString();
            this.centertext.Text = ds.Tables[0].Rows[0][5].ToString();
            ds.Clear();
            DataTable dt = new DataTable();
            string strSqlone = "select * from theme_table";
            MySqlCommand command = new MySqlCommand(strSqlone, conn);
            MySqlDataAdapter ada = new MySqlDataAdapter(command);
            ada.Fill(ds, "Theme");
            dt = ds.Tables["Theme"];
            centertheme.ItemsSource = dt.DefaultView;
            conn.Close();
        }
        private MySqlConnection ConnectDatabase()
        {
            connetStr = "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            return conn;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(useraccount, userpassword);
            this.Hide();
            window2.Show();
            //GetWindow().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string themeID = this.InputID.Text;
            Window7 window7 = new Window7(themeID);
            window7.Show();
        }
    }
}
