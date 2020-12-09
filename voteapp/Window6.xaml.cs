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
    /// Window6.xaml 的交互逻辑
    /// </summary>
    public partial class Window6 : Window
    {
        int themeID;
        string themeContent;
        string Initiator;
        int choiceA;
        int choiceB;
        int choiceC;
        int choiceD;
        string itemContentA;
        string itemContentB;
        string itemContentC;
        string itemContentD;
        string connetStr;

        private MySqlConnection ConnectDatabase()
        {
            connetStr = "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            return conn;
        }
        public Window6(int ID, string content, string initiator)
        {
            themeID = ID;
            themeContent = content;
            Initiator = initiator;
            InitializeComponent();
            themeName.Content = content;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "select * from item_table where TopicID = '" + themeID + " '";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            itemContentA = ds.Tables[0].Rows[0][2].ToString();
            itemContentB = ds.Tables[0].Rows[1][2].ToString();
            itemContentC = ds.Tables[0].Rows[2][2].ToString();
            itemContentD = ds.Tables[0].Rows[3][2].ToString();

            LabelA.Content = ds.Tables[0].Rows[0][2];
            LabelB.Content = ds.Tables[0].Rows[1][2];
            LabelC.Content = ds.Tables[0].Rows[2][2];
            LabelD.Content = ds.Tables[0].Rows[3][2];
            //itemBox.ItemsSource = dt.DefaultView;
            conn.Close();
        }

        private void choiceFirst_Click(object sender, RoutedEventArgs e)
        {
            choiceA++;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
           string strSql = "update item_table set itemChoice = '"+choiceA.ToString()+"' where itemContent = '" + itemContentA + "'and TopicID = '"+ themeID.ToString()+"'";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            if (comm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("您已将票投给" + itemContentA);
            }
            else
            {
                MessageBox.Show("Something goes wrong!");
            }
            conn.Close();
            this.Close();
        }

        private void choiceSecond_Click(object sender, RoutedEventArgs e)
        {
            choiceB++;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "update item_table set itemChoice = '" + choiceB + "' where itemContent = '" + itemContentB + "' and TopicID = '"+themeID.ToString()+"'";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            if (comm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("您已将票投给" + itemContentB);
            }
            else
            {
                MessageBox.Show("Something goes wrong!");
            }
            conn.Close();
            this.Close();
        }

        private void choiceThird_Click(object sender, RoutedEventArgs e)
        {
            choiceC++;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "update item_table set itemChoice = '" + choiceC + "' where itemContent = '" + itemContentC + "' and TopicID = '" + themeID.ToString() + "'";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            if (comm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("您已将票投给" + itemContentC);
            }
            else
            {
                MessageBox.Show("Something goes wrong!");
            }
            conn.Close();
            this.Close();
        }

        private void choiceFourth_Click(object sender, RoutedEventArgs e)
        {
            choiceD++;
            MySqlConnection conn = ConnectDatabase();
            conn.Open();
            string strSql = "update item_table set itemChoice = '" + choiceD + "' where itemContent = '" + itemContentD + "' and TopicID = '" + themeID.ToString() + "'";
            MySqlCommand comm = new MySqlCommand(strSql, conn);
            if (comm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("您已将票投给" + itemContentD);
            }
            else
            {
                MessageBox.Show("Something goes wrong!");
            }
            conn.Close();
            this.Close();
        }
    }
}
