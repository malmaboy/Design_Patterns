using System;

namespace SubclassSandbox_Pattern
{
    public abstract class SuperPower
    {
        // This is the sandbox method that a subclass
        // has to have its own version of
        public abstract void Activate();
        
        // All the operations a derived class need to perform 
        // called from Activate()
        protected  void Move(float _speed)
        {
            Console.WriteLine($"Moving with speed {_speed} ");
        }

        protected void PlaySound(string _coolSound)
        {
            Console.WriteLine($"Playing sound  {_coolSound}");
        }

        protected void SpawnPArticles()
        {
            
        }
    }
}