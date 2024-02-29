using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikszofttech
{
    internal class Szamologomb : VillogoGomb
    {

        public int szám = 1;
        public Szamologomb() 
        
            
            {
            MouseClick += Szamologomb_MouseClick;
            Text = szám.ToString();
            }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            Text = szám++.ToString();

            
            
            
        }
    }
}
