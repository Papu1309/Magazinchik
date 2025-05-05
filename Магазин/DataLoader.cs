using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Магазин.Datagrid;

namespace Магазин
{
    namespace InternetMagazinIgruchec
    {
        public static class DataLoader
        {
            public static List<Spicok> LoadSpicoles()
            {
                return new List<Spicok>
                {
                    new Spicok { Name = "Pogow из сердца", Price = 625, Foto = "/Photo/Родом из сердца.jpg" },
                    new Spicok { Name = "Страшный дом", Price = 689, Foto = "/Photo/Странный дом.jpg" },
                    new Spicok { Name = "За спиной", Price = 759, Foto = "/Photo/За спиной.jpg" },
                    new Spicok { Name = "Атомные приемки", Price = 899, Foto = "/Photo/Атомные привычки.jpg" },
                    new Spicok { Name = "Газдировки менеджера", Price = 1118, Foto = "/Photo/Татуировки менеджера.jpg" },
                    new Spicok { Name = "Пять языков любви", Price = 487, Foto = "/Photo/Пять языков любви.jpg" },
                    new Spicok { Name = "Игры королей", Price = 781, Foto = "/Photo/Игры королей.jpg" },
                    new Spicok { Name = "Записи много врача", Price = 541, Foto = "/Photo/Записи юного врача.jpg" },
                    new Spicok { Name = "Бесцедливый", Price = 428, Foto = "/Photo/Еженедельник.jpg" },
                    new Spicok { Name = "Двадцать шестой", Price = 587, Foto = "/Photo/Двадцать шестой.jpg" },
                    new Spicok { Name = "Двоющую море", Price = 777, Foto = "/Photo/Донецкое море.jpg" },
                    new Spicok { Name = "Пластиковый океан", Price = 1195, Foto = "/Photo/Пластиковый океан.jpg" },
                    new Spicok { Name = "Клиника в Гоблинском переулке", Price = 585, Foto = "/Photo/Клиника в Гоблинском переулке.jpg" },
                    new Spicok { Name = "Семнадцатый", Price = 1655, Foto = "/Photo/Семнадцатый.jpg" }
                };
            }
        }
    }
}
