using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoSnake
{
    class SnakePiece : Sprite
    {
       
        public Direction direction = Direction.Stop;
        public Vector2 speed;
        public SnakePiece(Vector2 position, Texture2D image, Color tint, Vector2 speed)
            : base(position, image, tint)
        {
            this.speed = speed;
        }
        public override void Update()
        {

            if (position.Y == 0)
            {
                position.X = 300;
                position.Y = 300;
            }
            if (position.X == 0)
            {
                position.X = 300;
                position.Y = 300;
            }
            if (position.Y == 600)
            {
                position.X = 300;
                position.Y = 300;
            }
            if (position.X == 600)
            {
                position.X = 300;
                position.Y = 300;
            }
            if (direction == Direction.Right)
            {
                position.X +=5;
            }
            if(direction == Direction.Left)
            {
                position.X -= 5;
            }
            if(direction == Direction.Up)
            {
                position.Y -= 5;
            }
            if (direction == Direction.Down)
            {
                position.Y += 5;
            }
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }
    }
}
