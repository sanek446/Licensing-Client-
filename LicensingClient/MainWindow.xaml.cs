using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LicensingClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string theEmail;
        string thePassword;
        private static System.Timers.Timer aTimer;

        public MainWindow()
        {
            InitializeComponent();
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogOut();
        }

        void LogOut()
        {
            LicensingService.LicensingServiceClient proxy = new LicensingClient.LicensingService.LicensingServiceClient();

            bool result = proxy.WCFLogout(theEmail, thePassword);
            if (result == true)
            {
                MessageBox.Show("Log out successfully");
                theEmail = "";
                thePassword = "";
            }
            else
                MessageBox.Show("Log out unsuccessfully");
        }

        void Check(object source, ElapsedEventArgs e)
        {
            if ((theEmail == "") || (thePassword == ""))
                    return;

            LicensingService.LicensingServiceClient proxy = new LicensingClient.LicensingService.LicensingServiceClient();

            //return values isOK (bool), CanUse (bool), Trial (bool), NumberOfDays (int), Active (bool)

            var result = proxy.WCFLogin(theEmail, thePassword);

            //Normal
            if (result.Item1 == true)
                MessageBox.Show("Check in successfully at: " + DateTime.Now.ToString());
            else
            {
                MessageBox.Show("Check in unsuccessfully. Please, try again");
                return;
            }

            //Can Use
            if (result.Item2 == false)
            {
                MessageBox.Show("You cannot use this serial number. App will be closed");
                CloseApp();
                return;
            }

            //Active
            if (result.Item5 == true)
            {
                MessageBox.Show("You already login. Try later. App will be closed");
                CloseApp();
                return;
            }

            //Trial
            if (result.Item3 == true)
            {
                if (result.Item4 == 0)
                {
                    MessageBox.Show("Your trial period is expired. App will be closed");
                    CloseApp();
                    return;
                }
                MessageBox.Show("This is trial version, " + result.Item4 + " days left");
            }
        }

        public string CryptPassword(string password)
        {
            // step 1, calculate MD5 hash from input password
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));

            return sb.ToString();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            
            theEmail = emailTextBox.Text;
            thePassword = CryptPassword(passwordTextBox.Password);

            LicensingService.LicensingServiceClient proxy = new LicensingClient.LicensingService.LicensingServiceClient();

            //return values isOK (bool), CanUse (bool), Trial (bool), NumberOfDays (int), Active (bool)

            var result = proxy.WCFLogin(theEmail, thePassword);

            //Normal
            if (result.Item1 == true)
                MessageBox.Show("Log in successfully");
            else
            {
                MessageBox.Show("Log in unsuccessfully. Please, try again");
                return;
            }

            //Can Use
            if (result.Item2 == false)
            {
                MessageBox.Show("You cannot use this serial number. App will be closed");
                CloseApp();
                return;
            }

            //Active
            if (result.Item5 == true)
            {
                MessageBox.Show("You already login. Try later. App will be closed");
                CloseApp();
                return;
            }

            //Trial
            if (result.Item3 == true)
            {
                if (result.Item4 == 0)
                {
                    MessageBox.Show("Your trial period is expired. App will be closed");
                    CloseApp();
                    return;
                }
                MessageBox.Show("This is trial version, " + result.Item4 + " days left");
            }


            //=====TIMER if login is OK
            // Create a timer with a 30 second interval.
            aTimer = new System.Timers.Timer(30000); //???

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(Check);

            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 30000; //???
            aTimer.Enabled = true;

            GC.KeepAlive(aTimer);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (newPassword.Password != newConfirmPassword.Password)
            {
                MessageBox.Show("New password and Confirm. password are not equal");
                return;
            }

            if (emailTextBox.Text == "")
                MessageBox.Show("Fill email");

            if (oldPassword.Password == "")
                MessageBox.Show("Fill old password");

            if (newPassword.Password == "")
                MessageBox.Show("Fill new password");

            LicensingService.LicensingServiceClient proxy = new LicensingClient.LicensingService.LicensingServiceClient();

            bool result = proxy.WCFChangePassword(theEmail, CryptPassword(oldPassword.Password), CryptPassword(newPassword.Password));
            if (result == true)
            {
                MessageBox.Show("Password changed successfully.");                
                thePassword = CryptPassword(newPassword.Password);
            }
            else
                MessageBox.Show("Password changed unsuccessfully. Check old password");
        }

        public void CloseApp()
        {
            LogOut();
            Environment.Exit(0);            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox1.Password != confPasswordTextBox1.Password)
            {
                MessageBox.Show("New password and Confirm. password are not equal");
                return;
            }

            if (emailTextBox.Text == "")
                MessageBox.Show("Fill email");

            if (newEmailTextBox.Text == "")
                MessageBox.Show("Fill new email");

            if (passwordTextBox1.Password == "")
                MessageBox.Show("Fill password");

            LicensingService.LicensingServiceClient proxy = new LicensingClient.LicensingService.LicensingServiceClient();

            bool result = proxy.WCFChangeEmail(theEmail, newEmailTextBox.Text, CryptPassword(passwordTextBox1.Password));
            if (result == true)
            {
                MessageBox.Show("Email changed successfully.");
                theEmail = newEmailTextBox.Text;
            }
            else
                MessageBox.Show("Email changed unsuccessfully");
        }
    }
}
