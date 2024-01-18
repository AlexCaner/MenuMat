using System;
using System.Diagnostics.Metrics;
using System.Threading;

class Program
{
    // MENU 
    static void Main()
    {
        int opcio = 1;
        bool seguir = true;
        while (seguir)
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
                case ConsoleKey.LeftArrow:
                    if (opcio > 1)
                    {
                        opcio = opcio - 1;
                    }
                    else opcio = 9;

                    break;
                case ConsoleKey.RightArrow:
                    if (opcio < 9)
                    {
                        opcio = opcio + 1;
                    }
                    else opcio = 1;

                    break;
                case ConsoleKey.Enter:
                    Switch(opcio);
                    if(opcio == 9) seguir = false;
                    break;

            }
            /*ConsoleKeyInfo teclanum = Console.ReadKey();
            char lletra = (char)teclanum.Key;
            opcio = lletra - '0';
            Switch(opcio);
            */
        }
    }

    // INTERFÍCIE MENU
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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                    Console.WriteLine("││ 5. Combinatoria                 ││");
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
                    Console.ResetColor();
                    Console.WriteLine("││                                 ││");
                    if(opcio == 9) { 
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
            Console.WriteLine("││ 0. Sortir                       ││");
                    break;
            }

            Console.ResetColor();
        }
        Console.WriteLine("│└─────────────────────────────────┘│");
        Console.WriteLine("└───────────────────────────────────┘");
    }

    // BUSCA EL METODE SEGONS EL QUE LI HAGIS DONAT
    static void Switch(int opcio)
    {
        Console.Clear();
        switch (opcio)
        {
            case 9:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("<!-- __| |_________________________________________________________________| |__ -->\r\n<!-- __   _________________________________________________________________   __ -->\r\n<!--   | |                                                                 | |   -->\r\n<!--   | |                                                                 | |   -->\r\n<!--   | |                                                                 | |   -->\r\n<!--   | |            d8888 8888888b.  8888888888 888     888 888          | |   -->\r\n<!--   | |           d88888 888  \"Y88b 888        888     888 888          | |   -->\r\n<!--   | |          d88P888 888    888 888        888     888 888          | |   -->\r\n<!--   | |         d88P 888 888    888 8888888    888     888 888          | |   -->\r\n<!--   | |        d88P  888 888    888 888        888     888 888          | |   -->\r\n<!--   | |       d88P   888 888    888 888        888     888 Y8P          | |   -->\r\n<!--   | |      d8888888888 888  .d88P 888        Y88b. .d88P  \"           | |   -->\r\n<!--   | |     d88P     888 8888888P\"  8888888888  \"Y88888P\"  888          | |   -->\r\n<!--   | |                                                                 | |   -->\r\n<!--   | |                                                                 | |   -->\r\n<!-- __| |_________________________________________________________________| |__ -->\r\n<!-- __   _________________________________________________________________   __ -->\r\n<!--   | |                                                                 | |   -->");
                Console.ResetColor();
                break;
            case 1:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"--------- MÀXIMS ---------");
                Console.ResetColor();
                int num1 = IntroduirValor();
                int num2 = IntroduirValor();
                int resultat = Maxim(num1, num2);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El número més gran es {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"----------- MCD -----------");
                Console.ResetColor();
                num1 = IntroduirValor();
                num2 = IntroduirValor();
                resultat = MCD(num1, num2);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El resultat es: {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 3:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"----------- MCM -----------");
                Console.ResetColor();
                num1 = IntroduirValor();
                num2 = IntroduirValor();
                resultat = MCM(num1, num2);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El resultat es: {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 4:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"--------- FACTORIAL ---------");
                Console.ResetColor();
                num1 = IntroduirValor();
                resultat = Factorial(num1);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El resultat es: {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 5:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"------- COMBINATORIA -------");
                Console.ResetColor();
                num1 = IntroduirValor();
                num2 = IntroduirValor();
                resultat = Combinatoria(num1, num2);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El resultat es: {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 6:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"------- MAJOR DIVISOR -------");
                Console.ResetColor();
                num1 = IntroduirValor();
                resultat = MajorDivisor(num1);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                Console.WriteLine($"El major divisor es {resultat}");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 7:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"---------- PRIMER ----------");
                Console.ResetColor();
                num1 = IntroduirValor();
                bool Primer = EsPrimer(num1);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                if (Primer) Console.WriteLine("Es un número primer");
                else Console.WriteLine("No es un número primer");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            case 8:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"-------- NUM PRIMER --------");
                Console.ResetColor();
                num1 = IntroduirValor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n-------- RESULTAT --------");
                Console.ResetColor();
                QuantsPrimers(num1);
                Console.ResetColor();
                Thread.Sleep(4000);
                Console.Clear();
                break;

        }
    }

    // METODE PER ENTRAR DADA 
    static int IntroduirValor()
    {
        Console.Write("Escriu el valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        return valor;
    }

    // TROBAR MÀXIM (POS1)
    static int Maxim(int num1, int num2)
    {
        int res = 0;

        if (num1 > num2) res = num1;
        else res = num2;
        return res;
    }

    // TROBAR MCD  (POS2)
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

    //TROBAR MCM  (POS3)
    static int MCM(int num1, int num2)
    {
        int res = 0, aux1 = num1, aux2 = num2;
        while (num2 != 0)
        {
            res = num2;
            num2 = num1 % num2;
            num1 = res;
        }

        return (aux1 * aux2) / res;
    }
    // FER FACTORIAL  (POS4)
    static int Factorial(int num1)
    {
        int i = num1, res = 1;
        while (i != 0)
        {
            res = res * i;
            i--;
        }
        return res;
    }
    // CALCULAR COMBINATORIA  (POS5)
    static int Combinatoria(int num1, int num2)
    {
        int i = num2, resultat = 1;
        while (i > 0)
        {
            resultat = resultat * num1;
            i--;
        }
        return resultat;
    }

    // TROBAR MAJOR DIVISOR  (POS6)
    static int MajorDivisor(int num1)
    {
        int i = 1, resultat = 0;
        while (i < num1)
        {
            if (num1 % i == 0) resultat = i;
            i++;
        }
        return resultat;
    }

    // TROBAR SI ES NUM PRIMER  (POS7)
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

    // TROBAR QUANTS PRIMERS HI HAN (POS8)
    static void QuantsPrimers(int num1)
    {
        int i = 1, j = 1, cont = 0;

        while (cont < num1)
        {
            if (EsPrimer(i))
            {
                Console.WriteLine(i);
                cont++;
            }
            i++;
        }
    }

}