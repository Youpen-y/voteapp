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
    /// Window7.xaml 的交互逻辑
    /// </summary>
    public partial class Window7 : Window
    {
        string themeID;
        string connetStr;
        string itemContentA;
        string itemContentB;
        string itemContentC;
        string itemContentD;
        string choiceA;
        string choiceB;
        string choiceC;
        string choiceD;
        public Window7(string ID)
        {
            themeID = ID;
            InitializeComponent();
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


            A.Text = itemContentA;
            B.Text = itemContentB;
            C.Text = itemContentC;
            D.Text = itemContentD;

            choiceA = ds.Tables[0].Rows[0][3].ToString();
            choiceB = ds.Tables[0].Rows[1][3].ToString();
            choiceC = ds.Tables[0].Rows[2][3].ToString();
            choiceD = ds.Tables[0].Rows[3][3].ToString();

            aNum.Text = choiceA;
            bNum.Text = choiceB;
            cNum.Text = choiceC;
            dNum.Text = choiceD;
        }
        private MySqlConnection ConnectDatabase()
        {
            connetStr = "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            return conn;
        }
    }
}
