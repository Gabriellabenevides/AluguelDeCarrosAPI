namespace AluguelDeCarrosAPI.Model
{
    public class Carro
    {
        public Carro(int id, string nome, string cor, string marca, string placa, double preco)
        {
            Id = id;
            Nome = nome;
            Cor = cor;
            Marca = marca;
            Placa = placa;
            Preco = preco;
            Disponivel = "Sim";
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public double Preco { get; set; }
        public string Disponivel { get; set; }    
    }
    public class AlugarCarroRequest
    {
        public string NomeCarro { get; set; }
        public Carro CarroDisponivel { get; set; }
    }
}
