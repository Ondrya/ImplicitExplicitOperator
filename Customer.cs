using System;

namespace ImplicitExplicitOperator
{
    /// <summary>
    /// native class
    /// </summary>
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        /// <summary>
        /// assign CustomerDTO object with a Customer one; USING: CustomerDTO customerDTO = customer;
        /// it seems to be a normal static field, but it is not!
        /// </summary>
        /// <param name="customer"></param>
        public static implicit operator CustomerDTO(Customer customer)
        {
            return new CustomerDTO
            {
                Id = customer.Id,
                FullName = $"{customer.FirstName} {customer.MiddleName} {customer.LastName}"
            };
        }
    }
}
