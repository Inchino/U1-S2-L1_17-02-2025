namespace MenuRistorante.Models
{
    public class Cibo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set; }

        public Cibo(int id, string nome, double prezzo)
        {
            Id = id;
            Nome = nome;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            return $"{Id}: {Nome} ({Prezzo:F2} euro)";
        }
    }
}
