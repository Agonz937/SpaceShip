using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceshipGame
{
    internal class Ship
    {
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;
        private int speed = 180;
        public int radius = 30;

        public Ship() { }

        public void ShipUpdate(GameTime gameTime) 
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Ship moves Forward
            if (kState.IsKeyDown(Keys.Right) && position.X < 1280)
            {
                position.X += speed * dt;
            }

            // Ship moves Backwards
            if (kState.IsKeyDown(Keys.Left) && position.X > 0)
            {
                position.X -= speed * dt;
            }

            // Ship moves Down
            if (kState.IsKeyDown(Keys.Down) && position.Y < 720) 
            {
                position.Y += speed * dt;
            }

            // Ship moves up
            if (kState.IsKeyDown(Keys.Up) && position.Y > 0)
            {
                position.Y -= speed * dt;
            }
        }

    }
}
