using System;
namespace Classes
{
    class Car
    {
        // Given that the method does not return a value, it's type is 'void'
        void Start1() // Start1() is called the method signature
        {
            /* Something we should to consider: If we care about the portability
             * of our entity, we should be careful about the types of statements,
             * operations and methods it contains. For example, using Console
             * in here constrains us to a console application - which would not 
             * help us if we wanted to make a web application, for example.
             */
            Console.WriteLine("Car Started!");
        }
        public void Start()
        {
            Start1();
        }

        /* We store the property 'name' in a string, allowing us to name Car
         * objects using object.company = "Ferrari"
         */        
        public string company;

        /* Suppose we want to store a private property internally, prohibiting
         * its external modification. We can create a public method which returns
         * the property, but the property is immutable outside the class.
         */
        string model = "Testarosa";
                  
        public string GetModel()
        {
            return model;
        }
    }
}
