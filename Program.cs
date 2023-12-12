using System;
using System.Net;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

// 1 - Fazer um programa que some dois numeros
// class Program 
// {
//     static void Main() {
//         int num1 = 5;
//         int num2 = 7;
//         int soma = num1 + num2;

//         Console.WriteLine("A soma é: " + soma);
//     }
// }


// 2 - Criar um programa que calcule a média de um conjunto de números

// class Program
// {
//     static void Main() {
//         int[] numeros = { 5, 8, 12, 3, 6};
//         double soma = 0;

//         foreach (int num in numeros)
//         {
//             soma += num;
//         };

//         double media = soma / numeros.Length;

//         Console.WriteLine("A média dos núemros é: " + media);
//     }
// }


// 3 - Implementar uma função para verificar se um núemro é primo

// class Program
// {
//     static bool IsPrimo(int num)
//     {
//         if (num < 2) return false;
//         for (int i = 2; i <= Math.Sqrt(num); i++)
//         {
//             if (num % i == 0) return false;
//         }
//         return true;
//     }
//     static void Main()
//     {
//         int numero = 13;
//         if (IsPrimo(numero))
//         {
//             Console.WriteLine(numero + " é primo!");
//         }
//         else 
//         {
//             Console.WriteLine(numero + " não é primo!");
//         }


//     }
// }


// 4 - Escrever um programa para converter uma temperatura de Celsius para Fahrenheit

// class Program
// {
//     static void Main()
//     {
//         double celsius = 28;
//         double fahrenheit = (celsius * 9/5) + 32;

//         Console.WriteLine(celsius + "°C equivale a " + fahrenheit + "°F");
//     }
// }


// 5 -Criar um programa que inverta uma string

// class Program
// {
//     static void Main()
//     {
//         string original = "Hoje é Sexta";
//         char[] reversed = original.ToCharArray();
//         Array.Reverse(reversed);

//         Console.WriteLine(new string(reversed));
//         {

//         }
//     }
// }


// 6 - Construir uma calculadora simples com as operações básicas(+,-,*,/)

// class Program
// {
//     static void Main()
//     {
//         double num1 = 10;
//         double num2 = 5;
//         char operacao = '-';
//         double resultado = 0;
//         switch(operacao)
//         {
//             case '+': resultado = num1 + num2; break;
//             case '-': resultado = num1 - num2; break;
//             case '*': resultado = num1 * num2; break;
//             case '/': resultado = num1 / num2; break;
//         }

//         Console.WriteLine("O resultado é: " + resultado);
//     }
// }


//  7 - Implementar um programa que valide um CPF

// class Program
// {
//     static void Main()
//     {
//         string cpf = "12345678900";
//         bool cpfValido = ValidarCPF(cpf);        
//         if (cpfValido)
//         {
//             Console.WriteLine("CPF válido!");
//         }
//         else
//         {
//             Console.WriteLine("CPF inválido!");
//         }        
//     }
//     static bool ValidarCPF(string cpf)
//     {
//         cpf = new string(cpf.Where(char.IsDigit).ToArray());
//         if (cpf.Length !=11)
//         {
//             return false;
//         }
//         if (cpf.Distinct().Count() == 1)
//         {
//             return false;
//         }
//         else
//         {
//             return true;
//         }
//     }

// }


//  8 - Escrever um programa que conte quantas palavras há em uma frase

// string frase = "OLá, isso é incrível!";
// int numeroPalavras = frase.Split(' ').Length;

// Console.WriteLine("O número de palavras na frase é: " + numeroPalavras);


//  9 - Criar uma função que retorne a soma dos digitos de um número.

// int SomaDigitos(int numero)
// {
//     int soma = 0;
//     foreach (char digito in numero.ToString())
//     {
//         soma += int.Parse(digito.ToString());
//     }
//     return soma;
// }

// int numero = 123456;
// int resultado = SomaDigitos(numero);

// Console.WriteLine("A soma dos digitos do número é: " + resultado);


// 10 - Implementar um programa que ordene um array de números

