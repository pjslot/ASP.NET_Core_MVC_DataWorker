using System.ComponentModel.DataAnnotations;
namespace ASP.NET_Core_MVC_DataWorker.Models

{
    public class Musician
    {
        private int id;
        //генерация псевдоуникального ID
        public int ID
        {
            get {  return id;}
            set
            {               
                    Random rnd = new Random();
                    id = rnd.Next(10000);                         
            }
        }

        private string name;
    [Required(ErrorMessage = "Необходимо указать имя музыканта")]
    
        public string Name
        {
            get { if (name != null) return name; else return "NoName"; }
            set { if (value != null) name = value; else name = "NoName"; }
        }

       
        private string instrument;
        [Required(ErrorMessage = "Необходимо указать инструмент музыканта")]
        public string Instrument 
        {
            get { if (instrument != null) return instrument; else return "NoInstrument"; }
            set { if (value != null) instrument = value; else instrument = "NoInstrument"; }
        }
       
    }
}
