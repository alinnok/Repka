using System;

namespace Persons
{
    public class Grandfather : Person
    {   
       

        private string _name;
        public string name {
        get
            {
            return _name;
            }
        set
             {
        _name = value;
        }
        }
              
    }
}