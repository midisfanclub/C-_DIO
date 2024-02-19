using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using C__DIO;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine("percorrendo o array com o for:");
for (int contador = 0; contador < listaString.Count; contador ++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

Console.WriteLine("percorrendo o array com foreach: ");
foreach (string item in listaString)
{
    int contador_foreach = 0;
    Console.WriteLine($"Posição N° {contador_foreach} - {item}");
    contador_foreach ++;
}













// int[] array_inteiros = new int[3];

// array_inteiros[0] = 72;
// array_inteiros [1] = 64;
// array_inteiros [2] = 50;

// int[] array_dobrado = new int [array_inteiros.Length * 2];
// Array.Copy(array_inteiros, array_dobrado, array_inteiros.Length);

// //Array.Resize(ref array_inteiros, array_inteiros.Length * 2);

// Console.WriteLine("percorrendo o array com o for:");
// for (int contador = 0; contador < array_inteiros.Length; contador ++)
// {
//     Console.WriteLine($"Posição N° {contador} - {array_inteiros[contador]}");
// }


// Console.WriteLine("percorrendo o array com foreach: ");

// int contador_foreach = 0;
// foreach (int valor in array_inteiros)
// {
//     Console.WriteLine($"Posição N° {contador_foreach} - {valor}");
//     contador_foreach ++;
// }


















// string opcao;

// while(true)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de cliente:");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
        
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;    

//         default:
//         Console.WriteLine("opção inválida");
//         break;
//     }
// }















// int soma = 0, numero;

// do
// {
//     Console.WriteLine("digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total = {soma}");















// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }











// int numero = 5;



// for (int contador = 0; contador <= 10; contador++)
// {
// Console.WriteLine($"{numero} x {contador} = {numero * contador} ");

// }




















// Calculadora calc = new Calculadora(); //instaciamos a classe Calculadora

// calc.Somar(10, 30);
// calc.Subtrair(13, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Tangente(30);
// calc.Coseno(30);























//Pessoa p = new Pessoa();