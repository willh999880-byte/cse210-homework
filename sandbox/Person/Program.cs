

class Program
{
    static void Main()
    {
        Person myperson = new Person ("Bob", "Floyd", 56, 238);

        myperson.DisplayInformation();

        Police policeman = new Police("Lance", "Bob", 34, 186, "taser");
        policeman.DisplayInformation();
    }

}