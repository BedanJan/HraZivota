using System.Configuration;

namespace HraZivota
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Konstruktor pro vytvo�en� okna a spu�t�n� v�po�tu
        /// </summary>
        public MainForm()
        {
            //vytvo�en� �e�i�e v nov�m vl�kn�
            Thread threadOfSolver = new Thread(() => Solver.Solve(this)); 
            threadOfSolver.Start();
            //inicializov�n� komponent okna
            InitializeComponent();
        }

        /// <summary>
        /// Metoda pro p�ekreslen� okna
        /// </summary>
        protected override void OnPaint(PaintEventArgs pea)
        {
            Solver.Paint(pea.Graphics);
        }
    }
}
