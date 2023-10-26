using System.ComponentModel.DataAnnotations;

namespace ProjetoCarros.Models
{
    public class RegistoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome da Marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Digite o nome do Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Digite o nome da cor")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "Digite o ano do carro")]
        public int Ano { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}


