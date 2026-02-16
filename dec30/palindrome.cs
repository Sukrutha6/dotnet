using System;
using PalindromeApp;
namespace PalindromeApp
{
    public static class PalindromeExtensions
    {
        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (char.ToLower(text[left]) != char.ToLower(text[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}

