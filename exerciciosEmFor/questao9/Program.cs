namespace questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de Fibonacci");
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int novoNumero;
            int finabocci; 

            for (int i = 0; i <=20; i++)
            {
                finabocci = numeroAnterior + numeroAtual;
                Console.WriteLine(finabocci);
                numeroAnterior = numeroAtual;
                numeroAtual = finabocci;
            }
        }
    }
}