namespace TreehouseDefense
{
    class StrongInvader : Invader
    {
        public StrongInvader(Path path) : base(path)
        { }

        public override int Health { get; protected set; } = 3;

    }
}