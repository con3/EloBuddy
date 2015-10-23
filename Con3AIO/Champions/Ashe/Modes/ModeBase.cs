using EloBuddy.SDK;

namespace Con3AIO.Champions.Ashe.Modes
{
    public abstract class ModeBase
    {
        protected Spell.Active Q
        {
            get { return SpellManager.Q; }
        }

        protected Spell.Skillshot W
        {
            get { return SpellManager.W; }
        }

        protected Spell.Skillshot E
        {
            get { return SpellManager.E; }
        }

        protected Spell.Skillshot R
        {
            get { return SpellManager.R; }
        }

        public abstract bool ShouldBeExecuted();

        public abstract void Execute();
    }
}
