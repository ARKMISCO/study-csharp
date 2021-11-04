using System;
using static System.Console;
using System;
using static System.Console;
using System.Text;
using System.IO;

public class 여친
{
    public int 나이 = 25;
    private int 무게 = 60;

    public void SetWeight(int x)
    {
        몸무게 = x;
    }

    public int GetWight()
    {
        return 몸무게;
    }
}

class 여친
{
    public int 나이 = 25;
    private int 무게 = 70;
}

class program
{
    static void Main(string[] args)
    {
        여친 none = new 여친();
        Console.WriteLine("나이 : "+ none.나이);
    }
}
