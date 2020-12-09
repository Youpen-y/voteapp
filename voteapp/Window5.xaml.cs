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
    /// Window5.xaml 的交互逻辑
    /// </summary>
    public partial class Window5 : Window
    {
        string useraccount;
        string userpassword;
        String connetStr;
        
        public Window5(string account, string password)
        {
            InitializeComponent();
            useraccount = account;
            userpassword = password;

            
        }
        private MySqlConnection ConnectDatabase() 
        {
            connetStr= "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            return conn;
        }
        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "select * from theme_table";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ad.Fill(ds,"Theme");
            dt = ds.Tables["Theme"];
            dataView.ItemsSource = dt.DefaultView;
            conn.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 window2 = new Window2(useraccount,userpassword);
            window2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int themeID;
            string themeContent;
            string user;
            if (this.getThemeID.Text == null)
            {
                MessageBox.Show("Please input the ThemeID");
            }
            else
            {
                themeID = Convert.ToInt32(this.getThemeID.Text);
                MySqlConnection conn = ConnectDatabase();
                conn.Open();
                string strSql = "select count(*) from theme_table where themeID = '"+ themeID +" '";
                string strSqlone = "select * from theme_table where themeID = '" + themeID + "'";
                MySqlCommand comm = new MySqlCommand(strSql, conn);
                MySqlCommand comm1 = new MySqlCommand(strSqlone, conn);
                MySqlDataAdapter ad = new MySqlDataAdapter(comm1);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                themeContent = ds.Tables[0].Rows[0][1].ToString();
                user = ds.Tables[0].Rows[0][2].ToString();
                if (Convert.ToInt32(comm.ExecuteScalar()) <= 0)
                {
                    MessageBox.Show("无相应主题，请重新输入");
                }
                else
                {
                    Window6 window6 = new Window6(themeID, themeContent, user);
                    window6.Show();
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
