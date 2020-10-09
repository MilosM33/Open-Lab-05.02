using System;
using System.Linq;
namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            string temp = "";
            var array = sentence.Split(' ');
            for (int y = 0; y < array.Length; y++)
            {
                if (y != array.Length-1)
                {
                    temp += array[y] + " ";
                }
                else
                {
                    string current = array[y];
                    int indexQuestion = current.IndexOf('?');
                    int indexExclamation = current.IndexOf('!');

                    if (indexQuestion != -1)
                    {
                        temp += current.Substring(0, indexQuestion + 1);
                    }
                    else if (indexExclamation != -1)
                    {
                        temp += current.Substring(0, indexExclamation + 1);
                    }
                    else
                        temp += current;
                }
            }
            return temp;
        }
        
    }
}
