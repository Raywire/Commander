using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan"},
        new Command{Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & Chopping Board"},
        new Command{Id = 2, HowTo = "Make a cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cup"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan"};
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }
  }
}