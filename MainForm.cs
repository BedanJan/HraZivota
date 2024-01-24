using System.Configuration;

namespace HraZivota
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            this.BackColor = Color.White;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.Visible = true;
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
