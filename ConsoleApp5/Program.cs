Console.Title = "Moja nazwa okieneczka!!";

//Rozpoznawanie cyfr binarnych/oktalnych przy pomocy instrukcji wielokrotnego wyboru switch

Console.WriteLine("Wpisz cyfrę");
string str = Console.ReadLine();
char ch = str[0];

switch (ch)
{
    case '0':
    case '1':
        Console.WriteLine("Cyfra binarna");
        break;
    case '2':
    case '3':
    case '4':
    case '5':
    case '6':
    case '7':
        Console.WriteLine("Cyfra oktalna");
        break;

    default:
        Console.WriteLine("Nierozpoznany znak!! \n");
        break;

}
Console.WriteLine("Rozpoznanie zakończone");

//------------------------------------------------------------------------------------------------------------------

//foreach loop

int[] tab1 = new int[] { 1, 1, 2, 3, 5, 8, 13 };
foreach (int i in tab1)
    Console.WriteLine(i);

//-------------------------------------------------------------------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Program, który wylicza pole prostokąta o wymiarach podanych przez usera");

Console.WriteLine("Podaj szerokość");
string? szerokosc = Console.ReadLine();
int width = int.Parse(szerokosc);

Console.WriteLine("Podaj długość");
string? dlugosc = Console.ReadLine();
int length = int.Parse(dlugosc);

int poleProstokąta = width * length;

Console.WriteLine("Pole prostokąta dla podanych wartości wynosi {0}", poleProstokąta);

//-------------------------------------------------------------------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Program, ktory przelicza wartość z PLN na USD oraz EUR. Podajesz PLN i wiesz ile to tamtych walut");

Console.WriteLine("Podaj ile złotówek chcesz przeliczyć:");
string? zlotowkiString = Console.ReadLine();

double zlotowkiDouble = double.Parse(zlotowkiString);
double wartoscDolara = 3.95;
double wartoscEuro = 4.32;

double dolaryPoPrzeliczeniu = zlotowkiDouble * wartoscDolara;
double euroPoPrzeliczeniu = zlotowkiDouble * wartoscEuro;

Console.WriteLine("Podana kwota złotówek to {0} dolarów oraz {1} euro.", dolaryPoPrzeliczeniu, euroPoPrzeliczeniu);

//-------------------------------------------------------------------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Program, który wyznacza wartość funkcji kwadratowej y = ax2 + bx + c w zadanym punkcie");

Console.WriteLine("Podaj wartość współczynnika a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj wartość współczynnika b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj wartość współczynnika c: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj wartość x: ");
int x = int.Parse(Console.ReadLine());

double y = a * x * x + b * x + c;

Console.WriteLine("Wartość funkcji kwadratowej dla podanych współczynnikow wynosi: {0}", y);

//-----------------------------------------------------------------------------------------------------------------
//Handling exceptions
Console.WriteLine("obsługa wyjątków");

while (true)
{

    Console.WriteLine("Wprowadź liczbę całkowitą");
    string? answerString = Console.ReadLine();

    try
    {
        uint answerUint = uint.Parse(answerString);
        break;

    }
    catch (FormatException)
    {
        Console.WriteLine("Wprowadzono liczbę w złym formacie.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Wprowadzona liczba jest poza zakresem");
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Napotkano koniec strumienia");
    }
    Console.WriteLine("Spróbuj jeszcze raz");
}

//-------------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("funkcje i własności sterujące konsolą");

//ustawienie koloru tła
Console.BackgroundColor = ConsoleColor.Blue;

Console.WriteLine("test koloru tła");

//ustawienie koloru tekstu
Console.ForegroundColor = ConsoleColor.Green;

//czyszczenie ekranu
Console.Clear();

//ustawianie tytułu okna
Console.Title = "Moja nazwa okieneczka!!";
