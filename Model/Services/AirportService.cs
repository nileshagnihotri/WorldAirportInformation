// Services/AirportService.cs
using CsvHelper;
using System.Globalization;

public class AirportService
{
    private readonly List<Airport> _airports;

    public AirportService(IWebHostEnvironment env)
    {
        try
        {
            var path = Path.Combine(env.ContentRootPath, "Data", "airports.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            _airports = csv.GetRecords<Airport>().ToList();
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error loading airports: {ex.Message}");
            _airports = new List<Airport>();
        }
    }

    public IEnumerable<Airport> Search(string query)
    {
        try
        {
            return _airports.Where(a =>
                a.name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                a.Id.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                a.continent.Contains(query, StringComparison.OrdinalIgnoreCase));
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error searching airports: {ex.Message}");
            return Enumerable.Empty<Airport>();
        }
    }
}
