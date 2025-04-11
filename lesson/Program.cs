namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            try
            {
                int[] sorgente = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                Vettore vect = new Vettore(sorgente);
                Console.WriteLine(vect.isEmpty());
                Console.WriteLine(vect.ValoreMinimo());
                Console.WriteLine(vect.ValoreMassimo());
                Console.WriteLine(vect.ToString());

                vect.printEvenNumbers();
                vect.sort();
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                Vettore vect = new Vettore();
                vect.Serialize("mio-file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante serializzazione {ex.Message}");
            }
        }

    }
}
