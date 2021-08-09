//Console.WriteLine("Entre com seu nome completo:");
//string Nome = Console.ReadLine();

//Console.WriteLine("Quantos quartos ?:");
//int Quartos = int.Parse(Console.ReadLine());


//Console.WriteLine("Preço de um Produto :");
//double Preco = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);


//Console.WriteLine("Entre com Ultimo nome, idade e altura ( mesma linha ):");


//string Identidade = Console.ReadLine();
//string[] vet =  Identidade.Split(' ');
//string LastName = vet[0];
//int YearsOld = int.Parse(vet[1]);
//float Heigth = float.Parse(vet[2]);



//Console.WriteLine("Voce digitou");
//Console.WriteLine("Nome: " + Nome );
//Console.WriteLine("Quartos: " + Quartos);
//Console.WriteLine("Preco:" + Preco);
//Console.WriteLine("Ultimo nome: " +  LastName);
//Console.WriteLine("Idade: " +  YearsOld);
//Console.WriteLine("Altura: " + Heigth);

using System;
using System.Globalization;

namespace Exe_01
{
    class Program


    {


        static void Main(String[] args)
        {


            Pessoa pessoa_1, pessoa_2;

            pessoa_1 = new Pessoa();
            pessoa_2 = new Pessoa();

            Console.WriteLine("ENTRE COM PESSOA 1");
            Console.Write("NOME : ");
            pessoa_1.NOME = Console.ReadLine();
            Console.Write("IDADE : ");
            pessoa_1.IDADE = int.Parse(Console.ReadLine());
            Console.Write("SEXO (EX: F) : ");
            pessoa_1.SEXO =Console.ReadLine();
            Console.Write("Salario : ");
            pessoa_1.SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine("ENTRE COM PESSOA 2");
            Console.Write("NOME : ");
            pessoa_2.NOME = Console.ReadLine();
            Console.Write("IDADE : ");
            pessoa_2.IDADE = int.Parse(Console.ReadLine());
            Console.Write("SEXO (EX: F) : ");
            pessoa_2.SEXO = Console.ReadLine();
            Console.Write("Salario : ");
            pessoa_2.SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ValidacaoIdade(pessoa_1.IDADE, pessoa_2.IDADE);
            MediaSalario(pessoa_1.SALARIO, pessoa_2.SALARIO);

        }


        static int ValidacaoIdade(int idade_1, int idade_2)
        {
            int idade;

            if (idade_1 > idade_2)
            {
                idade = idade_1;
            }
            else
            {
                idade = idade_2;
            }
            return idade;
        }

        static double MediaSalario(double salario_1, double  salario_2)
        {
            double result;
            result = (salario_1 + salario_2 ) / 2;
            return result;
        }

    }

}


//if (pessoa_1.IDADE > pessoa_2.IDADE)
//{

//    Console.WriteLine("Pessoa mais velha: " + pessoa_1.NOME);

//}
//else
//{
//    Console.WriteLine("Pessoa mais velha: " + pessoa_2.NOME);

//}


//Triangulo x, y;
//x = new Triangulo();
//y = new Triangulo();

//Console.WriteLine("ENTRE COM AS MEDIDAS DO TRINAGULO X");

//x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("ENTRE COM AS MEDIDAS DO TRINAGULO Y");

//y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//double p = (x.A + x.B + x.C) / 2.0;
//double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

//p = (y.A + y.B + y.C) / 2.0;
//double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


//if (areaX > areaY)
//{

//    Console.WriteLine("Area Maior é Area X : " + areaX.ToString("F3" , CultureInfo.InvariantCulture));

//}
//else
//{

//    Console.WriteLine("Area Maior é Area Y : " + areaY.ToString("F3" ,  CultureInfo.InvariantCulture));
//}

//Console.WriteLine("Area x = " + areaX );
//Console.WriteLine("Area y = " + areaY);

//Console.Write("ESCREVA A QUANTIDADE DE NUMEROS :");


//double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//int soma = 0;

//for ( double count = 1 ; count <= N; count ++)
//{

//    Console.Write("VALOR #{0} :" , count);
//    int valor = int.Parse(Console.ReadLine());
//    soma += valor;
//}

//Console.WriteLine("SOMA = " + soma );





//Console.Write("Escreva um Numero: ");
//double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//while (x >= 0.0)
//{

//    double raiz = Math.Sqrt(x);
//    Console.WriteLine("Resultado :" + raiz.ToString("F3", CultureInfo.InvariantCulture));
//    Console.Write("Digite outro Numero:");
//    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//}

//Console.WriteLine("NUMERO INVALIDO");

//static void Main(string[] args)

//{


//    Console.WriteLine("DIGITE 3 NUMEROS");
//    string Numero = Console.ReadLine();

//    string[] vet = Numero.Split(' ');
//    int Num_1 = int.Parse(vet[0]);
//    int Num_2 = int.Parse(vet[1]);
//    int Num_3 = int.Parse(vet[2]);


//    double resultado = Maior(Num_1, Num_2, Num_3);
//    Console.WriteLine("O maior Numero eh:" + resultado);

//}
//static int Maior(int a, int b, int c)
//{
//    int m;

//    if (a > b && a > c)
//    {
//        m = a;
//    }
//    else if (b > c)
//    {
//        m = b;
//    }
//    else
//    {
//        m = c;
//    }

//    return m;

//}

