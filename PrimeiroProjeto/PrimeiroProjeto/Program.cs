﻿using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {




            /*
            *(12) EXERCICIOS
            Console.WriteLine("Digite um valor inteiro: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor inteiro: ");
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0) {
                Console.WriteLine("São multiplos!");
            } else {
                Console.WriteLine("Não são multiplos!");
            };
            */


            /*
            *(11) EXERCICIOS
            Console.WriteLine("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            if( x >= 0 ) {
                Console.WriteLine("POSITIVO");
            }else {
                Console.WriteLine("NEGATIVO");
            };
            

            /*
            *(10) EXERCICIOS
            Console.WriteLine("Código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 1: ");
            double val1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Código da peça 2: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 1: ");
            double val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pagar = (num1 * val1) + (num2 * val2);
            Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
            *(9) EXERCICIOS 
            Console.WriteLine("Insira o código do funcionário: ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira as horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de sua hora: ");
            double valHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valHoras;
            Console.WriteLine("NUMBER = " + cod);
            Console.WriteLine("SALARY = U$ " + salario.ToString("f2", CultureInfo.InvariantCulture));
            */


            /*
            *(8) EXERCICIOS 
            Console.WriteLine("Insira um número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira mais um número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira mais um número: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o último número: ");
            int d = int.Parse(Console.ReadLine());
            int diferenca = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA = " + diferenca);
            */


            /*
            *(7) EXERCICIOS 
            //PRIM.OPÇÃO
            Console.WriteLine("Entre com um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com mais um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("SOMA = " + num3);
            //SEG.OPÇÃO
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int c = a + b;
            Console.WriteLine("SOMA = " + c);
            */


            /*
            *(6)  VETOR,SPLIT,PARSE /  TOSTRING("F2,CULTUREINFO.INVARIANTCULTURE / inserindo dados+espaço e dados+enter
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura: ");           
            string[] dados = Console.ReadLine().Split(' ');
            string ultNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);
            Console.WriteLine("SEUS DADOS FORAM: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(dados[0]); // Posso colocar "ultNome" que tm dá certo
            Console.WriteLine(dados[1]); // Posso colocar "idade" que tm dá certo
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); //Se colocar "dados[2]" não d´´a certo!!??
            */


            /*
            *(5) VETOR /  TOSTRING("F2,CULTUREINFO.INVARIANTCULTURE / (dessa forma cada dado inserido precisa + Espaço)
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Seus dados foram: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[2]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[3]);
            Console.WriteLine(vet[0]);
            */


            /*
            *(4) PARSE / CULTUREINFO.INVARIANTCULTURE / (dessa forma cada dado inserido precisa + Enter)
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
            *(3) SPLIT / CONSOLE.READLINE
            string s = Console.ReadLine(); //Outra maneira é tirar essa parte..
            string[] vet = s.Split(' ');   //string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p2);
            */


            /*
            *(2) SAÍDA DE DADOS / PLACEHOLDER, INTERPOLAÇÃO, CONCATENAÇÃO
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3",CultureInfo.InvariantCulture));
            */


            /*
            *(1) SAÍDA DE DADOS / CONCATENAÇÃO, CULTUREINFO.INVARIANTCULTURE
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("{0} com {1} anos de idade tem R${2:F2} de saldo no banco.", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e R${saldo:F2} no banco.");
            // Essa é a única forma possivel de passar o (.) no lugar da (,) usando => "saldo".ToString("F2",CultureInfo.InvariantCulture)
            Console.WriteLine(nome + " tem " + idade + " anos de idade e " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " de reais no banco." ); 
            */

        }
    }
}