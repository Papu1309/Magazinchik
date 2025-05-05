using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин.Datagrid
{
    public class Spicok : INotifyPropertyChanged
    {
        private string _name;
        private int _price;
        private string _foto;
        private bool _isSelected;

        // Название товара
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name)); // Уведомление об изменении
            }
        }

        // Цена товара
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        // Путь к изображению
        public string Foto
        {
            get { return _foto; }
            set
            {
                _foto = value;
                OnPropertyChanged(nameof(Foto));
            }
        }

        // Флаг выбора товара (для корзины)
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        // Реализация INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
