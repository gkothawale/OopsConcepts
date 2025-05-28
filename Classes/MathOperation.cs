namespace OopsConcepts.Classes
{
    public class MathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }


        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

       
      
        public string Add(string a, string b)
        {
            return string.Concat(a, b);
        }

        public string Add(string a, string b, string c)
        {
            return string.Concat(a, b, c);
        }

    }
}
