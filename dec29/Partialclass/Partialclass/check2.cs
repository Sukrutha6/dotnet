using System;
using Partialclass;
namespace Partialclass
{
    public partial class Checker
    {
        public string? Name { get; set; }

        public string Display()
        {
            return $"Name is {Name}";
        }
    }
}
