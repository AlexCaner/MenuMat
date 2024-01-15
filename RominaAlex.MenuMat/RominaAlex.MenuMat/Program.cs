int opcio, num1, num2;
opcio = Console.WriteLine(Menu(opcio));

switch (opcio)
{
    case 1:
        Console.WriteLine("Escriu un numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriu un numero");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MCD(num1, num2));
        break;
}

//MENU
static int Menu(int opcio)
{
    Console.WriteLine("Que vols fer");
    int opcio = Convert.ToInt32(Console.ReadLine());
    return opcio;

};


//MCD

static void MCD(int num1, int num2)
{

    while (num2 != 0)
    {
        int temp = num2;
        num2 = num1 % num2;
        num1 = temp;
    }

    Console.WriteLine(num1);
}