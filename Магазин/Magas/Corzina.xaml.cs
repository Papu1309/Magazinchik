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
using Магазин.Datagrid;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Corzina.xaml
    /// </summary>
    public partial class Corzina : Window
    {
        public List<Spicok> SelectedProducts { get; }
        public int TotalPrice => SelectedProducts.Sum(p => p.Price);

        public Corzina(IEnumerable<Spicok> selectedProducts)
        {
            InitializeComponent();
            SelectedProducts = selectedProducts.ToList();
            DataContext = this; // Привязка данных к текущему окну
        }

        // Переход к оплате
        private void ProceedToPayment_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow nw = new NavigationWindow();
            nw.Content = new Doelen();
            nw.ShowDialog();
        }

        // Реализация INotifyPropertyChanged для обновления суммы
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
