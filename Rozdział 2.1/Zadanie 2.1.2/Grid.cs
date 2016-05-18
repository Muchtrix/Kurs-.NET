namespace Zadanie_2._1._2 {
    /// <summary>
    /// Klasa reprezentująca dwuwymiarową siatkę liczb całkowitych.
    /// </summary>
    public class Grid
    {
        int[][] tablicaWierszy;

        
        /// <summary>
        /// Tworzy nową siatkę o podanych wymairach.
        /// </summary>
        /// <param name="x">Liczba wierszy siatki.</param>
        /// <param name="y">Liczba kolumn siatki.</param>
        public Grid(int x, int y)
        {
            tablicaWierszy = new int[x][];
            for(int i = 0; i < x; ++i)
            {
                tablicaWierszy[i] = new int[y];
            }
        }

        
        /// <summary>
        /// Indekser jednoargumentowy.
        /// </summary>
        /// <param name="x">Wiersz do którego uzyskujemy dostęp.</param>
        /// <returns>Dany wiersz siatki</returns>
        public int[] this[int x]
        {
            get
            {
                return tablicaWierszy[x];
            }
            set
            {
                tablicaWierszy[x] = value;
            }
        }

        /// <summary>
        /// Indekser dwuargumentowy.
        /// </summary>
        /// <param name="x">Wiersz komórki do której się odnosimy.</param>
        /// <param name="y">Kolumna komórki do której się odnosimy.</param>
        /// <returns>Dana komórka siatki.</returns>
        public int this[int x, int y]
        {
            get
            {
                return tablicaWierszy[x][y];
            }
            set
            {
                tablicaWierszy[x][y] = value;
            }
        }
    }
}
