using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    class Sprite
    {
        private Texture2D Auto;
        public Vector2 Position;

        public float Speed = 2f;

        public Sprite(Texture2D auto)
        {
            Auto = auto;
        }

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Position.Y -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Position.Y += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Position.X -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Position.X += Speed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Auto, Position, Color.White);
        }
    }
}
