namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        public FastInvader(Path path) : base(path)
        { }

        public override int Health { get; protected set; }

        protected override int StepSize { get; } = 2;

    }
}