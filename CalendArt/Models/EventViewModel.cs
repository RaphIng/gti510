namespace CalendArt.Models
{
    public class AfficherEvenement
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        //public int TypeId { get; set; } //**avec enum? comment faire avec bonne pratique? - Vincent**
        public string DateHeure { get; set; }
        public string Location { get; set; }
        //public ArrayList Membres { get; set; }

    }
}