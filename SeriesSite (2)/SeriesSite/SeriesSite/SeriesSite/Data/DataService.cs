using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriesSite.Data
{
    public class DataService : IDataService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DataService> _logger;
        public DataService(ApplicationDbContext context, ILogger<DataService> logger)
        {
            _logger = logger;
            _context = context;
        }
        public List<Serial> GetSerials()
        {
            var serials = (from s in _context.Serials
                           select s).ToList();
            return serials;
        }
        public List<Serial> GetSerialInfo(int serialId)
        {
            var serials = (from s in _context.Serials
                           where s.Id == serialId
                           select s).ToList();
            return serials;
        }

        public List<string> GetSerialImages(int serialId)
        {
            var images = (from image in _context.Images
                          where image.SerialId == serialId
                          select image.Source).ToList();
            return images;
        }

        public List<string> GetSerialsImages()
        {
            var images = (from image in _context.Images
                          select image.Source).ToList();
            return images;
        }
        public bool AddSeries(string Name, string OriginalName, int Year, string Country, string Genre, string Producer, string Budget, string Premiere,
            string Age, string Duration, string TotalTime, string Rating, string description)
        {
            bool check = false;
            Serial newSerial = new Serial
            {
                Name = Name,
                Age = Age,
                Budget = Budget,
                Country = Country,
                Duration = Duration,
                Genre = Genre,
                OriginalName = OriginalName,
                Premiere = Premiere,
                Producer = Producer,
                Rating = Rating,
                TotalTime = TotalTime,
                Year = Year,
                Description = description
            };

            try
            {
                _context.Serials.Add(newSerial);
                _context.SaveChanges();
                _logger.LogInformation("Запись в БД успешно добавлена.");
                check = true;
            }
            catch (Exception e)
            {
                _logger.LogInformation("Запись в БД не добавлена.");
            }
            if (check)
            {
                var sr = (from s in _context.Serials
                          where s.Name == Name
                          select s).ToList();
                int idPlant = sr[0].Id;
                Images img1 = new Images { SerialId = idPlant, Source = "/Images/newSerial.png" };
                try
                {
                    _context.Images.Add(img1);
                    _context.SaveChanges();
                    _logger.LogInformation("Запись в БД успешно добавлена.");
                    return true;
                }
                catch (Exception e)
                {
                    _logger.LogInformation("Запись в БД не добавлена.");
                }
            }
            return false;
        }
        public List<Serial> GetFilteredSerials(List<string> genre, string country)
        {
            if (genre.Count == 0)
            {
                if (country != "Выбрать страну")
                {
                    var serials = (from s in _context.Serials
                                   where (s.Country == country)
                                   select s).ToList();
                    return serials;
                }
                else
                {
                    var serials = (from s in _context.Serials
                                   select s).ToList();
                    return serials;
                }
            }
            else
            {
                if (country != "Выбрать страну")
                {
                    var serials = (from s in _context.Serials
                                   where (s.Country == country) && (genre.Contains(s.Genre))
                                   select s).ToList();
                    return serials;
                }
                else
                {
                    var serials = (from s in _context.Serials
                                   where (genre.Contains(s.Genre))
                                   select s).ToList();
                    return serials;
                }
            }
        }
        private bool IntToBool(int a)
        {
            if (a == 1) return true;
            return false;
        }



    }
}
