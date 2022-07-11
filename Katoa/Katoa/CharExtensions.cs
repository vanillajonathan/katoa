﻿namespace Katoa
{
    public static class CharExtensions
    {
        public static bool IsLower(this char c) => char.IsLower(c);

        public static bool IsUpper(this char c) => char.IsUpper(c);

        public static char SwapCase(this char c)
        {
            if (c.IsLower()) return char.ToUpper(c);
            if (c.IsUpper()) return char.ToLower(c);
            return c;
        }

    }
}
