using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;

namespace HraZivota
{
    public static class Model
    {
        /// <summary>
        /// Dvourozměrné pole uchovávající všechny buňky
        /// </summary>
        private static Cell[,] arrayOfCells = new Cell[Parameters.meshWidth, Parameters.meshHeight];
        public static Cell[,] ArrayOfCells 
        {  
            get => arrayOfCells; 
            set => arrayOfCells = value;
        }

        /// <summary>
        /// Metoda, která pro daný rozměr sítě vytvoří buňky a uloží je do dvourozměrného pole
        /// </summary>
        public static void CreateModel()
        {
            //naplnění pole ArrayOfCells buňkami
            for (int i = 0; i < Parameters.meshHeight; i++) //cyklus přes řádky - Y
            {
                for (int j = 0; j < Parameters.meshWidth; j++) //cylkus přes sloupce - X
                {
                    ArrayOfCells[j, i] = new Cell(j, i);
                }
            }
            //přiřazení jednotlivým buňkám sousední buňky - naplnění Listu NeighboringCells
            for (int i = 0; i < Parameters.meshHeight; i++) //cyklus přes řádky - Y
            {
                for (int j = 0; j < Parameters.meshWidth; j++) //cylkus přes sloupce - X
                {
                    if ((i - 1) >= 0 && (j - 1) >= 0) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j - 1, i - 1]); //levý horní soused
                    if ((i - 1) >= 0) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j, i - 1]); //horní soused
                    if ((i - 1) >= 0 && (j + 1) < Parameters.meshWidth) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j + 1, i - 1]); //pravý horní soused
                    if ((j - 1) >= 0) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j - 1, i]); //levý soused
                    if ((j + 1) < Parameters.meshWidth) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j + 1, i]); //pravý soused
                    if ((i + 1) < Parameters.meshHeight && (j - 1) >= 0) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j - 1, i + 1]); //levý dolní soused
                    if ((i + 1) < Parameters.meshHeight) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j, i + 1]); //dolní soused
                    if ((i + 1) < Parameters.meshHeight && (j + 1) < Parameters.meshWidth) ArrayOfCells[j, i].NeighboringCells.Add(ArrayOfCells[j + 1, i + 1]); //pravý dolní soused
                }
            }
            //nastavení počátečních buněk, které jsou naživu
            Parameters.SetStartLayout();
        }
    }
}
