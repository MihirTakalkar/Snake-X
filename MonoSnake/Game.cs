using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace MonoSnake
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        Random random = new Random();
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SnakePiece head;
        int f = 0;
        List<SnakePiece> pieces;

        Food food;
        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 600;
            graphics.PreferredBackBufferHeight = 600;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() =>
            // TODO: Add your initialization logic here

            base.Initialize();

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            head = new SnakePiece(new Vector2(100, 500), Content.Load<Texture2D>("bitcoin"), Color.White, new Vector2(1, 1));
            food = new Food(new Vector2(100, 400), Content.Load<Texture2D>("graphicscard"), Color.White);
            pieces = new List<SnakePiece>();
            pieces.Add(head);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState ks = Keyboard.GetState();


            if (ks.IsKeyDown(Keys.Right))
            {
                head.direction = Direction.Right;
            }
            else if (ks.IsKeyDown(Keys.Left))
            {
                head.direction = Direction.Left;
            }
            else if (ks.IsKeyDown(Keys.Up))
            {
                head.direction = Direction.Up;
            }
            else if (ks.IsKeyDown(Keys.Down))
            {
                head.direction = Direction.Down;
            }

            if (head.position.Y < 0)
            {
                Exit();
            }
            if (head.position.X < 0)
            {
                Exit();
            }

            if (head.position.Y > 600)
            {
                Exit();
            }
            if (head.position.X > 600)
            {
                Exit();
            }
            if (head.hitbox.Intersects(food.hitbox))
            {
                Vector2 offset = new Vector2();
                if (head.direction == Direction.Up)
                {
                    offset = new Vector2(0,30);
                }
                if (head.direction == Direction.Down)
                {
                    offset = new Vector2(0, 30);
                }
                if (head.direction == Direction.Left)
                {
                    offset = new Vector2(0, 30);
                }
                if (head.direction == Direction.Right)
                {
                    offset = new Vector2(0, 30);
                }
                pieces.Add(new SnakePiece(pieces[pieces.Count - 1].position + offset, Content.Load<Texture2D>("bitcoin"), Color.White, new Vector2(1, 1)));
                pieces[pieces.Count].direction = pieces[pieces.Count - 2].direction;
                food.position.X = random.Next(0, 550);
                food.position.Y = random.Next(0, 550);
            }
            head.Update(gameTime);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(color: Color.White);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            for (f = 0; f < pieces.Count; f++)
            {
                pieces[f].Draw(spriteBatch);
            }
            head.Draw(spriteBatch);
            food.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }

    public enum Direction
    {
        Left, Right, Up, Down, Stop
    }
}
