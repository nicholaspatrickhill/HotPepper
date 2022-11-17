using System.Collections.Generic;

namespace HotPepper
{
    public class Pepper
    {
        public string? Name { get; set; }
        public string? SHU { get; set; }
    }

    public class PepperRepo
    {
        public static readonly Dictionary<string, Pepper> peppers = new Dictionary<string, Pepper>()
        {
            { "bellPepper", new Pepper() { Name = "Bell Pepper", SHU = "0", } },
            { "carolinaReaper", new Pepper() { Name = "Carolina Reaper", SHU = "2,200,000" } },
            { "cayenne", new  Pepper() { Name = "Cayenne", SHU = "50,000", } },
            { "fishPepper", new Pepper() { Name = "Fish Pepper", SHU = "10,000", } },
            { "ghostPepper", new Pepper() { Name = "Ghost Pepper", SHU = "1,100,000", } },
            { "habanero", new Pepper() { Name = "Habanero", SHU = "350,000", } },
            { "jalapeno", new Pepper() { Name = "Jalapano", SHU = "10,000", } },
            { "lemonDrop", new Pepper() { Name = "Lemon Drop", SHU = "30,000", } },
            { "pepperoncini", new Pepper() { Name = "Pepperoncini", SHU = "900", } },
            { "pepperSpray", new Pepper() { Name = "Pepper Spray", SHU = "2,000,000", } },
            { "poblano", new Pepper() { Name = "Poblano", SHU = "2000", } },
            { "scotchBonnet", new Pepper() { Name = "Scotch Bonnet", SHU = "350,000" } },
            { "serrano", new Pepper() { Name = "Serrano", SHU = "23,000", } },
            { "tabasco", new Pepper() { Name = "Tabasco", SHU = "50,000", } },
            { "trinidadScorpion", new Pepper() { Name = "Trinidad Scorpion", SHU = "1,000,000" } }, 
        };
    }
}

