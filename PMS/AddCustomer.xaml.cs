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
using System.Windows.Shapes;

namespace PMS
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            if (gridcontrol.Children
        .OfType<TextBox>()
        .Any(tb => string.IsNullOrEmpty(tb.Text)))
                MessageBox.Show("Please check all textboxes");
            else
            {
                Window1 w = new Window1();
                this.Hide();
                //send list to the window1.xaml.cs for converting into listboxitem. Also, override the ToString() of the customer class;
                //update dashboard
                w.updateDashboardClick(new Customer(id.Text, customername.Text, Street.Text, city.SelectedValue.ToString(), state.SelectedValue.ToString(), Phoneno.Text, Symptoms.Text,
                    Total.Text, datepick.Text));
                w.Show();
            }
        }
        
    }
}