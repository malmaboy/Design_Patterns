namespace SubclassSandbox_Pattern
{ 
    // Subclass
    public class SkyLaunch : SuperPower
    {
        // Has to have its own version of Activate
        public override void Activate()
        {
            // Add operations this class has to perform
            Move(10f);
            PlaySound("SkyLaunch");
            SpawnPArticles();
        }
    }
}