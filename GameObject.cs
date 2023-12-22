using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
namespace ClassesGame
{

	public class GameObject
	{
		Texture2D Texture;
		Vector2 Position;
		Rectangle Area;
		Color color;
		Vector2 Size;
		public GameObject(Texture2D Texture, Rectangle Area, Color color)
		{
			this.Texture = Texture;
			this.Area = Area;
			this.color = color;
		}
		public virtual void Update(KeyboardState currentKeyboardState)
        {

        }
		public void Draw(SpriteBatch spriteBatch)
        {
			if (Texture == null)
			{
				throw new Exception("Texture is null");
			}
			else if (Area == null)
			{
				throw new Exception("Area is null");
			}
			else if (color == null)
			{
				throw new Exception("color is null");
			}
			else
			{
				spriteBatch.Draw(Texture, Area, color);
			}
		}
	}
}
