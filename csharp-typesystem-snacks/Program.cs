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

//Console.WriteLine("Immettere prima Parola");
//string primaParola = Console.ReadLine();

//Console.WriteLine("Immettere seconda Parola");
//string secondaParola = Console.ReadLine();

//if (primaParola.Length < secondaParola.Length)
//{
//    Console.WriteLine($"La parola è più corta è: {primaParola}");
//    Console.WriteLine($"La parola più lunga è: {secondaParola} ");

//}
//else if (primaParola.Length > secondaParola.Length)
//{
//    Console.WriteLine($"La parola è più corta è: {secondaParola}");
//    Console.WriteLine($"La parola più lunga è: {primaParola}");
//}

//SNACK 3 

//int somma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Inserisci il numero {i + 1}");
//    if (int.TryParse( Console.ReadLine(), out int numero ) )
//    {
//        somma += numero;
//    }
//    else
//    {
//        Console.WriteLine("Carattere sconosciuto. Inserisci un numero.");
//        i--;
//    }
//}
//Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");

//SNACK 4 

//int somma = 0;
//for (int numero = 2; numero <= 10; numero++)
//{
//    somma += numero; 
//}

//float media = (float)somma / 9;
//Console.WriteLine($"La somma dei numeri da 2 a 10 è: {somma}");
//Console.WriteLine($"La media dei numeri da 2 a 10 è: {media}");


//SNACK 5 
//Console.WriteLine("Inserisci un numero");
//if (int.TryParse(Console.ReadLine(), out int numero))
//{
//    if (numero % 2 == 0)
//    {
//        Console.WriteLine($"Il numero {numero} è pari ");
//    }
//    else {
//        Console.WriteLine($"Il numero {numero} è dispari , il successivo è {numero + 1}  ");
//            }
//}

//SNACK 6 

//string[] invitati = { "Jay Gatsby", "Daisy Buchanan", "Tom Buchanan", "Jordan Baker", "Myrtle Wilson", "George Wilson" };
//Console.WriteLine("Qual'è il vostro nome Sir : ");
//string nomeInvitato = Console.ReadLine();

//bool invitato = false;

//foreach (string nome in invitati)
//{
//    if (nome.Equals(nomeInvitato , StringComparison.OrdinalIgnoreCase))
//    {
//        invitato = true;
//        break;
//    }
//}
//if (invitato)
//{
//    Console.WriteLine($"Benvenuto , {nomeInvitato}! Siamo lieti di accoglierla ");
//}
//else
//{
//    Console.WriteLine($"Mi dispiace , {nomeInvitato} , non è sulla lista degli invitati "); 
//}


//SNACK 7 

//int[] numeriDispari = new int[6];
//int contatore = 0;

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine($"Inserisci il primo numero: {i + 1}");
//    if (int.TryParse(Console.ReadLine(), out int numero) )
//    {
//        if (numero % 2 != 0)
//        {
//            numeriDispari[contatore] = numero;
//            contatore++;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Valore inserito non valido inserisci correttamente un numero ");
//        i--;
//    }
//}

//Console.WriteLine("Numeri dispari inseriti:");
//for (int i = 0; i < contatore ;i++)
//{
//    Console.WriteLine(numeriDispari[i]);
//}

//SNAKC 8 

int[] numeri = {1,2,3,4,5,6,7,8,9,10};
int somma = 0;
for (int i = 0; i < numeri.Length; i += 2 )
{
    somma += numeri[i];
}
Console.WriteLine($"òa somma degli elementi in posizione dispari è : {somma}");