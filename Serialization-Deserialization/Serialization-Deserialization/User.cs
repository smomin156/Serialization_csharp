using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization_Deserialization
{
    [Serializable]
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format($"Id : {UserId} Name : {Name} Age : {Age}");
        }
    }
}
