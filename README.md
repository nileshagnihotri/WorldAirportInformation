# AirportController - Airport Search API

This project provides an ASP.NET Core Web API for searching airport data. The main controller is `AirportController`, which exposes a search endpoint for querying airports by name, ID, or continent.

## Features

- Search airports using a query string
- Returns results in JSON format
- Input validation for search queries

## Endpoint

### Search Airports

```
GET /api/airport/search?query={searchTerm}
```

**Parameters:**
- `query` (string, required): The search term to look for in airport name, ID, or continent.

**Responses:**
- `200 OK`: Returns a list of matching airports.
- `400 Bad Request`: If the query parameter is missing or empty.

## Example Request

```
GET /api/airport/search?query=Europe
```

## Getting Started

1. Ensure you have [.NET 6 or later](https://dotnet.microsoft.com/download).
2. Place your airport data CSV file in the `Data/airports.csv` path.
3. Run the application:
   ```
   dotnet run
   ```
4. Access the API at:
   ```
   https://localhost:<port>/api/airport/search?query=your_query
   ```

## License

MIT
