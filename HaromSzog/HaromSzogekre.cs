using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromSzogekkree
{
    public class HaromSzogekre
    {
        public string HaromSzogek(int a,int b,int c)
        {
            string szerkesztheto =  "";

            if (a + b > c && b < a + c && c < a + b)
            {
               

                if (a == b && a == c && b == c)//1
                {
                    szerkesztheto = "szabályos háromszög";
                }
                if(b==c && a != c)//2
                {
                    szerkesztheto = "egyenlő szárú háromszög";
                }
                if(a!=b && b != c && a != c)//3
                {
                    szerkesztheto = "általános háromszög";
                }

            }
            else
            {
                if (a < b || a < c)//4
                {
                    szerkesztheto = "nem háromszög, ha nem felel meg a hárömszög-egyenlőség tételének";
                }
                if (a == 0 || b == 0 || c == 0)//5
                {
                    szerkesztheto = "nem háromszög, mert az egyik oldal nulla";
                }
                if (a < 0 || b < 0 || c < 0) //6
                {
                    szerkesztheto = "nem háromszög, mert az egyik oldal negatív";
                }
            }

            return szerkesztheto;
        }
        static void Main(string[] args)
        {
        }
    }
}
