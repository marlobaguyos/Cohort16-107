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

            System.Console.WriteLine(name);
            System.Console.WriteLine(distance);
            System.Console.WriteLine(price);
            System.Console.WriteLine(found);

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
                System.Console.WriteLine(i + "iteration");
            }

            return 1;
        } //end of Variables

        public void TestCollections()
        {
            //arrays
            string[] names = new string[3000000000];
            names[0] = "Nick";
            names[1] = "Jay";
            names[3] = "Eric";

            // lists
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.add("Green");
            colors.add("Dark Yellow");
            colors.add("blue");
            colors.add("puRpLE");

            System.Console.WriteLine(colors);


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