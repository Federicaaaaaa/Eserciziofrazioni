using System;

namespace Eserciziofrazioni
{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        private readonly static Fraction Zero = new Fraction(0, 1);

        public Fraction(int n, int d)
        {
            Semplifica(ref n, ref d);

            if (d < 0)
            {
                d = -d;
                n = -n;
            }

            N = n;
            D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        

        public override string ToString()
        {
            return $"{N}/{D}";
        }


        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        //Operatore == --> ATTENZIONE PERCHE' C'E' BISOGNO ANCHE DEL =!
        public static bool operator==(Fraction f1, Fraction f2)
        {
            if(object.ReferenceEquals(f1,null))
            {
                if (object.ReferenceEquals(f2, null))
                    return true;
                return false;
            }
            if(object.ReferenceEquals(f2, null))
            {
                return false;
            }
            return f1.N == f2.N && f1.D == f2.D;
        }
        public static bool operator !=(Fraction f1, Fraction f2)

        {
            return !(f1 == f2);
        }

        //TryParse
        public static bool TryParse(string s, out Fraction v)
        {
            String[] parts = s.Split('/');
            if (parts.Length != 2)
            {
                //è molto importante mettere il v null perché non possiamo uscire dal metodo
                //fino a quando non abbiamo assegnato un valore a v (out)!!!
                v = null;
                return false;
            }

            int n;
            if (int.TryParse(parts[0], out n))
            {
                v = null;
                return false;
            }

            int d;
            if (int.TryParse(parts[1], out d))
            {
                v = null;
                return false;
            }

            v = new Fraction(n, d);
            return true;
        }

        //operatori
        public static Fraction operator+(Fraction a, Fraction b)
        {
            return new Fraction(a.N * b.D + a.D * b.N, a.D * b.D);
        }

        public static Fraction operator-(Fraction a, Fraction b)
        {
            return new Fraction(a.N * b.D - a.D * b.N, a.D * b.D);
        }

        public static Fraction operator*(Fraction a, Fraction b)
        {
            return new Fraction(a.N * b.N, a.D * b.D);
        }

        public static Fraction operator/(Fraction a, Fraction b)
        {
            return new Fraction(a.N * b.D, a.D * b.N);
        }

    } 
}
