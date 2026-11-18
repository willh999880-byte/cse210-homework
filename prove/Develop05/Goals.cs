using System.IO;
class Goals
{
    List<BaseGoal> _goals;
    string _filename;


    public Goals()
    {
       Getfilename();
       _goals = new List<BaseGoal>();
    

    }

    public void Getfilename()
    {
        Console.WriteLine("Please enter the file you want: ");
        _filename = Console.ReadLine();
    }

    public void Savegoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
        // You can add text to the file with the WriteLine method
        foreach(BaseGoal Goal in _goals)
            {
         outputFile.WriteLine(Goal.Getfilestring());
            }
        }
    }

    public void Loadgoals()
    {
        //TODO
    }




}