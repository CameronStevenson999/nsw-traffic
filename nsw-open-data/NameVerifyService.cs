using System;

namespace nsw_open_data
{
    public class NameVerifyService
    {

        public bool IsValidName(string inputName)
        {

            int result = 0;

            if (int.TryParse(inputName, out result))
            {
                Console.WriteLine("Your input \'{0}\' is a number", result);
                return false;
            }
            else
            {
                Console.WriteLine("Hello, \"{0}\"!", inputName);
                return true;
            }
        }

    }
}
