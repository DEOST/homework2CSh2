//"Даден е масив от тип string. Да се напише метод, който да сортира елементите на масива според дължината им (броят на символите, съдържащи се в съответния string)."


using System;
using System.Linq;

class StringLenSort
{
    static void Main()
    {
        string[] unsortedStrings = { "a", "aaaaa", "aaaawasdawd", "a", "12355asdf", "wdasdwe" };
        // var sortedArray = unsortedStrings.OrderBy(uStrings => uStrings.Length);
        var sortedarr = unsortedStrings.OrderBy(strUns => strUns.Length);
        foreach (var item in sortedarr)
        {
            Console.WriteLine(item);
        }

    }
}

