using System;
using System.Collections.Generic;
using System.Text;

namespace _04_01_01_Nullables
{
    class Person
    {
        // fields private by default
        public string Name { get; private set; }
        public DateTime Birth { get; private set; }
        public DateTime? Death { get; private set; }

        public TimeSpan Age 
        { 
            get 
            {
                if (Death == null)
                {
                    return DateTime.Now - Birth;
                }
                else
                {
                    return Death.Value - Birth;
                }
            }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birth, DateTime? death)
        {
            this.Name = name;
            this.Birth = birth;
            this.Death = death;
        }

        public override string ToString()
        {
            return this.Death == null ? $"Name: {this.Name} - Birth: {this.Birth} - Age: {this.Age}" : 
                $"Name: {this.Name} - Birth: {this.Birth} - Death: {this.Death} - Age: {this.Age}";

            //return $"Name: {this.Name} - Birth: {this.Birth} - Death: {this.Death ?? new DateTime() } - Age: {this.Age}";
        }
    }
}
