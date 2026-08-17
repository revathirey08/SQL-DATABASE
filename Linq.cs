using System;
using System.Collections.Generic;
using System.Linq;

class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Genre { get; set; } = "";
    public int Rating { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Game> games = new List<Game>
        {
            new Game { Id = 1, Name = "GTA V", Genre = "Action", Rating = 9, Price = 1500 },
            new Game { Id = 2, Name = "Minecraft", Genre = "Adventure", Rating = 8, Price = 1000 },
            new Game { Id = 3, Name = "FIFA", Genre = "Sports", Rating = 7, Price = 2000 },
            new Game { Id = 4, Name = "Valorant", Genre = "Action", Rating = 9, Price = 0 },
            new Game { Id = 5, Name = "Forza", Genre = "Racing", Rating = 8, Price = 2500 },
            new Game { Id = 6, Name = "GTA San Andreas", Genre = "Action", Rating = 9, Price = 800 }
        };


     
        var result1 = games
            .Where(x => x.Rating >= 8)
            .OrderByDescending(x => x.Rating)
            .ThenBy(x => x.Price)
            .ToList();


    
        var result2 = games
            .Select(x => new
            {
                GameName = x.Name,
                GameGenre = x.Genre,
                GameRating = x.Rating
            })
            .ToList();


        
        var result3 = games
            .Where(x => x.Rating >= 8)
            .Select(x => new
            {
                x.Name,
                x.Price
            })
            .ToList();


      
        var genres = games
            .Select(x => x.Genre)
            .Distinct()
            .ToList();


      
        var groups = games
            .GroupBy(x => x.Genre)
            .Select(group => new
            {
                Genre = group.Key,
                TotalGames = group.Count(),
                AverageRating = group.Average(x => x.Rating)
            })
            .ToList();


        
        var priceByGenre = games
            .GroupBy(x => x.Genre)
            .Select(group => new
            {
                Genre = group.Key,
                TotalPrice = group.Sum(x => x.Price)
            })
            .ToList();


      
        int page = 2;
        int pageSize = 2;

        var pageResult = games
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();


       
        var result8 = games
            .Where(x =>
                x.Rating >= 8 &&
                x.Price <= 2000)
            .ToList();


      
        var result9 = games
            .Where(x =>
                x.Genre == "Action" ||
                x.Genre == "Sports")
            .ToList();


      
        string search = "GTA";

        var searchResult = games
            .Where(x => x.Name.Contains(search))
            .ToList();


      
        var result11 = games
            .Where(x =>
                x.Genre == "Action" &&
                x.Rating >= 9 &&
                x.Price < 2000)
            .ToList();


        
        var topGames = games
            .OrderByDescending(x => x.Rating)
            .ThenBy(x => x.Price)
            .Take(3)
            .Select(x => new
            {
                x.Name,
                x.Rating,
                x.Price
            })
            .ToList();


        var cheapestHighRated = games
            .Where(x => x.Rating >= 8)
            .OrderBy(x => x.Price)
            .FirstOrDefault();


        
        var expensiveActionGame = games
            .Where(x => x.Genre == "Action")
            .OrderByDescending(x => x.Price)
            .FirstOrDefault();


        
        bool hasFreeGame = games
            .Any(x => x.Price == 0);


      
        int highRatedCount = games
            .Count(x => x.Rating >= 8);


       
        decimal total = games
            .Select(x => x.Price)
            .Aggregate((a, b) => a + b);


        
        var reverseGames = games
            .AsEnumerable()
            .Reverse()
            .ToList();


        
        var extraGames = new List<Game>
        {
            new Game
            {
                Id = 7,
                Name = "PUBG",
                Genre = "Action",
                Rating = 8,
                Price = 0
            }
        };

        var allGames = games
            .Concat(extraGames)
            .ToList();


        // 20. UNION
        var unionGames = games
            .Union(extraGames)
            .ToList();




        Console.WriteLine("GROUP BY RESULT");

        foreach (var item in groups)
        {
            Console.WriteLine(
                item.Genre +
                " | Games: " +
                item.TotalGames +
                " | Average Rating: " +
                item.AverageRating);
        }

        Console.WriteLine();

        Console.WriteLine("TOP GAMES");

        foreach (var item in topGames)
        {
            Console.WriteLine(
                item.Name +
                " | Rating: " +
                item.Rating +
                " | Price: " +
                item.Price);
        }

        Console.WriteLine();

        Console.WriteLine(
            "High Rated Count: " +
            highRatedCount);

        Console.WriteLine(
            "Free Game Exists: " +
            hasFreeGame);

        Console.WriteLine(
            "Total Price: " +
            total);
    }
}