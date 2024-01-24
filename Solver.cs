using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraZivota
{
    public static class Solver
    {
        /// <summary>
        /// Metoda pro spuštění výpočtu
        /// </summary>
        public static void Solve(Form mainForm)
        {
            //vytvoření modelu
            Model.CreateModel();
            //spuštění simulace/automatu
            for (int i = 0; i<Parameters.numberOfSteps;  i++)
            {
                //nová generace
                NextGeneration();
                //
                mainForm.Invalidate();
            }
        }

        /// <summary>
        /// Metoda pro výpočet další generace
        /// </summary>
        private static void NextGeneration()
        {
            //vytvoření listu pro buňky, kterým se bude měnit stav
            List<Cell> changingCell = new List<Cell>();
            //první projití buněk a zjištění nových stavů
            foreach (Cell cell in Model.ArrayOfCells)
            {
                int cellsAliveCount = 0;
                foreach (Cell nc in cell.NeighboringCells)
                {
                    if (nc.IsAlive) cellsAliveCount++;
                }
                //vyhodnocení
                if (cell.IsAlive && (cellsAliveCount == 0 || cellsAliveCount == 1 || cellsAliveCount > 3)) changingCell.Add(cell); //zabití živých buněk
                if (!(cell.IsAlive) && cellsAliveCount == 3) changingCell.Add(cell); //oživení mrtvé buňky
            }
            //druhé projití buněk a připsání nového stavu
            foreach (Cell cell in changingCell)
            {
                if (cell.IsAlive) cell.IsAlive = false;
                else cell.IsAlive = true;
            }
        }

        /// <summary>
        /// Metoda pro vykreslení do okna
        /// </summary>
        /// <param name="g">Objekt Graphics, do kterého se kreslí</param>
        public static void Paint(Graphics g)
        {
            Brush brush = Brushes.Black;
            foreach (Cell cell in Model.ArrayOfCells)
            {
                if (cell.IsAlive) g.FillRectangle(brush, cell.X * 2, cell.Y * 2, 2, 2);
            }
        }
    }
}
