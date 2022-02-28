using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine(new Program().CheckIDCard("1234567890120"));
        Console.WriteLine(new Program().CheckIDCard("1234567890121"));
        Console.WriteLine(new Program().CheckIDCard("1234567890122"));
        Console.WriteLine(new Program().CheckIDCard("1234567890123"));
        Console.WriteLine(new Program().CheckIDCard("1234567890124"));
        Console.WriteLine(new Program().CheckIDCard("1234567890125"));
        Console.WriteLine(new Program().CheckIDCard("1234567890126"));
        Console.WriteLine(new Program().CheckIDCard("1234567890127"));
        Console.WriteLine(new Program().CheckIDCard("1234567890128"));
        Console.WriteLine(new Program().CheckIDCard("1234567890129"));
    }



    public bool CheckIDCard(string id)
    {
        var sum = 0;
        for (var i = 0; i < 12; i++)
        {
            sum += int.Parse(id[i].ToString()) * (13 - i);
        }
        var check = (11 - sum % 11) % 10;
        return check == int.Parse(id[12].ToString());
    }
}
