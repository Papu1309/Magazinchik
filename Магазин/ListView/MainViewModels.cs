using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using Магазин.Datagrid;
using Магазин.InternetMagazinIgruchec;
using Магазин.Utils;
using Магазин.Windows;

namespace Магазин.ListView
{
    public class MainViewModel
    {
        public class MainViewModel : INotifyPropertyChanged
        {
            // Коллекция товаров с автоматическим обновлением UI
            private ObservableCollection<Spicok> _spicoks;
            public ObservableCollection<Spicok> Spicoks
            {
                get => _spicoks;
                set
                {
                    _spicoks = value;
                    OnPropertyChanged(nameof(Spicoks));
                }
            }

            // Выбранный товар (для редактирования/удаления)
            private Spicok _selectedSpicok;
            public Spicok SelectedSpicok
            {
                get => _selectedSpicok;
                set
                {
                    _selectedSpicok = value;
                    OnPropertyChanged(nameof(SelectedSpicok));
                }
            }

            // Команды
            public ICommand AddCommand { get; }
            public ICommand DeleteCommand { get; }
            public ICommand EditCommand { get; }

            public MainViewModel()
            {
                // Загрузка начальных данных
                Spicoks = new ObservableCollection<Spicok>(DataLoader.LoadSpicoles());

                // Инициализация команд
                AddCommand = new RelayCommand(AddSpicok);
                DeleteCommand = new RelayCommand(DeleteSpicok);
                EditCommand = new RelayCommand(EditSpicok);
            }

            // Добавление нового товара
            private void AddSpicok()
            {
                var newSpicok = new Spicok
                {
                    Name = "Новый товар",
                    Price = 0,
                    Foto = "/Photo/default.jpg"
                };
                Spicoks.Add(newSpicok);
                SelectedSpicok = newSpicok;
            }

            // Удаление товара
            private void DeleteSpicok()
            {
                if (SelectedSpicok != null)
                {
                    Spicoks.Remove(SelectedSpicok);
                }
            }

            // Редактирование товара
            private void EditSpicok()
            {
                if (SelectedSpicok == null) return;

                // Открытие окна редактирования
                var editWindow = new EditWindow(SelectedSpicok);
                if (editWindow.ShowDialog() == true)
                {
                    // Обновление данных через рефлексию
                    var edited = editWindow.EditedSpicok;
                    SelectedSpicok.Name = edited.Name;
                    SelectedSpicok.Price = edited.Price;
                    SelectedSpicok.Foto = edited.Foto;
                }
            }

            // Реализация INotifyPropertyChanged
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
