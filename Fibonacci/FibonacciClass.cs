


public class FibonacciClass
{
    public static List<int> Fibo(int n)
    {
        List<int> valores = new();

        int x = 1, y = 0, z = 0;
        valores.Add(0);
        while (n >= z)
        {
            z = x + y;
            valores.Add(z);
            y = x;
            x = z;
        }

        return valores;
    }

    public static void Imprimir(List<int> valores)
    {
        valores.ForEach(x =>
        {
            Console.WriteLine(x);
        });
    }
}