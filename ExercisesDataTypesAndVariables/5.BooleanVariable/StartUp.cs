namespace _5.BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            if (Convert.ToBoolean(str))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
