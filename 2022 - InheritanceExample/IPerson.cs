using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022___InheritanceExample
{
    interface IAnimal
    {
        string Move();
        string Communicate();
        string Eat();
    }
    abstract class Human:IAnimal
    {
        public abstract string Move();
        public abstract string Communicate(); 
        public string Eat()
        {
            return "Eat cooked food and fruit.";
        }
    }
    class Infant:Human
    {
        public override string Move()
        {
            return "Crawling.";
        }
        public override string Communicate()
        {
            return "Crying.";
        }
        //optional
        
    }
}
