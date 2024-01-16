using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int opcio = 0;

        while (true)
        {
            Menu(opcio);
            ConsoleKeyInfo tecla = Console.ReadKey();

            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow:
                    if (opcio > 1)
                    {
                        opcio = opcio - 1;
                    }
                    else opcio = 9;
                    
                    break;
                case ConsoleKey.DownArrow:
                    if (opcio < 9)
                    {
                        opcio = opcio + 1;
                    }
                    else opcio = 1;
                   
                    break;
                case ConsoleKey.Enter:
                    Switch(opcio);
                    break;
            }
        }
    }

    static void Menu(int opcio)
    {
        Console.Clear();
        Console.WriteLine("┌───────────────────────────────────┐");
        Console.WriteLine("│                MENÚ               │");
        Console.WriteLine("│┌─────────────────────────────────┐│");
        for (int i = 0; i < 10; i++)
        {
            if (i == opcio)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            switch (i)
            {
                case 1:
                    Console.WriteLine("││ 1. Màxim                        ││");
                    break;
                case 2:
                    Console.WriteLine("││ 2. MCD                          ││");
                    break;
                case 3:
                    Console.WriteLine("││ 3. MCM                          ││");
                    break;
                case 4:
                    Console.WriteLine("││ 4. Factorial                    ││");
                    break;
                case 5:
                    Console.WriteLine("││ 5. Combinatori                  ││");
                    break;
                case 6:
                    Console.WriteLine("││ 6. Mostrar Divisor Major        ││");
                    break;
                case 7:
                    Console.WriteLine("││ 7. Es Primer                    ││");
                    break;
                case 8:
                    Console.WriteLine("││ 8. Primers Números Primers      ││");
                    break;
                
                case 9:
                    Console.WriteLine("││                                 ││");
                    Console.WriteLine("││ 0. Sortir                       ││");
                    break;
            }

            Console.ResetColor();
        }
        Console.WriteLine("│└─────────────────────────────────┘│");
        Console.WriteLine("└───────────────────────────────────┘");
    }

    static void Switch(int opcio)
    {
        Console.Clear();
        switch (opcio)
        {
            case 9:
                Console.WriteLine("    / \\__\r\n  (    @\\___\r\n  /         O\r\n /   (_____/\r\n/_____/ADEU!");
                Environment.Exit(0);
                break;
            case 1:
                Console.WriteLine($"--------- MÀXIMS ---------");
                int num1 = IntroduirValor();
                int num2 = IntroduirValor();
                int resultat = Maxim(num1, num2);
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.WriteLine($"El número més gran es {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 2:
                Console.WriteLine($"----------- MCD -----------");
                num1 = IntroduirValor();
                num2 = IntroduirValor();
                resultat = MCD(num1, num2);
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.WriteLine($"El resultat es: {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 7:
                Console.WriteLine($"----------- MCM -----------");
                num1 = IntroduirValor();
                bool Primer = EsPrimer(num1);
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.WriteLine($"El resultat es: {Primer}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
                
        }
    }

    static int IntroduirValor()
    {
        Console.Write("Escriu el valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        return valor;
    }

    static int Maxim(int num1, int num2)
    {
        int res = 0;

        if (num1 > num2) res = num1;
        else res = num2;
        return res;
    }

    static int MCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }

        return num1;
    }

    static bool EsPrimer(int num1)
    {
        bool res = false;

        int i = 2, divisor = 0;

        while (i <= num1)
        {
            if (num1 % i == 0)
                divisor++;
            i++;
        }
        if (divisor == 1) res = true;
        return res;
    }
    
}


/*using System.Net.Http.Headers;
using System.Threading;

int opcio = 1;

//MENU
while(opcio > 0 && opcio < 9)
{
    Console.Write(" 0. Sortir\n 1. Màxim\n 2. MCD\n 3. MCM\n 4. Factorial \n 5. Combinatori\n 6. Mostrar Divisor Major\n 7. Es Primer\n 8. Primers Numeros Primers\n");
    Console.Write("Quina Opcio vols?: ");
    opcio = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Switch(opcio);
}
Console.WriteLine("Adeu");

//METODES
//SWITCH QUE BUSCA LA OPCIO

static void Switch(int opcio){ 
switch (opcio)
{
    case 0:
        opcio = 0; 
        break;

    case 1:
        int num1 = IntroduirValor();
        int num2 = IntroduirValor();
        int resultat = Maxim(num1, num2);
        Console.WriteLine($"El resultat es: {resultat}");
        Thread.Sleep(4000);
        Console.Clear();
        break;

    case 2:
        num1 = IntroduirValor();

        num2 = IntroduirValor();

        resultat = MCD(num1, num2);
        Console.WriteLine($"El resultat es: {resultat}");
        Thread.Sleep(4000);
        Console.Clear();
        break;

    case 7:
        num1 = IntroduirValor();
        bool Primer = EsPrimer(num1);
        Console.WriteLine($"El resultat es: {Primer}");
        Thread.Sleep(4000);
        Console.Clear();
        break;
    }
}


//INTRODUIR VALOR
static int IntroduirValor()
{
    Console.Write("Escriu el valor: ");
    int valor = Convert.ToInt32(Console.ReadLine());
    return valor;
}
//Maxim
static int Maxim(int num1, int num2)
{
    int res = 0;

    if (num1 > num2) res = num1;
    else res = num2;
    return res;
}

//MCD

static int MCD(int num1, int num2)
{

    while (num2 != 0)
    {
        int temp = num2;
        num2 = num1 % num2;
        num1 = temp;
    }

    return num1;
}

//EsPrimer
static bool EsPrimer(int num1)
{
    bool res = false;

    int i = 2, divisor = 0;

    while (i <= num1)
    {
        if (num1 % i == 0)
            divisor++;
        i++;
    }
    if (divisor == 1) res = true;
    return res;
}
*/