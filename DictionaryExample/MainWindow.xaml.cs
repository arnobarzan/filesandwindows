using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DictionaryExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, Course> _lookup =
                     new Dictionary<string, Course>();

        public MainWindow()
        {
            InitializeComponent();

            Course c1 = new Course(".NET Essentials", "Kris Hermans", 6);
            Course c2 = new Course("Logisch & Algoritmisch Denken", "Nele Custers", 7);
            Course c3 = new Course("Webdesign", "Rita Lambrechts", 4);

            _lookup.Add(c1.Name, c1);
            _lookup.Add(c2.Name, c2);
            _lookup.Add(c3.Name, c3);

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (keyTextBox.Text != "")
            {
                string key = keyTextBox.Text;
                if (_lookup.ContainsKey(key))
                {
                    Course course = _lookup[key];

                    resultTextBox.Clear();
                    resultTextBox.AppendText($"Vakgegevens voor {key}\n\n");
                    resultTextBox.AppendText($"Docent: {course.Teacher}\n");
                    resultTextBox.AppendText($"Uren: {course.Hours}");
                }
                else
                {
                    MessageBox.Show($"Vak: {key} niet gevonden.");
                }
            }
        }

    }
}