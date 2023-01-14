namespace ASP.NET_Core_MVC_DataWorker.Models
{
    
    
    public static class MemoryDb
    {
      
        public static List<Band> Bands { get; set; } = new()
        {        
            new Band { Id = 0, Name = "Beatles", Year = 1960, Country = "England",
                Musician1 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician2 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician3 = new Musician {Name = "NoNm", Instrument = "NoIn"}},
            new Band { Id = 1, Name = "Genesis", Year = 1970, Country = "England",
                Musician1 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician2 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician3 = new Musician {Name = "NoNm", Instrument = "NoIn"}},
            new Band { Id = 2, Name = "ABBA", Year = 1974, Country = "Sweden",
                Musician1 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician2 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician3 = new Musician {Name = "NoNm", Instrument = "NoIn"}},
            new Band { Id = 3, Name = "Sonic Youth", Year = 1990, Country = "USA" ,
                Musician1 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician2 = new Musician {Name = "NoNm", Instrument = "NoIn"},
                Musician3 = new Musician {Name = "NoNm", Instrument = "NoIn"}},
        };

    }
}
