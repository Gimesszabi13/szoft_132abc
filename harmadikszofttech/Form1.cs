namespace harmadikszofttech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;
            
            Random random = new Random();

            int m�ret = 20;

            for (int sor = 0; sor < 20; sor++)
            {
                for (int ioszlop = 0; ioszlop < 20; ioszlop++)
                {
                    Szamologomb p = new Szamologomb();
                    Controls.Add(p);
                    p.Height = m�ret;
                    p.Width = m�ret;
                    p.Left = m�ret * ioszlop;
                    p.Top = m�ret * sor;
                    p.BackColor = Color.FromArgb(random.Next(0,255), 0, 0);
                }
            }
        }
    }
}