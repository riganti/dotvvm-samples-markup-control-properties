using System.Collections.Generic;

namespace MarkupControlsDemo.Model;

public class Store
{
    // many thanks https://diply.com/102631/15-snakes-just-sssstylin-in-hats

    public static readonly List<ProductModel> Products = new List<ProductModel>()
    {
        new ProductModel()
        {
            Id = 1,
            Title = "Black cylinder",
            ImageUrl = "https://imgb.srgcdn.com/l49ZbdaZUUsTMMraN1nQ.jpg?width=480",
            Description = "What a perfect gent in that top hat. There's nothing like formal wear to make a good first impression.",
            Price = 29.9m
        },
        new ProductModel()
        {
            Id = 2,
            Title = "Celebration hat",
            ImageUrl = "https://imgb.srgcdn.com/XBQc5EqMO1dRvVd9ir9n.jpg?width=480",
            Description = "Looks like it's already pooped from the effort — it has partied until it dropped.",
            Price = 14.5m
        },
        new ProductModel()
        {
            Id = 3,
            Title = "Chicken disguise",
            ImageUrl = "https://imgb.srgcdn.com/5ZR2rwzfLBTcgMGA8hnU.jpg?width=640",
            Description = "Sure, snakes get a bad rap, but everybody loves a chicken, right? This is how you slip under the radar.",
            Price = 24.1m
        },
        new ProductModel()
        {
            Id = 4,
            Title = "Woolen Santa hat",
            ImageUrl = "https://imgb.srgcdn.com/QjBmELaCBzMFjXvVv6ie.jpg?width=640",
            Description = "For once, here's a Santa I have no problem believing can fit down any chimney. I guess that's not entirely comforting for a lot of people, though.",
            Price = 39m
        },
        new ProductModel()
        {
            Id = 5,
            Title = "I'm Dad chapeau",
            ImageUrl = "https://imgb.srgcdn.com/PN4saUSPxOQqLrsMXItu.jpg?width=768",
            Description = "I don't know, I think all new fathers should celebrate with a jaunty new chapeau.",
            Price = 17m
        },
        new ProductModel()
        {
            Id = 6,
            Title = "Patriot",
            ImageUrl = "https://imgb.srgcdn.com/adUWuUApb3lCwsSgOoeQ.jpg?width=768",
            Description = "Snakes are more than welcome at Fourth of July parties as long as they're properly attired, I would assume.",
            Price = 26.7m
        },
        new ProductModel()
        {
            Id = 7,
            Title = "Coprophile",
            ImageUrl = "https://imgb.srgcdn.com/IChBWTuhpPAmzqmMRERh.jpg?width=640",
            Description = "Well, not the ear flaps, because it doesn't have any external ears, but the color will help this pale lady stick out.",
            Price = 37.4m
        }
    };
}