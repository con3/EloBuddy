namespace Con3AIO.Champions.Ashe.Modes
{
    public sealed class PermaActive
    {
        public override bool ShouldBeExecuted()
        {
            return true;    //O loop deve sempre ser executado, pois é o modo permanentemente ativo.
        }

        public override void Execute()
        {
            // TODO: Add permaactive logic here, good for spells like Ignite or Smite
        }
    }
}
