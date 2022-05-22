using System;
using System.Collections.Generic;
using System.Text;

namespace Xasay_Class
{
    class User
    {
        public string Name;
        public string Surname;
        public string Password;


        public void CheckPassword()
        {
            bool status = true;
            if(Password.Length < 6)
            {
                Console.WriteLine("Please enter correct password \nPassword must be over 6 charcter");
                status = false;
            }


            if(status == true)
            {

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i <= Password.Length - Name.Length; i++)
                {
                    for (int j = i; j < Name.Length + i; j++)
                    {
                        stringBuilder.Append(Password[j]);  //123xasay
                    }

                    if (stringBuilder.ToString().ToLower() == Name.ToLower())
                    {
                        Console.WriteLine("Password cannot contain part of name");
                    }
                   
                    stringBuilder.Clear(); 

                }




                //for (int i = 0; i < Password.Length - Name.Length; i++)  // xasay123  xasay  //123xasay
                //{
                //    // test+=name  // xasay + musyev
                //    stringBuilder.Append(Name);
                //    if (stringBuilder.ToString().ToLower() == Password.ToLower())
                //    {

                //        Console.WriteLine("Password cannot contain part of name");
                //        break;
                //    }
                //    stringBuilder.Clear();

                //}


            }
            
        }
    }
}
