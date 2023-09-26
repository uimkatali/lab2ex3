namespace lab2ex3
{
    class Program
    {
        /*        Scrieti o functie care va determina daca un numar este sau nu numar prim.

        Apelati-o si afisati-i rezultatul*/

        static public int EstePrim(int x)
        {
            if (x > 1 & x / x == 1)
            {
                Console.WriteLine("X este numar prim!");
            }
            else { Console.WriteLine("X nu este numar prim :D"); }

            return x;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numarPrim = EstePrim(num);
             
        }
       
    }
}