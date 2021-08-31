namespace SubclassSandbox_Pattern
{
    // Subclass
    public class GroundDive : SuperPower
    {
        // Has to have its own Activate
        public override void Activate()
        {
            Move(15f);
            PlaySound("GroundDive");
            SpawnPArticles();
        }
    }
}