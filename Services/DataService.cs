namespace Desafio01IT.Services
{
    public static class DataService
    {
        public static bool IsValid(DateTime data)
        {
            return data < DateTime.Now;
        }

        public static int CalcularIdade(DateTime data)
        {
            var now = DateTime.Now;

            int YearsOld = (now.Year - data.Year);

            if (now.Month < data.Month || (now.Month == data.Month && now.Day < data.Day))
            {
                YearsOld--;
            }

            return (YearsOld < 0) ? 0 : YearsOld;
        }
    }
}
