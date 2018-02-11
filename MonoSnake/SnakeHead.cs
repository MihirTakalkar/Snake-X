using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoSnake
{
    class SnakeHead : Sprite
    {
        public Vector2 speed;
        public SnakeHead(Vector2 position, Texture2D image, Color tint, Vector2 speed)
            : base(position, image, tint)
        {
            this.speed = speed;
        }

        public override void Update()
        {

        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }

    }
}
