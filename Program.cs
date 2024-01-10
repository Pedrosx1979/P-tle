// See https://aka.ms/new-console-template for more information

/*Pętla "while"
int a = 0;

while (a < 10 )   // warunek początkowy wg jakiego sprawdzania jest pętla.
(do takiej wartości sprawdzany jest warunek)(czy a jest mniejsze od 10 - pętla się zakończy
)
jeżeli napiszemy : while (true)- pętla nieskończona
{
    Console.WriteLine("liczba ma wartość : " + a);
    a++;
}
*/
//Przykład dzielenia z resztą w pętli while: - pętla nieskończona 
/*
int a = 10;

while (a%2 == 0) //- dopuki zmienna  a jet liczbą parzystą wypisujemy jej wartość
{
    Console.WriteLine("Liczba a ma wartość: " + a);

    a += 2; // zwiększenie liczby a o 2 - wypisuje w nieskończoność
}*/



/*Petla "do while"
int a = 0;

do // brak warunku - pierwsze przejście w pętli "do" jest bezwarunkowe,
   // dopiero w drugiej sesji warunek jest sprawdzany
{
    Console.WriteLine("liczba ma wartość : " + a);
    a++;

}
while (a < 10);*/



// Pętla "for"

//for (int a = 1/* deklaracja zmiennej inicjalizacja pętli*/; a < 101/*warunek*/; a++ /* instrukcja np
//zwiekszenie liczby a o 1*/) 
//{
//    Console.WriteLine( $"Liczba : {a} jest liczbą pierwszą");

//}

//Zad 1 Liczby pierwsze
/*
for (int a = 1; a < 101; a++ )
{
    Console.WriteLine($"Liczba : {a} jest liczbą pierwszą");
}*/

//Zad 2 Liczby parzyste

/*int b = 0;

do
{
    b = b + 2;

    Console.WriteLine(b);
}
while (b < 1000);*/

//Zad 3 Ciąg Fibunacciego
/*
int a = 0;
int b = 1;

do
{
    Console.WriteLine(a);

    b = a + b;
    a = b - a;

}
while (b > 0);
*/
//Zadnie 4 Piramida liczb
/*int a = 0;
int b = 1;
int c = 1;
Console.WriteLine("Podaj liczbę");
Int32.TryParse(Console.ReadLine(),out a );
while (a >= b)
{

    for (int i = 0; i <= c; i++)
    {
        if (a >= b)
        {

            if (i == 0)
            {
                Console.WriteLine(b);
                b++;
            }
            else
            {
                Console.Write(b);
                b++;
            }

        }

    }
    c++;
}*/
//Zadnie 5 Potęgi
/*int a = 0;

for (int i = 1; i <= 20; i++)
{ 
    Console.WriteLine(Math.Pow(i,3 ));

}*/
/*Zadanie 6 Suma 0-20 wg wzoru 1+1/2+1/...

double a = 0;
for (double i = 1; i <= 20; i++)
{ 
    a = a + 1 / i; // 1+1/2+1/3+1/4...

}
Console.WriteLine(a);*/

/* Zadnie 7... troche ściągałem nieukrywam

int a = 0;
string str = "";
Console.WriteLine("Podaj liczbę");
Int32.TryParse(Console.ReadLine(),out a);

for (int i = a % 2; i <= a; i = i + 2)
{ 
    str = "";
    for (int j = 1; j <= (a - j) /2; j++) 
    {
    str = str + "";
    }
    for (int j = 1;j <= a ;j++ )
    {
    str = str + "*";
    }
    Console.WriteLine(str);
}
for(int i = a - 2; i <= 1; i = i - 2)
    str = "";
for (int j = 1; j <= (a - j) / 2; j++)
{
    str = str + "";

}
for (int j = 1; j <= a; j++)
{
    str = str + "*";
}
Console.WriteLine(str);
*/
/* Zadanie 8 

Console.WriteLine("Wpisz dowolne słowo...");
string word1 = "Abcdefg";//Console.ReadLine();
string word2 = "";

for (int i = word1.Length - 1; i >= 0; i--) 
{
    word2 += word1[i];
}
Console.WriteLine(word2);
Console.WriteLine(""); */

/* Zadanie 9

Console.WriteLine("Wprowadź liczbę dziesiętną");
String Choise = Console.ReadLine();
int number = 0;
Int32.TryParse(Choise, out number);
string binary = "";


for (int i = 1; i < number; i++)
{
    if (number %2 == 0)
    {
        binary += "0";
    }
    else 
    {
        binary += "1";
    }
    number = number /= 2;
}

string realNumber = "";
for (int real = binary.Length - 1; real>= 0; real--)
{
    realNumber += binary[real];
}
Console.WriteLine(realNumber);*/
