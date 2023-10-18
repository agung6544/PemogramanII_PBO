using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220039
{
    public class DVD_714220039 : Product_714220039
    {
        protected string _duration;
        public DVD_714220039(string title, string duration) : base("DVD", title)
        {
            this._duration = duration;
            Console.WriteLine("DVD constructor called");
        }

        public string Duration
        { get 
            { 
                return _duration; 
            } 
          set 
            {
                _duration = value;
            }
        }
    }
}
