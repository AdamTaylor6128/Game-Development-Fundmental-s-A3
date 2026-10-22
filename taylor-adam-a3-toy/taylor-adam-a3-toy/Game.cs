// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        Fish fish = new Fish();
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fishing Toy");
            fish.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(255);
            fish.FishSwim();
            
        }
    }

}
