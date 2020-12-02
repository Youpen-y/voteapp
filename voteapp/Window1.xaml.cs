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
using MySql.Data.MySqlClient;

namespace voteapp
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {

        string registeraccount;
        string registerpassword;
        string registercheck;
        string registername ;
        string registertext;

        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            registeraccount = this.account.Text;
            registerpassword = this.password.Password;
            registercheck = this.check.Password;
            registername = this.nickname.Text;
            registertext = this.yourtext.Text;


            if (registeraccount.Equals("") || registerpassword.Equals(""))
            {
                MessageBox.Show("账号或密码不能为空");
            }
            else if (!registercheck.Equals(registerpassword))
            {
                MessageBox.Show("密码不一致，请重新输入！");
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
                    string strSql = "select count(*) from user_table where userAccount = '"+registeraccount+"'";
                    MySqlCommand comm = new MySqlCommand(strSql, conn);
                    //判断是否已存在帐号
                    if (Convert.ToInt32(comm.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("当前账号已存在，请重新输入！");
                    }
                    else
                    {
                        try {
                            string strInsertSql = "insert into user_table (userAccount, userPassword, userNickname, userText) values ('"+registeraccount+"','"+ registerpassword +"','"+ registername +"','"+ registertext+"')";
                            //string str = "insert into user_table (userAccount, userPassword, userNickname, userText) values ('wj','123','wangjin','noway')";
                            //string strInsertSql = "insert into user_table （userAccount, userPassword, userNickname, userText) value(@registeraccount, @registerpassword, @registername, @registertext)";
                            // string strInsertSql = "insert into user_table （userAccount, userPassword, userNickname, userText) value('wj', '123456' , 'wangjin' , 'don't do that')";
                            MySqlCommand command = new MySqlCommand(strInsertSql, conn);
                            //MySqlCommand command = new MySqlCommand(str, conn);
                            if (command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("账号注册成功");
                            }
                            else
                            {
                                MessageBox.Show("账号注册失败1");
                            }

                        } catch
                        {
                            MessageBox.Show("账号注册失败2");
                        } 
                        
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        { 
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
