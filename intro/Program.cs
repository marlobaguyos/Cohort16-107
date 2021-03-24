using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Variables();

        }
        //access_level return_type method_name (params)
        public int Variables()
        {
            string name = "Sergio";
            int age = 34;
            float distance = 3445.423f;
            decimal price = 29.99m;
            bool found = false;

            //conditional blocks
            if(age < 100)
            {
                Console.WriteLine("Don't worry, you are still young");
                //cw
                Console.WriteLine("askdljklasd");
            }
            else
            {
                System.Console.WriteLine("Ouch, you are getting old");
            }

            //loops
            for(int i=0; i < 10; i++)
            {
                System.Console.WriteLine("")
            }

            return 1;
        }
    }
}

// JS = pascalCase
// CS = CamelCase

//Interpreters

/*
js,python,php,Ror,

Code 
    Run
        Read
        Syntax
        Parse
        Exec

*/

//Compliled
/*
    C#, Java,C,C++

    Code
    Compile
        Read
        Syntax
        Parse
        Save the compilation results into binary format
    Run
        execute
*/