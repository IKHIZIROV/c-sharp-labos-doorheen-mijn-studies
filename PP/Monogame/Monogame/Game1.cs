using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct3D9;

namespace Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        private SpriteBatch _spriteBatch;

        private Rectangle _deelRectangle;

        private Texture2D _texture;

        private int schuifOp_X = 0;

        private Texture2D _heroTexture;

        private Hero hero;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _deelRectangle = new Rectangle(0, 0, 180, 247);
            _deelRectangle = new Rectangle(schuifOp_X, 0, 180, 247);
            base.Initialize();
            hero = new Hero(_heroTexture);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = Content.Load<Texture2D>("spritesheet");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            hero.Update();
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {

            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, new Vector2(0, 0), _deelRectangle, Color.White);
            _spriteBatch.End();

            schuifOp_X += 180;
            if (schuifOp_X > 720)
            {
                schuifOp_X = 0;
            }
            _deelRectangle.X = schuifOp_X;

            base.Draw(gameTime);
        }


    }
}