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

namespace WPF_Program_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products;
        public MainWindow()
        {
            InitializeComponent();
            Products = new List<Product>();

            Products.Add(new Product()
            {
                Name = "Картошка",
                Price = 120,
                Category = CategoryTypes.Food,
                Image = "Image/1.jpg"

            });
            Products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 80000,
                Category = CategoryTypes.Tech,
                Image = "Image/2.jpg"

            });
            List1.ItemsSource = Products;
        }
    }
}
