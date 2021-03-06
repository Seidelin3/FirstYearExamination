﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearExamination.Components
{
	public class SpriteRenderer : Component
	{
		public Texture2D Sprite { get; set; }

		public Vector2 Origin { get; set; }

		public SpriteRenderer()
		{

		}

		public SpriteRenderer(string spriteName)
		{
			SetSprite(spriteName);
		}

		public SpriteRenderer Clone()
		{
			return (SpriteRenderer)this.MemberwiseClone();
		}

		public void SetSprite(string spriteName)
		{
			Sprite = GameWorld.Instance.Content.Load<Texture2D>(spriteName);

		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Sprite, GameObject.Transform.Position, null, Color.White, 0, Origin, 1, SpriteEffects.None, 0.5f);
		}

		public override string ToString()
		{
			return "SpriteRenderer";
		}
	}
}
