using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AluguelDeCarrosAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        [JsonIgnore] public Carro? Carro { get; set; }
        [ForeignKey("Carro")] public int? CarroId { get; set; }

        // public int CargaHorariaSemanal { get;set; }
    }
} // para cada Ponto é um usuario