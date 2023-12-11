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

namespace _213064_lab11eg3
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
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Concat
        {
            static void Main(string[] args)
            {
                Pet[] cats = GetCats();
                Pet[] dogs = GetDogs();
                IEnumerable<string> query = cats.Select(cat=> cat.Name).Concat(dogs.Select(dog
                => dog.Name));

                foreach (var e in query)
                {
                    Console.WriteLine("Name = {0} ", e);
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            } 

            static Pet[] GetCats()
            {
                Pet[] cats = { new Pet { Name = "Barley", Age = 8 },
                new Pet { Name = "Boots", Age = 4 },
                new Pet { Name = "Whiskers", Age = 1 } };
                return cats;
            }

            static Pet[] GetDogs()
            {
                Pet[] dogs = { new Pet { Name = "Bounder", Age = 3 },
                new Pet { Name = "Snoopy", Age = 14 },
                new Pet { Name = "Fido", Age = 9 } };
                return dogs;
            }
        }
    }
}
