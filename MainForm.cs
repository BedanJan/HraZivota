using System.Configuration;

namespace HraZivota
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            //vytvo�en� �e�i�e v nov�m vl�kn�
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
