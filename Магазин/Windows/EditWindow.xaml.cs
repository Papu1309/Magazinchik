using Microsoft.Win32;
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
using Магазин.Datagrid;

namespace Магазин.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Spicok _editingItem; // Редактируемый товар

        public EditWindow(Spicok item)
        {
            InitializeComponent();
            _editingItem = item; // Работаем с оригинальным объектом из MainViewModel
            DataContext = _editingItem; // Привязка данных
        }

        // Выбор изображения
        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Изображения|*.jpg;*.png;*.jpeg"
            };

            if (dialog.ShowDialog() == true)
            {
                _editingItem.Foto = dialog.FileName; // Путь обновится через привязку
            }
        }

        // Сохранение изменений
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Валидация цены (пример)
            if (_editingItem.Price < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной!");
                return;
            }

            DialogResult = true;
            Close();
        }

        // Отмена
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
