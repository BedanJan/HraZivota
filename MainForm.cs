using System.Configuration;

namespace HraZivota
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            //vytvoøení øešièe v novém vláknì
            Thread threadOfSolver = new Thread(() => Solver.Solve(this)); 
            threadOfSolver.Start();
            //
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            Solver.Paint(pea.Graphics);
        }
    }
}
