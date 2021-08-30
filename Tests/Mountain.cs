using System;
using System.Linq;
using System.Collections.Generic;

namespace Tests
{
    public class Mountain : GameTile
    {
        public override int MovementCost { get; }
        public override void AddResource(Resource resource)
        {
            
        }

        public override IEnumerable<Resource> Resources { get; }

        // First way 
        public IEnumerable<Resource> Test()
        {
            
            foreach (var me in Resources)
            {
                if (me.Cost > 2.0f)
                {
                    yield return me;
                }
               
                
            }
        }
        
        // Second way 
        public IEnumerable<Resource> resources;

        private void HEHE()
        {
            resources =
                from resource in Resources
                where resource.Cost > 2.0f
                select resource;
        }

    }
}