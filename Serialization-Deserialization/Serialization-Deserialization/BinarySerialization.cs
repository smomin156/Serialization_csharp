using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization_Deserialization
{


    class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User() { UserId = 101, Name = "sameera" };
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewText.txt", FileMode.Create, FileAccess.Write);
            //formatter.Serialize(stream, user1);
            //stream.Close();

            //Stream stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewText.txt", FileMode.Open, FileAccess.Read);
            //User newuser = (User)formatter.Deserialize(stream);
            //Console.WriteLine(newuser);


            //--------------------------------------------

            User user1 = new User() { UserId = 101, Name = "sameera",Age=20 };
            User user2 = new User() { UserId = 102, Name = "aseer",Age=19 };
            User user3 = new User() { UserId = 103, Name = "nihal" ,Age=18};

            User[] obj = { user1, user2, user3 };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewText.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewText.txt", FileMode.Open, FileAccess.Read);
            User[] newobj = (User[])formatter.Deserialize(stream);
            foreach (User item in newobj)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
