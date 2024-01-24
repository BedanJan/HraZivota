using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraZivota
{
    public class Cell
    {
        /// <summary>
        /// Souřadnice X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Souřadnice Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Vlastnost uchovávající stav buňky - žívá/mrtvá
        /// </summary>
        public bool IsAlive { get; set; }
        /// <summary>
        /// List buněk, které mají s danou instancí společnou hranici či vrchol
        /// </summary>
        public List<Cell> NeighboringCells { get; set;}

        /// <summary>
        /// Konstruktor pro vytvoření instance s danými vlastnostmi
        /// </summary>
        /// <param name="x">Vodorovná souřadnice x</param>
        /// <param name="y">Horizontální souřadnice y</param>
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            IsAlive = false; //nastavení stavu buňky na "mrtvá"
            NeighboringCells = new List<Cell>(); //inicializace listu sousedních buněk
        }
    }
}
