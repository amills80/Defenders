namespace TreehouseDefense
{
    class Level
    {
        private readonly IInvader[] _invaders;

        public Tower[] towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }


        // returns: true if the player 
        public bool Play()
        {
            // Run until all invaders are neutralized or invader reaches end of path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {

                // each tower has opportunity to fire upon invaders
                foreach (Tower tower in towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                // count and move invaders that are still active
                remainingInvaders = 0;
                foreach (IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}