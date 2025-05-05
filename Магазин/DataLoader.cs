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
                    new Spicok { Name = "Робот РУ Mobicaro Собака", Price = 1990, Foto = "/Photo/собака.jpg" },
                    new Spicok { Name = "Конструктор LEGO DUPLO ", Price = 3071, Foto = "/Photo/пазл.jpg" },
                    new Spicok { Name = "Подъемный кран РУ Mobicaro", Price = 3499, Foto = "/Photo/кран.jpg" },
                    new Spicok { Name = "Бластер Zuru XSHOT", Price = 3400, Foto = "/Photo/бластер.jpg" },
                    new Spicok { Name = "Игровой набор Hot Wheels", Price = 2222, Foto = "/Photo/хотфилс.jpg" },
                    new Spicok { Name = "Фигурка Zuru Pets ", Price = 2345, Foto = "/Photo/питомцы.jpg" },
                    new Spicok { Name = "Игрушка развивающая alilo Умный зайка", Price = 3798, Foto = "/Photo/зайка.jpg" },
                    new Spicok { Name = "Фигурка BalaToys Магма", Price = 1212, Foto = "/Photo/фигурка.jpg" },
                    new Spicok { Name = "Кукла мини L.O.L. Surprise", Price = 2999, Foto = "/Photo/лол.jpg" },
                    new Spicok { Name = "Кукла модельная Monster High", Price = 4999, Foto = "/Photo/монстр.jpg" },
                    new Spicok { Name = "Конструктор LEGO Star Wars Сокол", Price = 82999, Foto = "/Photo/сокол лега.jpg" },
                    new Spicok { Name = "Каталка Kreiss Mercedes Benz", Price = 1195, Foto = "/Photo/каталка.jpg" },
                    new Spicok { Name = "Конструктор LEGO Minecraft Домик", Price = 585, Foto = "/Photo/лего свиньи.jpg" },
                    new Spicok { Name = "Конструктор LEGO Minecraft The Sword", Price = 5599, Foto = "/Photo/сворд лего.jpg" },
                    new Spicok { Name = "Настольная игра Bondibon ", Price = 500, Foto = "/Photo/настолка.jpg" },
                    new Spicok { Name = "Настольная игра Bondibon ПЕРВОКЛАССНЫЙ ШОФЁР", Price = 149, Foto = "/Photo/настолка шофер.jpg" },
                    new Spicok { Name = "Настольная игра Bondibon Времена года", Price = 149, Foto = "/Photo/времена года.jpg" },
                    new Spicok { Name = "Настольная игра Hasbro Games Монополия", Price = 1500, Foto = "/Photo/монополия.jpg" },
                    new Spicok { Name = "Игра настольная The Purple Cow магнитная Гонки", Price = 300, Foto = "/Photo/настолка гонка.jpg" },
                    new Spicok { Name = "Пистолет водный Yiwu Yofun Trading Co", Price = 1999, Foto = "/Photo/водный пистолет.jpg" }
                };
            }
        }
    }
}
