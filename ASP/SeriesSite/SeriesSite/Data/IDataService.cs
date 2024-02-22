using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriesSite.Data
{
    public interface IDataService
    {
        List<Serial> GetSerials();
        List<string> GetSerialImages(int plantId);
        List<string> GetSerialsImages();
        List<Serial> GetSerialInfo(int plantId);
        bool AddSeries(string Name, string OriginalName, int Year, string Country, string Genre, string Producer, string Budget, string Premiere,
            string Age, string Duration, string TotalTime, string Rating, string description);
        List<Serial> GetFilteredSerials(List<string> genre, string country);
    }
}
