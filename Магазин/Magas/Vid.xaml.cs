using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Магазин.Datagrid;
using Магазин.ListView;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class Vid : Page, INotifyPropertyChanged
    {
        private ICollectionView _productsView;
        public ICollectionView ProductsView
        {
            get { return _productsView; }
            set
            {
                _productsView = value;
                OnPropertyChanged(nameof(ProductsView));
            }
        }

        public Vid()
        {
            InitializeComponent();
            DataContext = MainViewModel.Instance;
            ProductsView = CollectionViewSource.GetDefaultView(MainViewModel.Instance.Spicoks);
            ProductsView.Filter = FilterProducts;
            ProductsListView.ItemsSource = ProductsView;
        }

        private bool FilterProducts(object item)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
                return true;

            var product = item as Spicok;
            return product.Name.ToLower().Contains(SearchTextBox.Text.ToLower());
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProductsView.Refresh();
        }

        private void ToCart_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var selectedProducts = MainViewModel.Instance.Spicoks.Where(p => p.IsSelected).ToList();
            if (selectedProducts.Count == 0)
            {
                System.Windows.MessageBox.Show("Выберите товары!");
                return;
            }
            new Magas.Corzina(selectedProducts).Show();
        }

        private void SortByName_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ProductsView.SortDescriptions.Clear();
            ProductsView.SortDescriptions.Add(
                new SortDescription("Name", System.ComponentModel.ListSortDirection.Ascending));
            ProductsView.Refresh();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
