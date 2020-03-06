using System;

namespace cn_week9_c_sharp_encapsulation
{
    class AreaClass
    {
        public double width;
        public double length;
        public double age = 41.0;
        public string userInput;
        // create a type for a function
        // public double Area()
        public double Area()
        {
            return width * length;
        }

        // void: return no value
        public double myFunction()
        {
            return length + width;
        }
        public void InformationDisplayed()
        {
            Console.WriteLine("Width = {0}", width);
            Console.WriteLine("Length = {0}", length);
            Console.WriteLine("What did it say? {0}", myFunction());
            Console.WriteLine("Our Area is {0}", Area());
        }
        public void UserDetails()
        {
            double myDouble = 44.0;
            int myInt = 44;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myDouble));
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToString(myBool));

            // Console.WriteLine("Please enter your user details: ");
            // userInput = Console.ReadLine();
            // if (Convert.ToDouble(userInput) == age)
            // {
            //     Console.WriteLine("Woah, it matches");
            // }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance so we can use it...
            AreaClass myShape = new AreaClass();
            myShape.width = 12.94;
            myShape.length = 6.87;
            myShape.InformationDisplayed();
            myShape.UserDetails();
            Console.ReadKey();

            // Console.WriteLine("Hello World!");
        }
    }
}
