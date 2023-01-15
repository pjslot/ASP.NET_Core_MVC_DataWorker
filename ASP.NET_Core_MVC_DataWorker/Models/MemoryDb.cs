namespace ASP.NET_Core_MVC_DataWorker.Models
{
    
    
    public static class MemoryDb
    {
      
        public static List<Band> Bands { get; set; } = new()
        {        
            new Band { Id = 0, Name = "Beatles", Year = 1960, Country = "England",
                Musician1 = new Musician {Name = "John", Instrument = "Bass"},
                Musician2 = new Musician {Name = "Bob", Instrument = "Guitar"},
                Musician3 = new Musician {Name = "Sir", Instrument = "Vocal"}},
            new Band { Id = 1, Name = "Genesis", Year = 1970, Country = "England",
                Musician1 = new Musician {Name = "Mary", Instrument = "Vocal"},
                Musician2 = new Musician {Name = "Nana", Instrument = "Drum"},
                Musician3 = new Musician {Name = "Lola", Instrument = "Violine"}},
            new Band { Id = 2, Name = "ABBA", Year = 1974, Country = "Sweden",
                Musician1 = new Musician {Name = "Mr Big", Instrument = "Vocal"},
                Musician2 = new Musician {Name = "Mr Little", Instrument = "Guitar"},
                Musician3 = new Musician {Name = "Helper", Instrument = "Drum"}},
            new Band { Id = 3, Name = "Sonic Youth", Year = 1990, Country = "USA" ,
                Musician1 = new Musician {Name = "Lana", Instrument = "Drum"},
                Musician2 = new Musician {Name = "Riana", Instrument = "Vocal"},
                Musician3 = new Musician {Name = "Buba", Instrument = "Guitar"}},
        };

    }
}
