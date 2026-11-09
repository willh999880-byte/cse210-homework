class Doctor : Person
{
   private string _Tools;
   public Doctor(string First_Name, string Last_Name, int age, double weight, string tools)
   :base (First_Name, Last_Name, age, weight)
    {
       
        
          _Tools = tools;  
        
    }

    public override string GetPersonInformation()
      {
            return ($"Doctor Tools: {_Tools}, {base.GetPersonInformation()}");
      }
}