
using System.Windows;

namespace PMS
{
    /// <summary>
    /// Interaction logic for DeleteCustomer.xaml
    /// </summary>
    public partial class DeleteCustomer : Window
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {
            string deletebuttonclickid=deleteid.Text;
            Window1 w1=new Window1();
            foreach(Customer customer in w1.customers)
            {
                if (customer._id.Equals(deletebuttonclickid))
                {
                    w1.customers.Remove(customer);
                    MessageBox.Show("deleted");
                    break;
                }
                    
            }
            this.Hide();
            w1.Show();

        }
    }
}
