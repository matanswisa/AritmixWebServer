using System;
namespace RandomIdGenerator
{
    public static class RandomIdGenerator
    {
        public static string GenerateRandomId()
        {
            // Define the length of the ID
            int length = 8;

            // Characters allowed in the ID
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Random number generator
            Random random = new Random();

            // Generate a random ID
            char[] id = new char[length];
            for (int i = 0; i < length; i++)
            {
                id[i] = chars[random.Next(chars.Length)];
            }

            return new string(id);
        }
    }

}
