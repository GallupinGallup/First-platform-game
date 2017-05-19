// Lightning.cs
//Using declarations
using System;
using FirstGame.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FirstGame.Modle
{
	public class Lightning
	{
		public Lightning()
		{

		}

		// Image representing the Projectile
		public Animation animation;

		// Position of the Projectile relative to the upper left side of the screen
		public Vector2 Position;

		// State of the Projectile
		public bool Active;

		// The amount of damage the projectile can inflict to an enemy
		public int Damage;

		// Represents the viewable boundary of the game
		Viewport viewport;

		// Get the width of the projectile ship
		public int Width
		{
			get { return animation.FrameWidth; }
		}

		// Get the height of the projectile ship
		public int Height
		{
			get { return animation.FrameHeight; }
		}

		// Determines how fast the projectile moves


		public void Initialize(Animation animation, Vector2 position)
		{

			this.animation = animation;

			Position = position;

			Active = true;

			Damage = 100;

		}
		public void Update()
		{
			// Projectiles always move to the right
			Position.X += 1;
			Position.Y += 1;
			// Deactivate the bullet if it goes out of screen
			if (Position.X + Width / 2 > viewport.Width*7)
				Active = false;
		}
		public void Draw(SpriteBatch spriteBatch)
		{
			// Draw the animation
			this.animation.Draw(spriteBatch);
		}
	}
}