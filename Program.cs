using System;
using System.Text.Json;

namespace ImplicitExplicitOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start !");

            var customer = new Customer
            {
                FirstName = "Andrew",
                LastName = "Evsugin"
            };

            Console.WriteLine("Native object");
            Console.WriteLine(JsonSerializer.Serialize(customer));

            CustomerDTO customerDTO = customer;

            Console.WriteLine("DTO object");
            Console.WriteLine(JsonSerializer.Serialize(customerDTO));

            Console.WriteLine("End !");
        }
    }
}
