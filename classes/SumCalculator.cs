namespace MyCSharpProject.Classes
{
    public class SumCalculator
    {
        public static int CalculateSum()
        {
            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            return SOMA;
        }
    }
}
