using System;

namespace Variables_Exercise_1
{
    class Program
    {
        private const string V = "Wifey";

        static void Main(string[] args)
        {
            //Variables Declaration
            int age;
            string name;
            bool isAlive;
            char myLove;
            decimal myDecimal;
            double myCash;


            //Intializing Variables
            age = 33;
            name="Jeremy";
            isAlive = true;
            myLove = 'M';
            myDecimal = 11.55m;
            myCash = 1.11;

            Console.WriteLine($"{name} is {isAlive} and {age} is this much. {myLove} is here in the house and her {myDecimal} and {myCash} is this much");







              
        }
    }
}
