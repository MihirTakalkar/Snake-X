using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoSnake
{
    class Food : Sprite
    {
        public Food(Vector2 position, Texture2D image, Color tint)
             : base(position, image, tint)
        {

        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
        }

    }
}
