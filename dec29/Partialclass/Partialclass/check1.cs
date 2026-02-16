using System;
using Partialclass;
namespace Partialclass
{
    public partial class Checker
    {
        public int ID { get; set; }
        public int Number { get; set; }

        public int Addd()
        {
            return ID + Number;
        }
    }
}
