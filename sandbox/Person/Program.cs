

class Program
{


    
    static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor d)
        // {
        //     Console.WriteLine(d.GetDoctorInformation());
        // }
        // else if (person is Police p)
        // {
        //     Console.WriteLine(p.GetPoliceInformation());
        // }
        // else
        // {
        //     Console.WriteLine(person.GetPersonInformation());
        // }
        Console.WriteLine(person.GetPersonInformation());
    }

    static void Main()
    {
        Person myperson = new Person ("Bob", "Floyd", 56, 238);

        myperson.GetPersonInformation();

        Police policeman = new Police("Lance", "Bob", 34, 186, "taser");
       Doctor doctorman = new Doctor("Billy", "Payne", 20, 150, "Knife");

        // Console.WriteLine(policeman.GetPoliceInformation());
        // Console.WriteLine(doctorman.GetPersonInformation());
        List<Person> myPeople = new List<Person>();

        myPeople.Add(policeman);
        myPeople.Add(doctorman);
        myPeople.Add(myperson);
        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        //     Console.WriteLine(person.GetPersonInformation());
        }
     
    }

}