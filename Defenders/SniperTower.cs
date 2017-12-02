namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        public SniperTower(MapLocation location) : base(location)
        { }

        // erase below commnt when you figure out above connection
        //    public Invader(Path path)
        //    {
        //      _path = path;
        //    }
        //    
        //    public Tower (MapLocation location)
        //    {
        //      _location = location; 
        //    }

        public override int Range { get; } = 3;
        public override double Accuracy { get; } = 0.9;
    }
}