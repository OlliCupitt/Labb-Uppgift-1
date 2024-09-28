using System;
class Program
{
    static void Main(string[] args)
    {

        string input = "29535123p48723487597645723645";

        // översätting till char så att man kan välja individuella characterer
        char[] charArray = input.ToCharArray();
        // length för while break
        int x = charArray.Length;
        int i = 0;
       
        do
        {
            if (char.IsDigit(charArray[i]))
            {
                char startchar = charArray[i];
                bool stringcheck = true;

                for (int j = i + 1; j < x; j++)
                {
                    if (char.IsDigit(charArray[j]))
                    {
                        if (charArray[j] == startchar)
                        {
                            for (int k = i + 1; k < j; k++)
                            {
                                if (charArray[k] == startchar)
                                {
                                    stringcheck = false;
                                    break;
                                }
                            }
                            if (stringcheck)
                            {
                                characterhighlight(i, j, input);
                            }
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            i++;
        }
        while (x >= i);

    }
    public static void characterhighlight(int i, int j, string input)
    {
        string Selectedhighlight = ($"{input.Substring(i, j - i + 1)}");    
        Console.Write($"{input.Substring(0, i)}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Selectedhighlight);
        Console.ResetColor();
        Console.WriteLine($"{input.Substring(j, input.Length - j)}");

    }

}


