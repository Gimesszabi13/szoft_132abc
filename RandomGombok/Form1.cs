namespace RandomGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button z = new Button();
            Controls.Add(z);

            z.Left = ClientRectangle.Width / 2 - z.Width / 2;
            z.Top = ClientRectangle.Height / 2 - z.Height / 2;


            int m�ret = 20;

            for (int sor = 0; sor < 20; sor++)
            {
                for (int ioszlop = 0; ioszlop < 20; ioszlop++)
                {
                    Button z = new Randomgomb();
                    Controls.Add(z);
                    z.Height = m�ret;
                    z.Width = m�ret;
                    z.Left = m�ret * ioszlop;+

                    z.Top = m�ret * sor;
                }
            }
        }
    }
    }
}