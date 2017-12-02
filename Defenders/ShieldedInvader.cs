namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        //private static System.Random _random = new System.Random();

        public ShieldedInvader(Path path) : base(path)
        { }

        public override void DecreaseHealth(int factor)
        {
            if (Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shielded invader was shot. Zero damages.");
            }
        }

        public override int Health { get; protected set; }

    }
}