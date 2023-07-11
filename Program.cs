static int FindGreatestCommonDivison(int firstNumber, int secondNumber)
{
    if (secondNumber != 0)
        return FindGreatestCommonDivison(secondNumber, firstNumber % secondNumber);
    else
        return firstNumber;
}

Console.Write("Write First Number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Write Second Number: ");
int secondNumber = int.Parse(Console.ReadLine());

int greatCommonDivision = FindGreatestCommonDivison(firstNumber, secondNumber);
Console.Write($"Greatest Common Divisor of {firstNumber} and {secondNumber} is {greatCommonDivision}.");

