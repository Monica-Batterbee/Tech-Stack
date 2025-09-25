public class ClassName
{
    int val;
    //constructor
    public ClassName()
    {
        val = 10;
    }

    //destructor
    ~ClassName()
    {
        val = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassName c = new ClassName();
            Console.WriteLine(c.val);
        }
    }
}