using System.Formats.Asn1;
using C__DIO;


    int estoque = 10;
    int quantidade_compra = 0;
    bool venda = quantidade_compra > 0 && estoque >= quantidade_compra;


    Console.WriteLine($"quantidade em estoque: {estoque}");
    Console.WriteLine($"Quantidade compra: {quantidade_compra}");
    Console.WriteLine($"É possível realizar a compra?\n{venda}");


    if (quantidade_compra == 0)
    {
        Console.WriteLine("Venda inválida");
    }
    else if (venda)
    {
        Console.WriteLine("Venda realizada");
    } 
    else
    {
        Console.WriteLine("não temos quantidade de produto suficiente no estoque");
    }
