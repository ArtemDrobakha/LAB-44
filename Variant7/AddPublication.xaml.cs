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
    /// Interaction logic for AddPublication.xaml
    /// </summary>
    public partial class AddPublication : Window
    {
        List<Student> list2 = new List<Student>();
        Research r2;
        Publication p;
        public AddPublication(List<Student> list, Research r)
        {
            InitializeComponent();
            list2 = list;
            r2 = r;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combobox.ItemsSource = Enum.GetValues(typeof(NaukoviDosiagnennya)).Cast<NaukoviDosiagnennya>();
            combobox.SelectedIndex = 0;
            foreach (var item in list2)
            {
                listBox.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list2.Add(new Student(tb1.Text, tb2.Text, Convert.ToInt32(tb3.Text)));
            listBox.Items.Add(list2[list2.Count - 1]);
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int x2 = listBox.SelectedIndex;

            if (x2 != -1)
            {
                NaukoviDosiagnennya dosiagnennya = (NaukoviDosiagnennya)combobox.SelectedIndex;
                p = new Publication(list2[listBox.SelectedIndex], dosiagnennya);
                r2.AddPublication(p);
                listBox.Items.RemoveAt(x2);
            }
            else
            {
                MessageBox.Show("Choose student");
            }
        }
    }
}
