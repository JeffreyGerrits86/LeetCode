namespace Valid_Palindrome
{
    internal class Program
    {
        /*A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

        Given a string s, return true if it is a palindrome, or false otherwise.*/

        static void Main(string[] args)
        {
            string input = "A man, a plan, a canal: Panama";
            bool palindrome = IsPalindrome(input);
            Console.WriteLine(palindrome);
        }

        static bool IsPalindrome(string input)
        {
            bool palindrome = true; 
            string loweredInput = input.ToLower();
            string corrected = "";

            foreach(char c in loweredInput)
            {
                if (c >= 'a' && c <= 'z')       //chars are always converted to ASCII implicitly, so these comparisons work
                    corrected += c;                   
            }

            int endIndex = corrected.Length -1;

            for(int i = 0; i <= endIndex; i++)
            {
                if (corrected[i] != corrected[endIndex])
                {
                    palindrome = false;
                    break;
                }
                endIndex--;
            }
            return palindrome;
        }
    }
}
