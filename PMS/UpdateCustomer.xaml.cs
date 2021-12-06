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
    /// Interaction logic for UpdateCustomer.xaml
    /// </summary>
    public partial class UpdateCustomer : Window
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            foreach(Customer c in w1.customers)
            {
                if(c._id.Equals(id.Text))
                {
                    w1.customers.Remove(c);

                    MessageBox.Show("updated");
                    w1.updateDashboardClick(new Customer(id.Text, customername.Text, Street.Text, city.SelectedValue.ToString(),
                    state.SelectedValue.ToString(), Phoneno.Text, Symptoms.Text, Total.Text,
                    datepick.Text));
                    break;

                }
                this.Hide();
                w1.Show();
            }
             //&& c._name.Equals(customername.Text) && c._street.Equals(Street.Text) && c._city.Equals(city.SelectedValue.ToString())
             //       && c._state.Equals(state.SelectedValue.ToString()) && c._total.Equals(Total.Text) && c._phoneno.Equals(Phoneno.Text)
             //       && c._symptoms.Equals(Symptoms.Text) && c._dateentered.Equals(datepick.Text)
        }
    }
}
