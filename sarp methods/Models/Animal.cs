using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sarp_methods.Models
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("animal sound");
        }
    }
}
