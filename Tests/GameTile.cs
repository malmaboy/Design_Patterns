using System.Collections.Generic;

namespace Tests
{
    public abstract class GameTile
    {
           public abstract IEnumerable<Resource> Resources { get; }
           public virtual int DefensiveBonus { get; }
           public virtual int MovementCost { get; }
           public abstract void AddResource(Resource resource);
           
           
    }
}