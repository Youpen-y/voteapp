using MySql.Data.MySqlClient;
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
    /// Window4.xaml 的交互逻辑
    /// </summary>
    public partial class Window4 : Window
    {
        string useraccount;
        string userpassword;
        string username;
        string usertext;
        string votetheme;
        string itemA;
        string itemB;
        string itemC;
        string itemD;
        int themeID;
        String connetStr = "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
        MySqlConnection conn;
        public Window4(string account, string password, string name, string text)
        {
            InitializeComponent();
            useraccount = account;
            userpassword = password;
            username = name;
            usertext = text;
            conn = new MySqlConnection(connetStr);
            conn.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 window2 = new Window2(useraccount,userpassword,username,usertext);
            window2.Show();
        }

        private void createVote_Click(object sender, RoutedEventArgs e)
        {
            votetheme = this.theme.Text;
            itemA = this.choiceA.Text;
            itemB = this.choiceB.Text;
            itemC = this.choiceC.Text;
            itemD = this.choiceD.Text;

            Random random = new Random();
            themeID = random.Next(1, 10000);
            string strInsertSql = "insert into theme_table (themeID,themeTitle,Initiator) values ('"+themeID+"','" + votetheme + "','" + useraccount + "')";
            string strInsertSqlA = "insert into item_table (TopicID,itemContent,itemChoice) values ('" + themeID + "', '" + itemA + "',0)";
            string strInsertSqlB = "insert into item_table (TopicID,itemContent,itemChoice) values ('" + themeID + "', '" + itemB + "',0)";
            string strInsertSqlC = "insert into item_table (TopicID,itemContent,itemChoice) values ('" + themeID + "', '" + itemC + "',0)";
            string strInsertSqlD = "insert into item_table (TopicID,itemContent,itemChoice) values ('" + themeID + "', '" + itemD + "',0)";
            MySqlCommand command = new MySqlCommand(strInsertSql, conn);
            MySqlCommand commandA = new MySqlCommand(strInsertSqlA, conn);
            MySqlCommand commandB = new MySqlCommand(strInsertSqlB, conn); 
            MySqlCommand commandC = new MySqlCommand(strInsertSqlC, conn);
            MySqlCommand commandD = new MySqlCommand(strInsertSqlD, conn);
            int A = commandA.ExecuteNonQuery();
            int B = commandB.ExecuteNonQuery();
            int C = commandC.ExecuteNonQuery();
            int D = commandD.ExecuteNonQuery();
            if (command.ExecuteNonQuery() > 0 )
            {
                MessageBox.Show("Theme created successfully");
            }
            else
            {
                MessageBox.Show("Theme created failed");
            }
        }

        private void theme_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
