using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Equazioni
{
    internal class Eq
    {
        private float delta;
        public float x1;
        public float x2;
        private float a;
        private float b;
        private float c; 


        

        public Eq(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Solu()
        {
            if (a!=0)
            {
                delta = b*b-4*a* c;
                x1 = (-b+(float)Math.Sqrt(delta))/2*a;
                x2 = (+b + (float)Math.Sqrt(delta)) / 2 * a;
                return true;
            }
            return false;

        }
    }
}
