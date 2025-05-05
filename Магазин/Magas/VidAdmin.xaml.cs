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
using Магазин.Windows;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для VidAdmin.xaml
    /// </summary>
    public partial class VidAdmin : Page
    {
        // Конструктор класса
        public VidAdmin()
        {
            InitializeComponent(); // Инициализация компонентов XAML
            DataContext = MainViewModel.Instance; // Привязка к общему экземпляру ViewModel
        }

        // Обработчик кнопки "Удалить"
        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Проверка: выбран ли товар для удаления
            if (MainViewModel.Instance.SelectedSpicok != null)
            {
                // Вызов метода удаления из ViewModel
                MainViewModel.Instance.RemoveSpicok(MainViewModel.Instance.SelectedSpicok);
            }
        }

        // Обработчик кнопки "Добавить"
        private void AddButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Создание нового товара с параметрами по умолчанию
            var newItem = new Spicok
            {
                Name = "Новый товар",
                Price = 0,
                Foto = "/Photo/default.jpg"
            };

            // Добавление товара в коллекцию через ViewModel
            MainViewModel.Instance.AddSpicok(newItem);
        }

        // Обработчик двойного клика для редактирования
        private void DataGridRow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Открытие окна редактирования
            var editWindow = new Windows.EditWindow(MainViewModel.Instance.SelectedSpicok);
            editWindow.ShowDialog(); // Модальное окно
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel vm && vm.SelectedSpicok != null)
            {
                // Открытие окна редактирования
                var editWindow = new EditWindow(vm.SelectedSpicok);
                editWindow.ShowDialog();

            }
        }
    }
}