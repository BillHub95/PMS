using System.Windows;
using System.Windows.Controls;
using System;
using System.Linq;
using System.Collections.Generic;
namespace PMS
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //list of customers: initially 2 but added on button press
        //convert everything to lowercase when checking for deletion.
        public List<Customer> customers = new List<Customer>() {
            new Customer(){_id="1", _name="javed", _street="crib", _city="rwp", _state="punjab", _phoneno="923340100321", _symptoms="none", _total="$399",
            _dateentered="2-Dec-2021"},
            new Customer(){_id="2", _name="javed2", _street="crib2", _city="rwp", _state="punjab", _phoneno="923340100321", _symptoms="none", _total="$399",
            _dateentered="2-Dec-2021"}
        };
        public Window1()
        {
            InitializeComponent();
            //this causes the datagrid to display the old data.
            //gridview.ItemsSource = customers;
        }
        private void add_customer_click(object sender, RoutedEventArgs e)
        {
            
            AddCustomer a = new AddCustomer();
            a.Owner = this;
            //show addcustomer page
            a.Show();
            //close this
            this.Hide();
            //don't use this.Close() when it is the owner because it will close all the remaining windows.
            
        }
        private void viewcustomerclick(object sender, RoutedEventArgs e)
        {
            gridview.ItemsSource = customers;
        }
        //assign customer object through this bcz of only click
        public void updateDashboardClick(PMS.Customer customer)
        {

            customers.Add(customer);
            gridview.ItemsSource = customers;
        }
        private void deletecustomer(object sender, RoutedEventArgs e)
        {
            DeleteCustomer delwin = new DeleteCustomer();
            delwin.Show();
            this.Hide();
        }
        private void Updatecustomerclick(object sender , RoutedEventArgs e)
        {
            UpdateCustomer uc = new UpdateCustomer();
            uc.Show();
            this.Hide();
        }
    }
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(string ID, string _NAME, string _STREET, string _CITY, string _STATE, string _PHONENO, string _SYMPTOMS, string _TOTAL, string _DATEENTERED)
        {
            _id = ID;
            _name = _NAME;
            _street = _STREET;
            _city = _CITY;
            _state = _STATE;
            _phoneno = _PHONENO;
            _symptoms = _SYMPTOMS;
            _total = _TOTAL;
            _dateentered = _DATEENTERED;
        }
        //use properties for adding the element to the wpf control
        public string _id { get; set; }
        public string _name { get; set; }
        public string _street { get; set; }
        public string _city { get; set; }
        public string _state { get; set; }
        public string _phoneno { get; set; }
        public string _symptoms { get; set; }
        public string _total { get; set; }
        public string _dateentered { get; set; }
        public override string ToString()
        {
            return _name + "  " + _street + "  " + _city + "  " + _state + "  " + _phoneno + "  " + _symptoms + "  " + _total + "  " + _dateentered;
        }
    }
}