using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SpaceshipGame
{
    internal class Asteroid
    {
        public Vector2 position = new Vector2(600, 300);

        Random rand = new Random();
        
        public int speed;
        public int radius = 59;

        public Asteroid(int speed)
        {
            this.speed = speed;
            position = new Vector2(1380, rand.Next(0,721));
        }

        public void AsteroidUpdate(GameTime gameTime) 
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
