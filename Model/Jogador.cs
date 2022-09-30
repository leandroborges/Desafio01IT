using System.ComponentModel.DataAnnotations;

namespace Desafio01IT.Model
{
    public class Jogador : Elenco
    {
        [Required]
        public int Numero { get; set; }

        public int ValorBonificacao()
        {
            int valorBonificacao = 10;
            return valorBonificacao;
        }
    }
}
