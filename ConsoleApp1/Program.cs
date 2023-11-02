

Console.WriteLine("chandomin donbale ro mikhi?");
int an =Convert.ToInt32(Console.ReadLine());

int number1 = 1;
int number2 = 0;
int i = 0;

do
{
    number1 = number1 + number2;
    Console.Write(number1);
    Console.Write (",");

    number2 = number2 + number1;
    Console.Write(number2);
    Console.Write(",");
    i = i + 2;

} while (i < an);






