namespace RegistroV7.Models
{
    public class Pais
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string DDI { get; set; }
        public string Sigla { get; set; }
        public ICollection<Estado> Estados { get; set; }

    }
}
