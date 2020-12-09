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
    /// Window6.xaml 的交互逻辑
    /// </summary>
    public partial class Window6 : Window
    {
        int themeID;
        int choiceA;
        int choiceB;
        int choiceC;
        int choiceD;
        string AContent;
        string BContent;
        string CContent;
        string DContent;
        public Window6(int ID)
        {
            InitializeComponent();
        }
    }
}
