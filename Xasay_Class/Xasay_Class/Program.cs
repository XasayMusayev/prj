using System;

namespace Xasay_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Name = "xasay";

            user.Surname = "Musayev";

            user.Password = "111xasMusayev";

            user.CheckPassword();
        }
    }
}
