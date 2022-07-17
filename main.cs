using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace Main
{
    public class Game1: Game{
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        protected override void Init()
        {
            //TODO: Generate seeded caves system
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }
        
        protected override void Update()
        {
            

            base.Update();
        }
        
        protected override void Draw()
        {


            base.Draw();
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

    }
    

    
}

