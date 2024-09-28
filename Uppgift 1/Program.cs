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
                            if (stringcheck = true)
                            {
                                Console.WriteLine($"{input.Substring(i, j - i + 1)}");
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
    public void characterhighlight(string highlight)
    { 
    
    }

}
