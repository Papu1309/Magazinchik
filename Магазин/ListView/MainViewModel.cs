using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Магазин.Datagrid;
using Магазин.InternetMagazinIgruchec;
using Магазин.Utils;
using Магазин.Windows;

namespace Магазин.ListView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public static MainViewModel _instance;
        public static MainViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainViewModel();
                }
                return _instance;
            }
        }

        // Коллекция товаров с автоматическим обновлением UI
        private ObservableCollection<Spicok> _spicoks;
        public ObservableCollection<Spicok> Spicoks
        {
            get { return _spicoks; }
            set
            {
                _spicoks = value;
                OnPropertyChanged(nameof(Spicoks));
            }
        }

        // Выбранный товар (для редактирования)
        private Spicok _selectedSpicok;
        public Spicok SelectedSpicok
        {
            get { return _selectedSpicok; }
            set
            {
                _selectedSpicok = value;
                OnPropertyChanged(nameof(SelectedSpicok));
            }
        }

        // Приватный конструктор (синглтон)
        private MainViewModel()
        {
            Spicoks = new ObservableCollection<Spicok>();
            LoadData();
        }

        // Загрузка данных
        public void LoadData()
        {
            Spicoks.Clear();
            foreach (var item in DataLoader.LoadSpicoles())
            {
                Spicoks.Add(item);
            }
        }

        // Добавление товара
        public void AddSpicok(Spicok item)
        {
            Spicoks.Add(item);
        }

        // Удаление товара
        public void RemoveSpicok(Spicok item)
        {
            Spicoks.Remove(item);
        }

        // Реализация INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
