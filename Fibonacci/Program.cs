internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um termo para sequência: ");
        int n = int.Parse(Console.ReadLine());

        List<int> v = FibonacciClass.Fibo(n);
        bool encontrou = false;

        v.ForEach(x =>
        {
            if (x == n)
            {
                encontrou = true;
            }
        });

        if (encontrou)
        {
            FibonacciClass.Imprimir(v);
            Console.WriteLine("Pertence à sequência");
        }
        else
        {
            FibonacciClass.Imprimir(v);
            Console.WriteLine("Não pertence à sequência");
        }
    }
}