// int[] numeros = { 5, 2, 8, 3, 1 };
// Array.Sort(numeros);

// foreach (int numero in numeros)
// {
//     Console.WriteLine(numero);
// }


//  11 - Construir um programa que calcule a área de um triangulo

// double baseTriangulo = 10;
// double altura = 5;
// double area = baseTriangulo * altura / 2;

// Console.WriteLine("A área do triângulo é: " + area);


//  12 - Escrever um código que verifique se um ano é bissexto

// int ano = 2024;
// bool bissexto = DateTime.IsLeapYear(ano);

// Console.WriteLine($"O ano {ano} é bissexto? {bissexto}");



// 13 - Implementar um programa que encontre o maior elemento de um array

// int[] numeros = { 5 , 2 ,8 ,3, 1};
// {
//     int maiorElemento = numeros.Max();

//     Console.WriteLine("O maior elemento do array é: " + maiorElemento);
// }


//  14 - Criar uma função que verifique se uma palavra é um palindromo

// public class Program 
// {
//     public static bool VerificaPalindromo(string palavra)
//     {
//         string invertida = new string(palavra.Reverse().ToArray());
//         return palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase);

//     } 
//     public static void Main()
//     {
//     string palavra = "radar";
//     bool ehPalindromo = VerificaPalindromo(palavra);

//     Console.WriteLine($"A palavra '{palavra}' é um palíndromo? {ehPalindromo}");

//     }
// }


//  15 - Construir um programa que solicite ao usuario um valor e informe se é positivo ou negativo.


// Console.WriteLine("Digite um valor:");

// int valor = Convert.ToInt32(Console.ReadLine());
// if (valor >= 0)
// {
//     Console.WriteLine("O valor é positivo!");
// }
// else
// {
//     Console.WriteLine("O valor é negativo!");
// }


//  16 - Escrever um código que calcule o fatorial de um número

// int numero = 5;
// int fatorial = 1;

// for (int i =1; i <= numero; i++)
// {
//     fatorial *= i;
// }

// Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);


//  17 - Implementar um programa que verifique se um numero é multiplo de outro


// Console.WriteLine("Digite o primeiro número:");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite o segundo número:");

// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("O primeiro número é multiplo do segundo número!");
// }
// else
// {
//     Console.WriteLine("O primeiro número não é multiplo do segundo número!");
// }


// 18 - Criar uma função que conte quantas vezes um determinado caractere aparece em uma string

// int ContarCaractere(string texto, char caractere)
// {
//     return texto.Count(c => c == caractere);
// }

// string minhaString = "Olá, vamos estudar C#";
// char meuCaractere = 'a';
// int quantidade = ContarCaractere(minhaString, meuCaractere);

// Console.WriteLine("O caractere'" + meuCaractere + "' aparece " + quantidade + " vezes na string.");


//  19 - Construir um programa que ordene os elementos de uma matriz

// int[] matriz = { 5, 2, 9, 1, 3};
// Array.Sort(matriz);

// foreach (int elemento in matriz)
// {
//     Console.WriteLine(elemento);
// }


//  20 - Escrever um código que valide um email



// public class Program
// {
//     public static bool ValidaEmail(string email)
//     {
//         
//         string padrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

//         
//         return Regex.IsMatch(email, padrao);
//     }

//     public static void Main()
//     {
//         
//         string email1 = "g.salomone@live.com";
//         string email2 = "aria@live.com";
//         string email3 = "outro.usuario@dominio.com";

//         
//         Console.WriteLine($"{email1} é um e-mail válido? {ValidaEmail(email1)}");
//         Console.WriteLine($"{email2} é um e-mail válido? {ValidaEmail(email2)}");
//         Console.WriteLine($"{email3} é um e-mail válido? {ValidaEmail(email3)}");
//     }
// }





















// Quiz Lorena
// using System;

// public class Teste
// {
//     public static void Main(string[] args)
//     {
//         int i = 5, j;
//         Console.WriteLine(j = i * 2);
//     }
// }




