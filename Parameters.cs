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
        public static int numberOfSteps = 4000;

        /// <summary>
        /// Metoda, která přiřadí buňkám vlastnost "naživu"
        /// </summary>
        public static void SetStartLayout()
        {
            //Model.ArrayOfCells[meshWidth / 2, meshHeight / 2].IsAlive = true;
            //Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 1].IsAlive = true;
            //Model.ArrayOfCells[meshWidth / 2 - 1, meshHeight / 2 + 2].IsAlive = true;
            //Model.ArrayOfCells[meshWidth / 2, meshHeight / 2 + 2].IsAlive = true;
            //Model.ArrayOfCells[meshWidth / 2 + 1, meshHeight / 2 + 2].IsAlive = true;
            //
            Model.ArrayOfCells[200, 200].IsAlive = true;
            Model.ArrayOfCells[198, 201].IsAlive = true;
            Model.ArrayOfCells[199, 201].IsAlive = true;
            Model.ArrayOfCells[200, 202].IsAlive = true;
            Model.ArrayOfCells[199, 202].IsAlive = true;
            Model.ArrayOfCells[202, 202].IsAlive = true;
            Model.ArrayOfCells[203, 202].IsAlive = true;
            Model.ArrayOfCells[204, 202].IsAlive = true;
        }
    }
}
