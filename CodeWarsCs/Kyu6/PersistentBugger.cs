namespace CodeWarsCs.Kyu6;

public static partial class Kata
{
    public static int Persistence(long n) 
    {
        var counter = 0;
        var strn = n.ToString();
        if (n.ToString().Length == 1)
            return 0;
        while (strn.Length > 1)
        {
            counter++;
            var x = strn[0] - '0';
            for (var i = 1; i < strn.Length; i++)
            {
                x *= (strn[i] - '0');
                        
            }
            strn = x.ToString();
        }

        return counter;
    }
}
