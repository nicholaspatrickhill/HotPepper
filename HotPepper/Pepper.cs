using System.Collections.Generic;

namespace HotPepper
{
    public class Pepper
    {
        public string? Name { get; set; }
        public string? SHU { get; set; }
    }

    public class HotPepperRepo
    {
        Dictionary<string, Pepper> peppers = new Dictionary<string, Pepper>()
        {
            { "Cayenne", new Pepper() { Name = "Cayenne", SHU = "50,000", } },
            { "Habanero", new Pepper() { Name = "Habanero", SHU = "350,000", } },
            { "Jalapeno", new Pepper() { Name = "Jalapano", SHU = "10,000", } },
            { "Tabasco", new Pepper() { Name = "Tabasco", SHU = "50,000", } },
            { "Carolina Reaper", new Pepper() { Name = "Carolina Reaper", SHU = "2,200,000" } },
            { "Ghost Pepper", new Pepper() { Name = "Ghost Pepper", SHU = "1,100,000", } },
            { "Serrano", new Pepper() { Name = "Serrano", SHU = "23,000", } },
            { "Bell Pepper", new Pepper() { Name = "Bell Pepper", SHU = "0", } },
            { "Pepperoncini", new Pepper() { Name = "Pepperoncini", SHU = "900", } },
            { "Poblano", new Pepper() { Name = "Poblano", SHU = "2000", } },
            { "Fish Pepper", new Pepper() { Name = "Fish Pepper", SHU = "10,000", } },
            { "Lemon Drop", new Pepper() { Name = "Lemon Drop", SHU = "30,000", } },
            { "Scotch Bonnet", new Pepper() { Name = "Scotch Bonnet", SHU = "350,000" } },
            { "Trinidad Scorpion", new Pepper() { Name = "Trinidad Scorpion", SHU = "1,000,000" } },
            { "Pepper Spray", new Pepper() { Name = "Pepper Spray", SHU = "2,000,000", } },
        };
    }
}

