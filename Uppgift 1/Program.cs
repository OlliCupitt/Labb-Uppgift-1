using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("input you chosen sequence then press enter: ");
        //string input = Console.ReadLine();
        string input = "29535123p48723487597645723645";
        
        // definiera variables som kommer behövas i senare loops
        int length = input.Length;
        int i = 0;
        long sum = 0;
        
        do                                                          // do while loop för att välja första character i Array
        {
            if (char.IsDigit(input[i]))                             // if statement to check if it is a digit, if not do loop jumps to next character in Array
            {
                char startchar = input[i];                          // saving first character and identifying it as startchar to use to compare later
                bool stringcheck = true;                            // setting a stingcheck to use for identifying errors between i & j 

                for (int j = i + 1; j < length; j++)                // for loop to check startchar(i) against the next character in the array and so on (j++)
                { 
                    if (char.IsDigit(input[j]))                     // if statement to check that j is a digit for the for loop 
                    {
                        if (input[j] == startchar)                  // if statement to compare startchar to j
                        {
                            for (int k = i + 1; k < j; k++)         // Check the digits between i and j to ensure no repeated startchar.
                            {
                                if (input[k] == startchar)          // checking startchar against k for repeated chars, if this is true the loop will set stringcheck to 
                                {                                   // false and break the loop and restart.
                                    stringcheck = false;            
                                    break;
                                }
                            }
                            if (stringcheck)                                                   // If no issues were found, highlight and sum the valid sequence.
                            {                                                 
                                characterhighlight(i, j, input);                               // calling on the methods characterhighlight & Selectedsum  
                                string selectedsubstring = input.Substring(i, j - i + 1);      // Extract the valid substring and add it to the sum.

                                sum += SelectedSum(selectedsubstring);
                            }
                            break;                                                  // break after a correct sequence is found
                        }
                    }
                    else                                                            // if j is not a digit the loop is broken
                    {
                        break;
                    }
                }
            }
            i++;                                                                   // moving along to the next char in array afer all other loops and checks have been performed 
        }                                                                                  
        while (i < length);                                                        // length used as loop-breaking condition  
        Console.WriteLine();                                                       // print extra line to make it easier to read 
        Console.WriteLine($"total sum of all highlighted sections {sum}");         // sum print after the do/while loop has closed 
    }
    public static void characterhighlight(int i, int j, string input)              // creating the method characterhighlights      
    {
        string Selectedhighlight = ($"{input.Substring(i, j - i + 1)}");           // casting a string between i & j from the char array 
        Console.Write($"{input.Substring(0, i)}");                                 // printing the part before highlighted sequence 0 - i
        Console.ForegroundColor = ConsoleColor.Red;                                // colour change (highlight)
        Console.Write(Selectedhighlight);                                          // sequence print 
        Console.ResetColor();                                                      // colour reset to not change the rest of the console colour
        Console.WriteLine($"{input.Substring(j + 1, input.Length - (j + 1))}");              // last part of string print j - x
    }
    public static long SelectedSum(string selectedHighlight)                       // creating of the method Selectedsum 
    {
        if (long.TryParse(selectedHighlight, out long number))                     // converting the chosen sequence from the loop to a long
        {                                                                          
          return number;                                                           // sum addition
        }
          return 0;                                                                // if it can not be parsed the sum will retun to zero
    }
}


