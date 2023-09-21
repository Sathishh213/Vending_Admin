using log4net;
using MaterialDesignThemes.Wpf;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using Vending_Admin.Helpers;

namespace Vending_Admin
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Access acc = new Access();
        DataTable dt = new DataTable();string cmd = "";
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Password;
            cmd = @"select * from User_Details where User_Name='"+userName+"' and Password='"+ password + "'";
            dt = acc.GetTable(cmd);
            if (dt.Rows.Count > 0) 
            {
                //DisplayMsg("Authenticated Successfully!!");
                frmReport frm = new frmReport();
                this.Hide();
                frm.Show();
            }
            else
            {
                DisplayMsg("Invalid Credentials!!!");
            }
        }

        public async void DisplayMsg(string msg)
        {
            try
            {
                var sampleMessageDialog = new Dialog { Message = { Text = msg } };
                await DialogHost.Show(sampleMessageDialog, "frmLoginDialog");
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Password = string.Empty;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.Show();
        }
    }
}
