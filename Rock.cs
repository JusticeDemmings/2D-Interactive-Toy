using System;
using System.Numerics;

namespace MohawkGame2D;

public class Rock
{
	float x1;
	float x2;
	float x3;
	float x4;
	float y1;
	float y2;

	public void Setup()
	{
		x1 = Random.Float(0, 270);
		x2 = Random.Float(x1 + 30);
		x3 = Random.Float(x1 + 70);
		x4 = Random.Float(x1 + 90);
		y1 = Random.Float(x1 - 40);
		y2 = Random.Float(x1 - 40);
    }

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(110, 113, 117);
		Draw.Quad(x1, y1, x2, y2, x3, y2, x4, y1);
	}
}
