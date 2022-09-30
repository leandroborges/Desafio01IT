using Desafio01IT.Services;
using System.ComponentModel.DataAnnotations;

namespace Desafio01IT.Model
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public DateTime Fundacao { get; set; }
        public ICollection<Elenco> Elenco { get; set; }

        public Time(DateTime fundacao)
        {
            Fundacao = fundacao;
        }

        public bool IsValid()
        {
            return DataService.IsValid(Fundacao);
        }
    }
}
