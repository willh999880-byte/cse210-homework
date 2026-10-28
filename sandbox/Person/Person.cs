class Person
{
    private string _First_Name;
    private string _Last_Name;

    private int _age;
    private double _weight;

    public Person(string First_Name, string Last_Name, int age, double weight)
    {
        _First_Name = First_Name;
        _Last_Name = Last_Name;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return($"{_First_Name} {_Last_Name} is {_age} years old and weighs {_weight} pounds");
    }

    
}