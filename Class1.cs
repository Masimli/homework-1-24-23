using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Animal
    {
        public string name;
        public int age;
        public string breed;
        public string color;

    public string GetDetails()
        {
            return $"{name} {age} {breed} ";
        }
    }
    
}
