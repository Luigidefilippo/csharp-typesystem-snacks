// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//SNACK 1 
//Console.WriteLine("Inserisci il primo numero:");
//if (int.TryParse(Console.ReadLine(), out int numero1))
//{
//    Console.WriteLine("Inserisci secondo numero:");
//    if (int.TryParse(Console.ReadLine(), out int numero2))
//    {
//        int numeroMaggiore = Math.Max(numero1, numero2);
//        Console.WriteLine($"il numero maggiore tra {numero1} e {numero2} é: {numeroMaggiore} ");
//    }
//    else
//    {
//        Console.WriteLine("il numero secondo numero inserito non è valido ");
//    }
//}
//else
//{
//    Console.WriteLine("il primo numero inserito non è valido ");
//}


//SNAKC 2

Console.WriteLine("Immettere prima Parola");
string primaParola = Console.ReadLine();

Console.WriteLine("Immettere seconda Parola");
string secondaParola = Console.ReadLine();

if (primaParola.Length < secondaParola.Length)
{
    Console.WriteLine($"La parola è più corta è: {primaParola}");
    Console.WriteLine($"La parola più lunga è: {secondaParola} ");

}
else if (primaParola.Length > secondaParola.Length)
{
    Console.WriteLine($"La parola è più corta è: {secondaParola}");
    Console.WriteLine($"La parola più lunga è: {primaParola}");
}
