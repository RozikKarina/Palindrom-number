public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false; // Від'ємне число не може бути паліндромом

        int original = x;
        int reversed = 0;

        // Повертаємо число в зворотному порядку
        while (x > 0)
        {
            int remainder = x % 10;
            reversed = reversed * 10 + remainder;
            x /= 10;
        }

        // Перевіряємо, чи дорівнює оригінальне число зворотному
        return original == reversed;
    }
}
