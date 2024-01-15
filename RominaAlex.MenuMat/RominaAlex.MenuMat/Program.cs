using System.Net.Http.Headers;
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
    Console.Clear();
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