using log4net;
using MaterialDesignThemes.Wpf;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for frmRegister.xaml
    /// </summary>
    public partial class frmRegister : Window
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        Access acc = new Access();
        string cmd = string.Empty; string ToAddress = string.Empty;
        System.Data.DataTable dt = new System.Data.DataTable();
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Password) && !string.IsNullOrEmpty(txtConfirmPassword.Password))
            {
                string userName = txtUserName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Password;
                string confirmpassword = txtPassword.Password;
                cmd = @"select * from User_Details where User_Name='" + userName + "' OR Email_Address='" + email +"'";
                dt = acc.GetTable(cmd);

                if (dt.Rows.Count > 0)
                {
                    DisplayMsg("Username or Email Already Exists!!");
                }
                else if (!IsvalidEmailFormat(email))
                {
                    DisplayMsg("Invalid Email Format!!");
                }
                else if (password != confirmpassword)
                {
                    DisplayMsg("Passwords doesn't match!!");
                }
                else
                {
                    cmd = @"insert into User_Details(Email_Address ,  User_Name , Password) 
                            values( '" + email + "' , '" + userName + "' , '" + password + "')";
                }

                int exe = Convert.ToInt16(acc.ExecuteCmd(cmd));

                if (exe > 0)
                {
                    ClearFields();
                    DisplayMsg("User Registered Successfully");
                }
                else
                {
                    DisplayMsg("Registration Failed");
                }
            }
            else
            {
                DisplayMsg("All Fields are mandatory!!");
            }
        }

        public async void DisplayMsg(string msg)
        {
            try
            {
                var sampleMessageDialog = new Dialog { Message = { Text = msg } };
                await DialogHost.Show(sampleMessageDialog, "frmRegisterDialog");
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Password = string.Empty;
            txtConfirmPassword.Password = string.Empty;
        }

        private bool IsvalidEmailFormat(string email)
        {
            bool result = false;
            if (email != null)
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(email))
                    result = true;
                else
                    result = false;
            }
            return result;
        }
    }
}
