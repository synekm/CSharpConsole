namespace CSharpConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person one = new("one", 16, 100);
            Console.WriteLine($"ones hp je {one.Hp}");
            one.Hp = 69;
            Console.WriteLine($"ones hp po set je {one.Hp}");

            Console.WriteLine("    /\\ ");
            Console.WriteLine("   /  \\ ");
            Console.WriteLine("  /    \\ ");
            Console.WriteLine(" /      \\ ");
            Console.WriteLine("/________\\ ");

            Console.ReadLine();

            // Promenne
            // Primo vypsana
            string JmenoHrdiny = "John";

            // Uvedeni promenne
            int VekHrdiny;

            // Vypsani pozdeji
            VekHrdiny = 35;

            Console.WriteLine("There once was a man named " + JmenoHrdiny);
            Console.WriteLine("He was " + VekHrdiny + " years old");

            JmenoHrdiny = "Tom";

            Console.WriteLine("He really liked the name " + JmenoHrdiny);
            Console.WriteLine("But he didn't like being " + VekHrdiny);

            Console.ReadLine();

            string Fraze = "Text";
            char Charakter = 'A';
            int CeleCislo = 0;
            float MenePresneCislo = 3.2f;
            float F = 3.33333f;
            float FFF = F + F + F;
            Console.WriteLine(FFF);
            double VicePresne = 3.33333;
            double vv = VicePresne + VicePresne + VicePresne;
            Console.WriteLine(vv);
            decimal Nejpresnejsi = 3.33333333333333333333m;
            decimal dd = Nejpresnejsi + Nejpresnejsi + Nejpresnejsi;
            Console.WriteLine(dd);

            Console.WriteLine("Hello");
            Console.WriteLine(30);

            Console.ReadLine();

            Console.WriteLine("1\n2");
            Console.WriteLine("\"");

            string Test = "School is cool";
            string Test1 = "School" + " is cool";

            Console.WriteLine(Test);
            Console.WriteLine(Test1);

            Console.WriteLine(Test1.Length);
            Console.WriteLine(Test1.ToUpper());
            Console.WriteLine(Test1.ToLower());
            Console.WriteLine(Test1.Contains("is"));
            Console.WriteLine(Test1[0]);
            Console.WriteLine(Test1.IndexOf("is"));
            string e = "--A --p --Nill --Null";
            int indexNill = e.IndexOf("--Nill");
            int indexNull = e.IndexOf("--Null");
            if (indexNull > indexNill)
            {
                Console.WriteLine("Pouzij Nill");
            }
            else
            {
                Console.WriteLine("Pouzij Null");
            }
            Console.WriteLine(Test1.Substring(4,7));
        }
    }
}