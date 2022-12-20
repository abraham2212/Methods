using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sarp_methods.Models
{
    internal class Bird : Animal
    {
        public string Type { get; set; }
        public override void Sound()
        {
            Console.WriteLine("bird sound");

        }
        public override bool Eating()
        {
            Console.WriteLine("bird eating");
        }



    }
}
