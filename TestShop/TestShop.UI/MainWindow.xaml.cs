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
using TestShop.DAL.Services;
using System.Data.Common;

namespace TestShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ProductVM> Products = new List<ProductVM>();
        public ProductService service = new ProductService();
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Mike";

            var products = service.GetProducts();
            Products = products.Select(x => new ProductVM
            {
                Name=x.Name + "M",
                Price=x.Price,
                Category=x.Category,
                Id=x.Id
            }).ToList();
            list_box.ItemsSource = Products;
        }
    }
}
