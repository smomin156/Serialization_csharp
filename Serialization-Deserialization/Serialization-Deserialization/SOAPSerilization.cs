using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization_Deserialization
{
    class SOAPSerilization
    {
        static void Main(string[] args)
        {
            User user1 = new User() { UserId = 101, Name = "sameera" };
            SoapFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewTextSoap.xml", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, user1);
            stream.Close();

             stream = new FileStream(@"C:\TRAINING\Serialization-Deserialization\NewTextSoap.xml", FileMode.Open, FileAccess.Read);
            User newuser = (User)formatter.Deserialize(stream);
            Console.WriteLine(newuser);

            Console.ReadLine();
        }
    }
}
