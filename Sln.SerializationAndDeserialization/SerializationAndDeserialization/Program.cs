using System;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeDeserialize.DoSerialization();
            SerializeDeserialize.DoDeSerialization();

            Console.ReadKey();
        }
    }
}
