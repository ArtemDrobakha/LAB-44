using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Variant7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Research> researches;
        public List<Student> list = new List<Student>();


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (researches == null)
            {
                MessageBox.Show("List is Empty");
                return;
            }

            listBox.Items.Clear();
            foreach (var item in researches)
            {
                listBox.Items.Add(item.ToShortString());
            }
        }

        private void Button_reserch(object sender, RoutedEventArgs e)
        {
            Research r = new Research();

            AddCustomer w3 = new AddCustomer(list, r);
            if (w3.ShowDialog() == true)
            {  
                listBox.Items.Add(r);
                researches.Add(r);
            }
            else
            {
                MessageBox.Show("Data not saved");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(typeof(List<Research>));
                using (TextReader reader = new StreamReader("settings.xml"))
                {
                    researches = (List<Research>)deSerializer.Deserialize(reader);
                }
                foreach (var item in researches)
                {
                    listBox.Items.Add(item);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("No file with data");
                researches = new List<Research>();

        }
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (researches == null)
            {
                MessageBox.Show("List is Empty");
                return;
            }
            
            listBox.Items.Clear();
            foreach (var item in researches)
            {
                listBox.Items.Add(item);
            }
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
           
            using (var stream = new FileStream("settings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Research>));
                serializer.Serialize(stream, researches);
            }
        }
    }
}
