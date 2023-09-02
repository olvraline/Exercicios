class Program


// Lista de exercicios paratransformar em um menu

//1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
//2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
//4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
//5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
//7. Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.
//8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
//9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
//10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
//11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
//12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
//13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.

{
    static int Soma(int a, int b)
    {
        return a + b;
    }
    static int Fatorial(int num)
    { 
        if (num == 0)

            return 1;

        return num * Fatorial(num - 1);
    }
    static bool Eprimo(int num) 
    {
        if (num <= 1)

            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
    static int MaiorValor(List<int> lista)
    {
        int maior = int.MinValue;

        foreach (int num in lista)
        {
            if (num > maior)
                maior = num;
        }
           return maior;
    }
    static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static double Media(List<double> numeros)
    {
        double soma = 0;
        foreach (double num in numeros)
        {
            soma += num;
        }
        return soma / numeros.Count;

    }
    static bool Epalindromo(string palavra)
    {
        palavra = palavra.ToLower();
        int left = 0;
        int right = palavra.Length - 1;
        while (left < right)
        {
            if (palavra[left] != palavra[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
    static double CelsiusParaFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
    static int StringsMaisDe5Caracteres(string[] strings)
    {
        int count = 0;
        foreach (string str in strings)
        {
            if (str.Length > 5)
                count++;
        }
        return count;
    }
    static int MDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static List<int> NumerosPares(List<int> lista)
    {
        List<int> pares = new List<int>();
        foreach (int num in lista)
        { 
            if (num % 2 == 0)
                pares.Add(num);
        }
        return pares;
    }
    static int ContarElemento(List<int> lista, int elemento)
    {
        int count = 0;
        foreach (int num in lista)
        {
            if (num == elemento)
                count++;
        }
        return count;
    }
    static string InverterCase(string str)
    {
        char[] stringInversa = str.ToCharArray();
        for (int i = 0; i < stringInversa.Length; i++)
        {
            if (char.IsUpper(stringInversa[i]))
                stringInversa[i] = char.ToLower(stringInversa[i]);

            else if (char.IsLower(stringInversa[i]))
                stringInversa[i] = char.ToUpper(stringInversa[i]);
        }
        return new string(stringInversa);
    }
    static List<int> Fibonacci(int numero)
    {
        List<int> listaNum = new List<int>();
        int a = 0, b = 1;
        for (int i = 0; i < numero; i++)
        {
            listaNum.Add(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
        return listaNum;
    }
    static string VerificarSinal(int num)
    {
        if (num > 0)
            return "positivo";

        else if (num < 0)
           return "negativo";

        else
            return "zero";
    }
    static void Main(string[] args)

    {

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Soma de dois números inteiros");
            Console.WriteLine("2. Fatorial de um número inteiro");
            Console.WriteLine("3. Verificar se um número é primo");
            Console.WriteLine("4. Maior valor em uma lista de inteiros");
            Console.WriteLine("5. Inverter uma string");
            Console.WriteLine("6. Média de uma lista de números reais");
            Console.WriteLine("7. Verificar se uma string é um palíndromo");
            Console.WriteLine("8. Converter Celsius para Fahrenheit");
            Console.WriteLine("9. Contar strings com mais de 5 caracteres");
            Console.WriteLine("10. Máximo Divisor Comum (MDC)");
            Console.WriteLine("11. Números pares em uma lista");
            Console.WriteLine("12. Contar ocorrências de um elemento em uma lista");
            Console.WriteLine("13. Inverter o caso das letras em uma string");
            Console.WriteLine("14. Série de Fibonacci");
            Console.WriteLine("15. Verificar o sinal de um número");
            Console.WriteLine("0. Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());


            switch (opcao)

            {
                case 1:
                    Console.WriteLine("Digite dois números inteiros:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Soma: {Soma(num1, num2)}");

                    break;

                case 2:
                    Console.WriteLine("Digite um número inteiro:");
                    int numFatorial = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Fatorial: {Fatorial(numFatorial)}");

                     break;

                case 3:
                    Console.WriteLine("Digite um número inteiro:");
                    int numPrimo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"É primo: {Eprimo(numPrimo)}");

                    break;

                case 4:
                    Console.WriteLine("Digite uma lista de inteiros separados por espaço:");
                    List<int> listaNumeros = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                    Console.WriteLine($"Maior valor: {MaiorValor(listaNumeros)}");

                    break;

                case 5:
                    Console.WriteLine("Digite uma string:");
                    string str = Console.ReadLine();
                    Console.WriteLine($"String invertida: {InverterString(str)}");

                    break;

                case 6:
                    Console.WriteLine("Digite uma lista de números reais separados por espaço:");
                    List<double> listaReais = new List<double>(Array.ConvertAll(Console.ReadLine().Split(), double.Parse));
                    Console.WriteLine($"Média: {Media(listaReais)}");

                    break;

                case 7:
                    Console.WriteLine("Digite uma string:");
                    string strPalindromo = Console.ReadLine();
                    Console.WriteLine($"É palíndromo: {Epalindromo(strPalindromo)}");

                    break;

                case 8:
                    Console.WriteLine("Digite a temperatura em graus Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Temperatura em Fahrenheit: {CelsiusParaFahrenheit(celsius)}");

                    break;

                case 9:
                    Console.WriteLine("Digite umalista de strings separadas por espaço:");
                    string[] listaStrings = Console.ReadLine().Split();
                    Console.WriteLine($"Quantidade de strings com mais de 5 caracteres: {StringsMaisDe5Caracteres(listaStrings)}");

                    break;

                case 10:
                    Console.WriteLine("Digite dois números inteiros:");
                    int numero1 = int.Parse(Console.ReadLine());
                    int numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"MDC: {MDC(numero1, numero2)}");

                    break;

                case 11:
                    Console.WriteLine("Digite uma lista de inteiros separados por espaço:");
                    List<int> listaNumerosPares = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                    Console.WriteLine($"Números pares: {string.Join(", ", NumerosPares(listaNumerosPares))}");

                    break;

                case 12:
                    Console.WriteLine("Digite uma lista de inteiros separados por espaço:");
                    List<int> listaContarElemento = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                    Console.WriteLine("Digite o elemento a ser contado:");
                    int elemento = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ocorrências do elemento: {ContarElemento(listaContarElemento, elemento)}");

                    break;

                case 13:
                    Console.WriteLine("Digite uma string:");
                    string strInverterCase = Console.ReadLine();
                    Console.WriteLine($"String com casos invertidos: {InverterCase(strInverterCase)}");

                    break;

                case 14:
                    Console.WriteLine("Digite o número de termos da série de Fibonacci:");
                    int numTermos = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Série de Fibonacci: {string.Join(", ", Fibonacci(numTermos))}");

                    break;

                case 15:
                    Console.WriteLine("Digite um número inteiro:");
                    int numSinal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sinal: {VerificarSinal(numSinal)}");

                    break;

                case 0:
                    Console.WriteLine("Saindo do programa...");

                    return;

                default:
                    Console.WriteLine("Opção inválida.");

                    break;
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}