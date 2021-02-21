using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitExplicitOperator
{
    /// <summary>
    /// DTO class for a Web API return
    /// </summary>
    internal class CustomerDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
