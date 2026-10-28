class Police : Person
{
   private string _weapons;
   public Police(string First_Name, string Last_Name, int age, double weight, string weapons)
   :base (First_Name, Last_Name, age, weight)
    {
       
        
          _weapons = weapons;  
        
    }

    public string GetPoliceInformation()
      {
            return ($"Weapons: {_weapons}, {GetPersonInformation()}");
      }
}