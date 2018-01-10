using System;
using System.Collections.Generic;

namespace GenerateUserIDUniq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suggest UserName
            string str = "GoodMorning";
            Console.WriteLine("Original String - {0}", str);
            string strModified = str.Substring(0, 4);
            Console.WriteLine("First Modified String - {0}", strModified);
            string result = str.Substring(str.Length - 4);
            Console.WriteLine("Last Modified String - {0}", result);
            Console.WriteLine();


            //Storage some username on databas, We can use for list dataset
            List<string> usernameList = new List<string>()
            {
                "shohag",
                "mamun",
                "fahomid",
                "arif",
                "arifa",
                "arifaa",
                "arifaaa",
                "arifaaaa",
                "arifaaaaa",

            };


            //Generate UserID for suggest
            again:


            Console.WriteLine("Enter your Username:");
            string userName = Console.ReadLine();
            AgainCheckContainsUsername:
            var isExistUserName = usernameList.Contains(userName);
            if (isExistUserName)
            {
                string getLastCharacter = userName.Substring(userName.Length - 1);
                userName = userName + getLastCharacter;
                goto AgainCheckContainsUsername;
            }
            Console.WriteLine("Successful Created UserName - {0} now stored this {0} on our dataset", userName);



            Console.WriteLine("Do you gain run to yes");
            string yes = Console.ReadLine();
            if (yes.ToLower() == "yes")
            {
                goto again;
            }

            //if (isExistUserName)
            //{
            //    string getLastCharacter = userName.Substring(userName.Length - 1);
            //    string getFirstCharacter = userName.Substring(0, 1);
            //    string generateUsername = userName + getLastCharacter;

            //    var isExistGenerateUserName = usernameList.Contains(generateUsername);
            //    if (isExistGenerateUserName)
            //    {

            //    }
            //    Console.WriteLine("Suggest UserName - {0}", generateUsername);
            //}

            Console.ReadKey();
        }
    }
}
