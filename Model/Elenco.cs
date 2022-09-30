namespace Desafio01IT.Model
{
    public class Elenco
    {
        public int Id { get; set; }
        public int IdTime { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }


        public int Idade()
        {
            var now = DateTime.Now;

            int YearsOld = (now.Year - Nascimento.Year);

            if (now.Month < Nascimento.Month || (now.Month == Nascimento.Month && now.Day < Nascimento.Day))
            {
                YearsOld--;
            }

            return (YearsOld < 0) ? 0 : YearsOld;
        }

        private bool EstaLesionado()
        {
            return false;
        }

        public int ValorBonificacao()
        {
            int valorBonificacao = 0;
            return valorBonificacao;
        }
    }
}
