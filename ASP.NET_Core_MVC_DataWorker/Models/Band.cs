using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_DataWorker.Models
{
    public class Band
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Необходимо указать название группы.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Необходимо выбрать страну")]
        public string Country { get; set; }
        [Required]
        [Range (1950, 2024, ErrorMessage = "Год образования группы не может быть меньше 1950 или больше 2023")]
        public int Year { get; set; }

        //музыканты, предположим в каждой группе строго по три
        public Musician Musician1 { get; set;}
        public Musician Musician2 { get; set; }
        public Musician Musician3 { get; set; }

    }
}
