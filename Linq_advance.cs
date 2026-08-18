using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Rating { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public int DeveloperId { get; set; }
    public Developer Developer { get; set; } = null!;
}

class Developer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

class Program
{
    static void Main()
    {
       
        var games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Name = "GTA V",
                Rating = 9,
                Price = 1500
            },

            new Game
            {
                Id = 2,
                Name = "FIFA",
                Rating = 7,
                Price = 2000
            },

            new Game
            {
                Id = 3,
                Name = "Minecraft",
                Rating = 8,
                Price = 1000
            },

            new Game
            {
                Id = 4,
                Name = "Valorant",
                Rating = 9,
                Price = 0
            },

            new Game
            {
                Id = 5,
                Name = "Forza",
                Rating = 8,
                Price = 2500
            },

            new Game
            {
                Id = 6,
                Name = "GTA San Andreas",
                Rating = 9,
                Price = 800
            }
        };


      
        IEnumerable<Game> enumerableGames = games;

        Console.WriteLine(" IEnumerable");

        foreach (var game in enumerableGames)
        {
            Console.WriteLine(game.Name);
        }


        
        IQueryable<Game> queryableGames =
            games.AsQueryable();

        Console.WriteLine(" IQueryable");

        foreach (var game in queryableGames)
        {
            Console.WriteLine(game.Name);
        }


        var gtaGames = games
            .AsQueryable()
            .Where(x => x.Rating >= 8)
            .AsEnumerable()
            .Where(x => x.Name.Contains("GTA"))
            .ToList();

        Console.WriteLine(" AsEnumerable()");

        foreach (var game in gtaGames)
        {
            Console.WriteLine(game.Name);
        }


       
        var goodGames = games
            .AsQueryable()
            .Where(x => x.Rating >= 8)
            .ToList();

        Console.WriteLine(" AsQueryable()");

        foreach (var game in goodGames)
        {
            Console.WriteLine(game.Name);
        }

        var highRatedQuery = games
            .Where(x => x.Rating >= 8);

        Console.WriteLine(" Deferred Execution");

        foreach (var game in highRatedQuery)
        {
            Console.WriteLine(game.Name);
        }


        
        var highRatedGames = games
            .Where(x => x.Rating >= 8)
            .ToList();

        Console.WriteLine("Immediate Execution");

        foreach (var game in highRatedGames)
        {
            Console.WriteLine(game.Name);
        }


        
        Expression<Func<Game, bool>> filter =
            x => x.Rating >= 8;

        var filteredGames = games
            .AsQueryable()
            .Where(filter)
            .ToList();

        Console.WriteLine(" Expression Tree");

        foreach (var game in filteredGames)
        {
            Console.WriteLine(game.Name);
        }


        
        var result1 = games
            .Where(x => x.Rating >= 8)
            .ToList();

        Console.WriteLine(". LINQ to Objects");

        foreach (var game in result1)
        {
            Console.WriteLine(game.Name);
        }

        // Real project-la:
        //
        // var result2 = db.Games
        //     .Where(x => x.Rating >= 8)
        //     .ToList();


        
        // Real EF Core project-la:
        //
        // var result3 = db.Games
        //     .Include(x => x.Category)
        //     .ToList();



        // Real EF Core project-la:
        //
        // var result4 = db.Games
        //     .Include(x => x.Category)
        //     .ThenInclude(x => x.Developer)
        //     .ToList();


        var result5 = games
            .Select(x => new
            {
                GameName = x.Name,
                GameRating = x.Rating,
                GamePrice = x.Price
            })
            .ToList();

        Console.WriteLine(". Select Projection");

        foreach (var game in result5)
        {
            Console.WriteLine(
                game.GameName +
                " | Rating: " +
                game.GameRating +
                " | Price: " +
                game.GamePrice);
        }


        
        var categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Action"
            },

            new Category
            {
                Id = 2,
                Name = "Sports"
            },

            new Category
            {
                Id = 3,
                Name = "Adventure"
            }
        };

       
        games[0].CategoryId = 1;
        games[1].CategoryId = 2;
        games[2].CategoryId = 3;
        games[3].CategoryId = 1;
        games[4].CategoryId = 1;
        games[5].CategoryId = 1;

        var result6 = games
            .Join(
                categories,
                game => game.CategoryId,
                category => category.Id,
                (game, category) => new
                {
                    GameName = game.Name,
                    CategoryName = category.Name
                })
            .ToList();

        Console.WriteLine(" Join");

        foreach (var item in result6)
        {
            Console.WriteLine(
                item.GameName +
                " | " +
                item.CategoryName);
        }


        // Real EF Core project-la:
        //
        // var result7 = db.Games
        //     .AsNoTracking()
        //     .ToList();

        Console.WriteLine(" AsNoTracking()");
        Console.WriteLine("Read-only DB data");
    }
}

