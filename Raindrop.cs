using System;
using System.Numerics;

namespace MohawkGame2D;

public class Raindrop
{
    float x;
    float y;
	float speed = 200;

    public void Setup()
	{
		x = Random.Float(0, 800);
		y = 0;

    }

	public void Update()
	{
		y += Time.DeltaTime * speed;

		Draw.SetLineSize(0);
		Draw.SetFillColor(230, 252, 255);
		Draw.Square(x, y, 5);
	}
}
