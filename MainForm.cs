using System.Configuration;

namespace HraZivota
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Konstruktor pro vytvoøení okna a spuštìní výpoètu
        /// </summary>
        public MainForm()
        {
            //vytvoøení øešièe v novém vláknì
            Thread threadOfSolver = new Thread(() => Solver.Solve(this)); 
            threadOfSolver.Start();
            //inicializování komponent okna
            InitializeComponent();
        }

        /// <summary>
        /// Metoda pro pøekreslení okna
        /// </summary>
        protected override void OnPaint(PaintEventArgs pea)
        {
            Solver.Paint(pea.Graphics);
        }
    }
}
