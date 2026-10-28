

class Program
{
    static void Main()
    {
        Person myperson = new Person ("Bob", "Floyd", 56, 238);

        myperson.GetPersonInformation();

        Police policeman = new Police("Lance", "Bob", 34, 186, "taser");
       Doctor doctorman = new Doctor("Billy", "Payne", 20, 150, "Knife");

        Console.WriteLine(policeman.GetPoliceInformation());
        Console.WriteLine(doctorman.GetPersonInformation());
        List<Person> myPeople = new List<Person>();

        myPeople.Add(policeman);
        myPeople.Add(doctorman);
        myPeople.Add(myperson);
        foreach (Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
     
    }

}