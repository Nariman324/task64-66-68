// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Enter the first member of progrersion...");
int theFirstMemberOfTheProgression = int.Parse(Console.ReadLine()!);
Console.Write("Enter the last member of progrersion...");
int theLastMemberOfTheProgression = int.Parse(Console.ReadLine()!);



int SumArithmeticProgression(int theFirstMemberOfTheProgression, int theLastMemberOfTheProgression)

{
    int sum = 0;
    if (theFirstMemberOfTheProgression > theLastMemberOfTheProgression) return sum;
    else
    {
        sum += theFirstMemberOfTheProgression;
        theFirstMemberOfTheProgression++;
        return sum + SumArithmeticProgression(theFirstMemberOfTheProgression, theLastMemberOfTheProgression);
    }
}

Console.WriteLine($"M = {theFirstMemberOfTheProgression}; N = {theLastMemberOfTheProgression} ---> {SumArithmeticProgression(theFirstMemberOfTheProgression, theLastMemberOfTheProgression)}");