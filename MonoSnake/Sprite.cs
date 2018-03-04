using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoSnake
{
    class Sprite
    {
        public Vector2 position;
        public Texture2D image;
        public Rectangle hitbox
        {
            get
            {
                return new Rectangle((int)position.X,(int)position.Y, image.Width, image.Height);
            }
        }
        public Color tint;

        public Sprite(Vector2 Position, Texture2D Image, Color Tint)
        {
            position = Position;
            image = Image;
            tint = Tint;
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch batch)
        {
            batch.Draw(image, position, tint);
        }

    }
}
