namespace ProfessionalCardWebClientApp.Models
{
    public class Connection
    {
        public int FromNodeId { get; set; } // ID начального узла
        public int ToNodeId { get; set; }   // ID конечного узла
        public string Description { get; set; } // Описание связи (например, "необходим курс")
    }
}
