using Desafio01IT.Services;
using System.ComponentModel.DataAnnotations;

namespace Desafio01IT.Model
{
    public class Elenco
    {
        [Key]
        public int Id { get; set; }
        public int IdTime { get; set; }        
        [Required]
        public string Nome { get; set; }
        public string Posicao { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        public Time Time { get; set; }

        private int CalcularIdade()
        {
            return DataService.CalcularIdade(Nascimento);
        }

        public int ValorBonificacao()
        {
            int valorBonificacao = 0;
            return valorBonificacao;
        }        
    }
}
