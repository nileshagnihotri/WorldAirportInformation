using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Microsoft.AspNetCore.Hosting;

namespace AirportSearchApi.Services
{
    public class AirportService
    {
        private readonly List<Airport> _airports;

        public AirportService(IWebHostEnvironment env)
        {
            var path = Path.Combine(env.ContentRootPath, "Data", "airports.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            _airports = csv.GetRecords<Airport>().ToList();
        }

        public IEnumerable<Airport> Search(string query)
        {
            return _airports.Where(a =>
                a.name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                a.Id.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                a.continent.Contains(query, StringComparison.OrdinalIgnoreCase));
        }
    }
}
