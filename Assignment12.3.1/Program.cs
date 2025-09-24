using System.Text;

namespace Assignment12._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("abbaca"));
        }
        public static string RemoveDuplicates(string s)
        {
            StringBuilder newS = new StringBuilder(s);
            for (int i = 0; i < newS.Length -1;)
            {
                if (newS[i] == newS[i + 1])
                {
                    newS.Remove(i, 2);
                    if (i == 0) continue;
                    i--;
                }
                else i++;
            }

            return newS.ToString();
        }
    }
}
