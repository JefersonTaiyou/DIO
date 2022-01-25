namespace PrimeiroProjeto
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
    
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
    
}
