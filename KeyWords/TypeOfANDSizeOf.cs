namespace KeyWords
{
    public class TypeOfANDSizeOf
    {
        public void TypeOf()
        {
            Console.WriteLine("type of int " + typeof(int) + "\t type of string " + typeof(string));
        }
        public void SizeOf()
        {
            int num = 1234;
            
            Console.WriteLine( "num type " + num.GetType() + "\t Hashcode" + num.GetHashCode() + "\t size of int: " + sizeof(int) + "\t size of char " + sizeof(char));
        }
    }
}
