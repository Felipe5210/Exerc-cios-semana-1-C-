internal class Program
{
    public static void Main(string[] args)
    {
        // Exercício 1 Soma de números
        /*int numero1,
            numero2,
            soma;

        Console.Write("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        soma = numero1 + numero2;

        Console.WriteLine($"A soma dos números é: {soma}");


        //Exercício 2 Par ou Ímpar
        /*int numero;
        Console.WriteLine("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }*/

        //Exercício 3 Nome e Idade
        /*  string nome;
          int idade;
  
          Console.Write("Digite o nome do paciente:  ");
          nome = Console.ReadLine();
  
          Console.Write("Digite a idade do paciente: ");
          idade = int.Parse(Console.ReadLine());
  
          Console.WriteLine($"O nome do paciene é {nome}");
  
          if (idade < 18)
          {
              Console.WriteLine("O paciente é menor de idade");
          }
          else if (idade >= 60)
          {
              Console.WriteLine("O paciente é idoso.");
          }
          else
          {
              Console.WriteLine("O paciente é maior de idade");
          }*/

        //Exercício 4 Informações de Veículos
        /*string marca,
            modelo;
        double km;

        Console.Write("Digite a marca do carro: ");
        marca = Console.ReadLine();

        Console.Write("Digite o modelo do carro ");
        modelo = Console.ReadLine();

        Console.Write("Digite a quilometragem rodada do carro ");
        km = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"\n- Marca do carro: {marca}\n- Modelo do carro: {modelo}\n- Quilometragem rodada: {km}"
        );

        if (km > 10000)
        {
            Console.WriteLine("É necessário fazer uma revisão.");
        }*/

        //Exercício 5 Ordenando Números
        /*int[] numeros = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite um numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);
        Console.WriteLine("Os numeros que você digitou em ordem crescente são: ");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"{numeros[i]}");*/

        //Exercício 6 Separando Palavras
        /*string frase = "A linguagem de programação C# é muito poderosa";

        List<string> palavras = new List<string>(frase.Split(" "));

        Console.WriteLine(palavras[palavras.Count - 1]);
    }*/

        //Exercício 7 Números pares
        /* int numero = 0;
 
         while (numero <= 0)
         {
             Console.Write("Digite um numero maior que zero: ");
             numero = int.Parse(Console.ReadLine());
             if (numero <= 0)
             {
                 Console.WriteLine("Erro! \n Tente novamente.");
             }
         }
 
         for (int i = 0; i <= numero; i = i + 2)
         {
             Console.WriteLine(i);
         }*/

        //Exercício 8 O maior número da lista
        /*int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um numero:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);
        Console.WriteLine($"O maior numero digitado é {numeros[numeros.Length - 1]}");*/

        //Exercício 9 Média Aritimética
        /*int quantidade;
        double soma = 0.0;
        double media = 0.0;

        Console.WriteLine(
            "\n Bem vindo(a)! Vamos calcular a média dos valores que você desejar. \n"
        );

        do
        {
            Console.Write(" Digite o total de numeros que deseja calcular a média: ");
            quantidade = int.Parse(Console.ReadLine());
            if (quantidade < 2)
            {
                Console.WriteLine($" Não é possivel calcular a média entre {quantidade} item(ns).");
            }
        } while (quantidade < 2);

        int[] valores = new int[quantidade];
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($" Digite o valor de numero {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
        }

        foreach (int valor in valores)
        {
            soma = soma + valor;
        }

        media = soma / quantidade;

        Console.WriteLine($"\n A média dos valores é: {media}");*/

        //Exercício 9 Calcuadora
        double num1 = 0;
        double num2 = 0;
        char operacao;

        Console.WriteLine(" Bem vindo(a) a calculadora! \n");
        Console.WriteLine("Agora escolha uma operação: ");
        Console.WriteLine("  + : soma");
        Console.WriteLine("  - : subtração");
        Console.WriteLine("  * : multiplicação");
        Console.WriteLine("  / : divisão");
        Console.WriteLine(" Para SAIR digite: ?");

        do
        {
            Console.Write("\n Digite a operação escolhida: ");
            operacao = char.Parse(Console.ReadLine());

            if (operacao != '?')
            {
                Console.Write("\nDigite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("\nDigite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
            }

            if (operacao == '/' && num2 == 0)
            {
                while (num2 == 0)
                {
                    Console.Write(
                        "O divisor não pode ser zero,\npor favor digite o segundo numero novamente: "
                    );
                    num2 = int.Parse(Console.ReadLine());
                }
            }
            switch (operacao)
            {
                case '+':
                    Console.WriteLine("Resposta: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Resposta: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Resposta: " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Resposta: " + (num1 / num2));
                    break;
                case '?':
                    Console.WriteLine("Você escolheu SAIR");
                    Console.WriteLine("Obrigado por utilizar a calculadora!");
                    Console.WriteLine("Tchau!");
                    break;
                default:
                    Console.WriteLine("Opção inválida digite uma opção disponível no menu.");
                    Console.WriteLine("Agora escolha uma operação: ");
                    Console.WriteLine("  + : soma");
                    Console.WriteLine("  - : subtração");
                    Console.WriteLine("  * : multiplicação");
                    Console.WriteLine("  / : divisão");
                    Console.WriteLine(" Para SAIR digite: ?");
                    break;
            }
        } while (operacao != '?');
    }
}
