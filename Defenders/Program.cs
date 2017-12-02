using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            //Map grid dimensions 
            Map map = new Map(8, 5);

            //Invader path  
            try
            {
                Path path = new Path(
                  new[] {
              new MapLocation(0, 2, map),
              new MapLocation(1, 2, map),
              new MapLocation(2, 2, map),
              new MapLocation(3, 2, map),
              new MapLocation(4, 2, map),
              new MapLocation(5, 2, map),
              new MapLocation(6, 2, map),
              new MapLocation(7, 2, map)
                  }
                );

                //adding Invaders to the path
                IInvader[] invaders =
                {
              new ShieldedInvader(path),
              new FastInvader(path),
              new StrongInvader(path),
              new BasicInvader(path),
              new ResurrectingInvader(path)
           };

                // adding towers to gameplay
                Tower[] towers =
                {
              new Tower(new MapLocation(1, 3, map)),
              new SniperTower(new MapLocation(3, 3, map)),
              new Tower(new MapLocation(5, 3, map))
           };

                Level level = new Level(invaders)
                {
                    towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player has " + (playerWon ? "won" : "lost"));
                Console.ReadKey();
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}