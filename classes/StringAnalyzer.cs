namespace MyCSharpProject.Classes
{
    public class StringAnalyzer
    {
        
        public static int CountOccurrencesOfA(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0; 
            }

            int count = 0;

            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            return count;
        }

        // Método para verificar se existe pelo menos um 'a' na string
        public static bool ContainsA(string input)
        {
            return input.Contains('a') || input.Contains('A');
        }
    }
}
