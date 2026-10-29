using System;
using System.Numerics;

namespace MohawkGame2D;

public class Raindrop
{
	public Raindrop()
	{
		Vector2 position;
		float x;
		float y;
	}

	public void Setup()
	{
		position = Random.Vector2(Window.Size);
	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(230, 249, 255);
		Draw.Square(x, y, 5);
	}
}
