// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//SNACK 1 
Console.WriteLine("Inserisci il primo numero:");
if (int.TryParse(Console.ReadLine(), out int numero1))
{
    Console.WriteLine("Inserisci secondo numero:");
    if (int.TryParse(Console.ReadLine(), out int numero2))
    {
        int numeroMaggiore = Math.Max(numero1, numero2);
        Console.WriteLine($"il numero maggiore tra {numero1} e {numero2} é: {numeroMaggiore} ");
    }
    else
    {
        Console.WriteLine("il numero secondo numero inserito non è valido ");
    }
}
else
{
    Console.WriteLine("il primo numero inserito non è valido ");
}



