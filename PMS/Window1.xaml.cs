using System.Windows;
using System.Windows.Controls;
using System;
namespace PMS
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string name, string address, string phoneno, string symptoms, string total, DatePicker dateofvisit)
        {
            string NAME, ADDRESS, PHONENO, SYMPTOMS, TOTAL; DatePicker datepicker;
            NAME = name;
            ADDRESS = address;
            PHONENO = phoneno;
            SYMPTOMS = symptoms;
            TOTAL = total;
            datepicker = dateofvisit;
        }
        private void add_customer_click(object sender, RoutedEventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.Owner = this;
            this.Hide();
            a.Show();
            //this.Close(); //add at end
        }
    }
}