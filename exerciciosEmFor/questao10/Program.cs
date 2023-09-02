namespace questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Um Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            double calculo;
            
            for(int i = 0; i <= 10; i++) 
            {
                calculo = numero * i;
                Console.WriteLine(numero +"x" + i + "=" + calculo);
                
            }

            {
                Console.ReadKey();
            }
        }
    }
}