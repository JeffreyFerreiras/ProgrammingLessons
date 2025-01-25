namespace KeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeOfANDSizeOf typesizeof = new TypeOfANDSizeOf();
            typesizeof.TypeOf();
            typesizeof.SizeOf();         
            Console.ReadLine();

            dynamic obj =new System.Dynamic.ExpandoObject();

            obj.City = 1;
            obj.City = "hello";

            Console.WriteLine(obj.City);
            Console.Read();
        }

        public struct Structure : IStruct2 { }
        public struct Struct2 { }
        public interface IStruct2 { }
        public class cls { }
    }
}
