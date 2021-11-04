using System;
class a
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int numA = int.Parse(s[0]);
        int numB = int.Parse(s[1]);

        if (numA > numB)
        {

            Console.WriteLine(">");
        }
        else if (numA < numB)
        {

            Console.WriteLine("<");
        }
        else if (numA == numB)
        {
            Console.WriteLine("==");
        }

    }

}