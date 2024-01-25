using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraZivota
{
    public static class Parameters
    {
        /// <summary>
        /// Šířka sítě
        /// </summary>
        public static int meshWidth = 400;
        /// <summary>
        /// Výška sítě
        /// </summary>
        public static int meshHeight = 400;
        /// <summary>
        /// Počet kroků/generací
        /// </summary>
        public static int numberOfSteps = 17465;

        /// <summary>
        /// Metoda, která přiřadí buňkám vlastnost "naživu"
        /// </summary>
        public static void SetStartPattern()
        {
            //pattern Bunnies 11
            Model.ArrayOfCells[meshWidth / 2, meshHeight / 2].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 - 2, meshHeight / 2 + 1].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 - 1, meshHeight / 2 + 1].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 1].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 2].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 - 1, meshHeight / 2 + 3].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 3].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 - 2, meshHeight / 2 + 4].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 - 1, meshHeight / 2 + 5].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2, meshHeight / 2 + 5].IsAlive = true;
            Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 5].IsAlive = true;
        }
    }
}
