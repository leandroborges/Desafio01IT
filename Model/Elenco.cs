using Desafio01IT.Services;

namespace Desafio01IT.Model
{
    public class Elenco
    {
        public int Id { get; set; }
        public int IdTime { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }


        public Elenco(string posicao)
        {
            Posicao = posicao;
        }

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
