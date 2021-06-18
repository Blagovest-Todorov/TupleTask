using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {  //Tuple is a class, a object, a collection which holds elements/objects of different type ! 
            var personInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = $"{personInfo[2]}";

            var nameAndBeer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = nameAndBeer[0];
            var beerLitres = int.Parse(nameAndBeer[1]);

            var numebrsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var intNum = int.Parse(numebrsInput[0]);
            var doubleNum = double.Parse(numebrsInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, city);
            Tuple<string, int> secTuple = new Tuple<string, int>(name, beerLitres);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
