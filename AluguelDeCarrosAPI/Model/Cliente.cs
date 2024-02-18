using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace AluguelDeCarrosAPI.Model;

public class Cliente
{
    public Cliente(int id, string nome, int cpf, string formaDePagamento)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        FormaDePagamento = formaDePagamento;
    }

    public int Id {  get; set; }
    public string Nome { get; set; }
    public int Cpf { get; set; }
    public string FormaDePagamento { get; set; }
    public string? CarroId { get; set; }
    //public virtual Carro Carro { get; set; }
}
