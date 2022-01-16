using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppL14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Мороженое Oreo",
                ProductPrice = 345,
                Category= ProductCategory.Food,
                ProductImage = "Data/Oreo.png"
            }) ;
            products.Add(new Product()
            {
                ProductName = "Мороженое M&M's",
                ProductPrice = 418,
                Category = ProductCategory.Food,
                ProductImage = "Data/Mms.png"
            });
            products.Add(new Product()
            {
                ProductName = "Анализатор воздуха Xiaomi Test Xiaofei 4-in-1 Monitor",
                ProductPrice = 6490,
                Category = ProductCategory.Tech,
                ProductImage = "Data/Analizator.png"
            });
            products.Add(new Product()
            {
                ProductName = "Робот-пылесос Xiaomi Mi Robot Vacuum Mop",
                ProductPrice = 18760,
                Category = ProductCategory.Tech,
                ProductImage = "Data/Robot.png"
            });
            ProductList.ItemsSource = products;
        }
    }
}
