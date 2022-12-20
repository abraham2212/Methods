using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sarp_methods.Models
{
    internal class Shark :Animal
    {
        public int TeethCount { get; set; }
        public override void Sound()
        {
            Console.WriteLine("shark sound");
        }
    }
        










}
