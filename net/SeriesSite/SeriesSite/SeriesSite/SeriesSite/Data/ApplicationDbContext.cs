using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Serial> Serials { get; set; }
        public DbSet<Images> Images { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Serial>().HasData(
                new Serial
                {
                    Id = 1,
                    Name = "Ход Королевы",
                    OriginalName = "The Queen's Gambit",
                    Year = 2020,
                    Country = "США",
                    Genre = "Драма",
                    Producer = "Скотт Фрэнк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                },
                new Serial
                {
                    Id = 2,
                    Name = "Тьма",
                    OriginalName = "Dark",
                    Year = 2017,
                    Country = "Германия",
                    Genre = "Триллер",
                    Producer = "Баран бо Одар",
                    Budget = "-",
                    Premiere = "1 декабря 2017",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "1 день 6 минут",
                    Rating = "8,1",
                    Description = "В небольшом немецком городе Винден, расположенном рядом с атомной электростанцией, пропадает мальчик, \nи четыре семьи оказываются вовлеченными в его поиск."
                },
                new Serial
                {
                    Id = 3,
                    Name = "Стыд",
                    OriginalName = "Skam",
                    Year = 2015,
                    Country = "Норвегия",
                    Genre = "Мелодрама",
                    Producer = "Жюли Андем",
                    Budget = "-",
                    Premiere = "25 сентября 2015",
                    Age = "18+",
                    Duration = "30 минут",
                    TotalTime = "19 часов 53 минуты",
                    Rating = "8,1",
                    Description = "Сериал о жизни пяти подруг из старшей школы «Hartvig Nissens» в Осло."
                },
                new Serial
                {
                    Id = 4,
                    Name = "Годы",
                    OriginalName = "Squid Game",
                    Year = 2021,
                    Country = "Южная Корея",
                    Genre = "Драма",
                    Producer = "Хван Дон-хёк",
                    Budget = "$21 000 000",
                    Premiere = "17 сентября 2021",
                    Age = "18+",
                    Duration = "50 минут",
                    TotalTime = "476 минут",
                    Rating = "7,6",
                    Description = "Сон Ги-хун уже немолод, разведен, по уши погряз в долгах и сидит на шее у старенькой матери."
                },
                new Serial
                {
                    Id = 5,
                    Name = "Волчонок",
                    OriginalName = "Squid Game",
                    Year = 2021,
                    Country = "Южная Корея",
                    Genre = "Триллер",
                    Producer = "Хван Дон-хёк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                },
                new Serial
                {
                    Id = 6,
                    Name = "Отбросы",
                    OriginalName = "Squid Game",
                    Year = 2021,
                    Country = "Южная Корея",
                    Genre = "Драма",
                    Producer = "Скотт Фрэнк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                },
                new Serial
                {
                    Id = 7,
                    Name = "Хор",
                    OriginalName = "The Queen's Gambit",
                    Year = 2021,
                    Country = "США",
                    Genre = "Комедия",
                    Producer = "Скотт Фрэнк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                },
                new Serial
                {
                    Id = 8,
                    Name = "Чернобыль",
                    OriginalName = "The Queen's Gambit",
                    Year = 2019,
                    Country = "США",
                    Genre = "Мелодрама",
                    Producer = "Скотт Фрэнк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                },
                new Serial
                {
                    Id = 9,
                    Name = "Игра престолов",
                    OriginalName = "Gane of thrones",
                    Year = 2019,
                    Country = "США",
                    Genre = "Драма",
                    Producer = "Скотт Фрэнк",
                    Budget = "-",
                    Premiere = "23 октября 2020",
                    Age = "18+",
                    Duration = "60 минут",
                    TotalTime = "6 часов 18 минут",
                    Rating = "8,3",
                    Description = "Штат Кентукки, 1957 год. \nПосле смерти матери 9-летняя Элизабет Хармон остаётся сиротой и отправляется в католический приют. \nВ этом заведении детям регулярно дают «витамины», и по совету другой подопечной Бет оставляет зелёные капсулы на ночь."
                }
                );
            builder.Entity<Images>().HasData(
                new Images
                {
                    Id = 10,
                    Source = "/Images/001.jpg",
                    SerialId = 1
                },
                new Images
                {
                    Id = 11,
                    Source = "/Images/002.jpg",
                    SerialId = 2
                },
                new Images
                {
                    Id = 12,
                    Source = "/Images/003.jpg",
                    SerialId = 3
                },
                new Images
                {
                    Id = 13,
                    Source = "/Images/004.jpg",
                    SerialId = 4
                },
                new Images
                {
                    Id = 14,
                    Source = "/Images/005.jpg",
                    SerialId = 5
                },
                new Images
                {
                    Id = 15,
                    Source = "/Images/006.jpg",
                    SerialId = 6
                },
                new Images
                {
                    Id = 16,
                    Source = "/Images/007.jpg",
                    SerialId = 7
                },
                new Images
                {
                    Id = 17,
                    Source = "/Images/008.jpg",
                    SerialId = 8
                },
                new Images
                {
                    Id = 18,
                    Source = "/Images/009.jpg",
                    SerialId = 9
                }
                );
        }

    }
    public class Serial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }
        public string Budget { get; set; }
        public string Premiere { get; set; }
        public string Age { get; set; }
        public string Duration { get; set; }
        public string TotalTime { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
    }

    public class Images
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public int SerialId { get; set; }
        public Serial Serial { get; set; }
    }
}
