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
