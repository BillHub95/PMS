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

namespace PMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pharmacist> pwdlist = new List<Pharmacist> { new Pharmacist("javed", "password"), new Pharmacist("hamas", "password2") };
        public MainWindow()
        {
            InitializeComponent();
        }
        //login button
        private void button_click(object sender, RoutedEventArgs e)
        {
            if (txtbox.Text.Length == 0 && pwdbox.SecurePassword.Length == 0)
            {
                MessageBox.Show("please enter username and password");
            }
            else if (txtbox.Text.Length != 0 && pwdbox.SecurePassword.Length == 0)
                MessageBox.Show("please enter password");
            else
            {
                byte usernameindex = 0;
                bool usernameflag = false;
                for (byte i = 0; i < pwdlist.Count; i++)
                {//check if user exists
                    if (pwdlist[i].name.Equals(txtbox.Text))
                    {
                        usernameflag = true;
                        usernameindex = i;
                    }
                }
                if (usernameflag == true)
                {//check if password exists
                    if (pwdlist[usernameindex].pwd.Equals(pwdbox.Password))
                    {
                        this.Hide();
                        Window1 window = new Window1();
                        window.WindowStartupLocation = WindowStartupLocation.CenterScreen;//delegate
                        window.Show();
                        //no window.Close() because it closes as soon as it shows the application.
                    }
                    else
                        MessageBox.Show("please enter correct password");
                }
                else//signup
                {
                    MessageBox.Show("Username: \"" + txtbox.Text + "\" does not exist.\nPlease check for typos OR sign up using the \"Signup\" button below");
                }
            }
        }
    }
    class Pharmacist
    {
        public string name;
        public string pwd;
        public Pharmacist(string NAME, string PWD)
        {
            this.name = NAME;
            this.pwd = PWD;
        }
    }
}
