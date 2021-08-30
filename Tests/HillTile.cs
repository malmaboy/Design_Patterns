using System.Collections.Generic;

namespace Tests
{
    public class HillTile : GameTile
    {
        public override int DefensiveBonus { get; }
        public override IEnumerable<Resource> Resources { get; }
        public override void AddResource(Resource resource)
        {
            throw new System.NotImplementedException();
        }
        
        public override int MovementCost { get; }

        public HillTile(IEnumerable<Resource> _resources, int _movementCost, int _defensiveCost)
        {
            MovementCost = 2;
            Resources = _resources;
            MovementCost = _movementCost;

            DefensiveBonus = _defensiveCost;

        }

        
    }
}