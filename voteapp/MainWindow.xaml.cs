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
using MySql.Data.MySqlClient;
namespace voteapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string useraccount;
        string userpassword;
        string username;
        string usertext;
        
        public MainWindow(string account, string password, string name, string text)
        {
            useraccount = account;
            userpassword = password;
            username = name;
            usertext = text;
            InitializeComponent();
        }
        public MainWindow() 
        {
            InitializeComponent();    
        }
        //Connect to the mysql database
           
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //获取登录信息
            useraccount = this.uText.Text;      //用户名
            userpassword = this.pText.Password;         //用户密码
            //验证数据（非空）
            if (useraccount.Equals("") || userpassword.Equals(""))
            {
                MessageBox.Show("账号或密码不能为空！");
            }
            else
            {
                String connetStr = "server=127.0.0.1;port=3306;user=root;password=yyp5689;database=vote;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                try
                {
                    //打开数据库
                    conn.Open();    
                    //Mysql 查询语句
                    string strSql = "select count(*) from user_table where userAccount = '"+useraccount+"' and userPassword = '"+userpassword+"'";
                    MySqlCommand comm = new MySqlCommand(strSql, conn);
                    //判断是否登录成功
                    if(Convert.ToInt32(comm.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("登陆成功！");
                        Window2 window2 = new Window2(useraccount,userpassword,username, usertext);
                        window2.Owner = this;
                        window2.Show();
                        //跳转至主页面
                        this.Hide();
                    }
                    //账号和密码验证错误，提示错误
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                    
                }
                //提示数据库错误
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //关闭数据库
                    conn.Close();
                }
            }
        }


        private void pText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
