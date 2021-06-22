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

namespace Variant7
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        List<Student> list2;
        Research r2;
        public AddCustomer(List<Student> list, Research r)
        {
            InitializeComponent();
            list2 = list;
            r2 = r;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer(tb1.Text, tb2.Text, Convert.ToInt32(tb3.Text));
            r2.AddCustomer(c);
            r2.AddDate(datepicker.SelectedDate.Value);
            AddPublication w2 = new AddPublication(list2, r2);
            if (w2.ShowDialog() == true)
            {
                this.DialogResult = true;
            }
        }
    }
}
