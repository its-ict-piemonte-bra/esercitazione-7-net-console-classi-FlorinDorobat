using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    /// <summary>
    /// qìQuesta classe gestisce un vettore di numeri interi e fornisce diversi metodi di appoggio.
    /// </summary>
    public class Vettore
    {
        /// <summary>
        /// Il vettore di interi gestito
        /// </summary>
        public int[] vettore;
        //public int[] _vettore;

        /// <summary>
        ///Crea una nuova istanza vuota dell'oggetto vettore
        /// </summary>
        /// 

        public Vettore()
        {
            // Metodo costruttore 1 : vuoto
            vettore = new int[0];
        }

        /// <summary>
        /// Crea una nuova istanza dell'oggetto vettore, a partire dell'array specificato
        /// </summary>
        /// <param name="vettore">L'array da gestire</param>

        public Vettore(int[] vettore)
        {
            this.vettore = vettore;
            //_vettore = new int[vettore.Length];
        }

        public float ValoreMedio()
        {
            if (vettore.Length == 0)
            {
                throw new InvalidOperationException("errore");
            }

            float avg = 0;
            foreach (int value in vettore)
            {
                avg += value;
            }
            return avg / vettore.Length;
        }


        /// <summary>
        /// Restituisce se un vettore è vuoto oppure no
        /// </summary>
        /// <returns>true se il vettore è vuoto, altrimenti false</returns>
        public bool isEmpty()
        {
            return vettore.Length == 0;
        }

        /// <summary>
        /// Restituisce il valore massimo all'interno del vettore
        /// </summary>
        /// <returns>Il valore massimo</returns>
        /// <exception cref="InvalidOperationException">Se il vettore è vuoto</exception>
        public int ValoreMassimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("errore");
            }

            int maxVal = vettore[0];
            for (int i = 1; i < vettore.Length; i++)
            {
                if (maxVal > vettore[i])
                {
                    maxVal = vettore[i];
                }
            }
            return maxVal;

        }

        /// <summary>
        /// Restituisce il valore minimo all'interno del vettore
        /// </summary>
        /// <returns>Il valore minimo</returns>
        /// <exception cref="InvalidOperationException">Se il vettore è vuoto</exception>
        public int ValoreMinimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("errore");
            }

            int minVal = vettore[0];
            foreach (int i in vettore)
            {
                if (minVal < i)
                {
                    minVal = i;
                }
            }
            return minVal;
        }

        /// <summary>
        /// Restituisce la rappresentazione del vettore, sotto forma di 
        /// stringa CSV (valori separati da virgola)
        /// </summary>
        /// <returns>La rappresentazione del vettore</returns>
        /// <example>
        /// int[] sorgente = new int[] { 1, 2, 3 , 4, 5 };
        /// Vettore v = new Vettore(sorgente);
        /// Console.WriteLine(v); // [ 1, 2, 3, 4, 5 ]
        /// </example>
        public override string ToString()
        {
            string tempString = "[";
            for (int i = 0; i < vettore.Length - 1; i++)
            {
                tempString += $"{vettore[i]}, ";
            }
            tempString += $"{vettore[vettore.Length - 1]} ]";

            return tempString;
        }

        /// <summary>
        /// Stampa solamente i numeri pari a video, uno per riga
        /// </summary>
        public void printEvenNumbers()
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] % 2 == 0)
                {
                    Console.Write($"{vettore[i]} ");
                }
            }
        }

        /// <summary>
        /// Ordina l'array con l'algoritmo di ordinamento per selezione
        /// </summary>
        public void sort()
        {
            for (int i = 0; i < vettore.Length - 1; i++)
            {
                int minIndex = i;
                int min = vettore[i];

                for (int j = i + 1; j < vettore.Length; j++)
                {
                    if (vettore[j] < min)
                    {
                        minIndex = j;
                        min = vettore[j];
                    }
                }

                // ottimizzazione, scambio solo se necessario
                if (minIndex != i)
                {
                    int temp = vettore[i];
                    vettore[i] = vettore[minIndex];
                    vettore[minIndex] = temp;
                }
            }
        }


        /// <summary>
        /// Serializza l'oggetto sul file specificato
        /// </summary>
        /// <param name="path">Il percorso del file</param>
        public void Serialize(string path)
        {
            /*if ()
            {
                throw new Exception("Errore :nerd:");
            }*/

            StreamWriter writer = new StreamWriter(path, false);
            writer.WriteLine(vettore.ToString());
            writer.Close();
        }

        /// <summary>
        /// Carica un nuovo oggetto vettore a partire dal file
        /// specificato come parametro
        /// </summary>
        /// <param name="path">Il percorso del file</param>
        /// <returns>L'oggetto Vettore Generato</returns>
        public static Vettore Deserialize(string path)
        {

            throw new NotImplementedException();
        }
    }
}