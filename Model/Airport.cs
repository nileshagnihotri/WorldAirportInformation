// Models/Airport.cs
using CsvHelper.Configuration.Attributes;

public class Airport
{
    [Name("id")]
    public string Id { get; set; }
    [Name("name")]
    public string name { get; set; }

    public string ident { get; set; }
    public string type { get; set; }
    
    public string latitude_deg { get; set; }
    public string longitude_deg { get; set; }
    public string elevation_ft { get; set; }
    public string continent { get; set; }
    public string iso_country { get; set; }
    public string iso_region { get; set; }
    public string municipality { get; set; }
    public string scheduled_service { get; set; }

    public string icao_code { get; set; }
    public string iata_code { get; set; }
    public string gps_code { get; set; }
    public string local_code { get; set; }
                
    public string home_link { get; set; }
    public string wikipedia_link { get; set; }
    public string keywords { get; set; }

}


