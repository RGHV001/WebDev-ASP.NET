namespace RegistroV7.Models
{
    public class Estado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public int PaisID { get; set; }

        public Pais Pais { get; set; }
    }
}
