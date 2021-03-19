using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }
    //Set might be needed below
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}