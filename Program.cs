using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        Iphone iphone = new Iphone ("Apple");
        iphone.Ligar();
        iphone.ReceberLigacao("Oi, tudo bem?");
        iphone.InstalarAplicativo();

        Console.WriteLine();
        

        Nokia nokia = new Nokia("BUST");
        nokia.Ligar();
        nokia.ReceberLigacao("Hello from iPhone!"); 

        Console.WriteLine();    

    }
}