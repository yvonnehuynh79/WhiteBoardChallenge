// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;





static string FizzBuzz(int number)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        return "fizzbuzz";
    }

    if (number % 3 == 0)
    {
        return "fizz";
    }
    if (number % 5 == 0)
    {
        return "buzz";
    }
    
    return $"Try again! this number is not divisible by 3 nor 5!";
}
var answer = FizzBuzz(8);
Console.WriteLine(answer);

