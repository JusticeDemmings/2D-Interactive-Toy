using System;
using System.Numerics;

namespace MohawkGame2D;

public class RockR
{
        float x1;
        float x2;
        float x3;
        float x4;
        float y1;
        float y2;

    public void Setup()
    {
        x1 = Random.Float(520, 700);
        x2 = x1 + 30;
        x3 = x1 + 70;
        x4 = x1 + 100;
        y1 = Random.Float(50, 550);
        y2 = y1 - 40;
    }

    public void Update()
    {
        Draw.SetLineSize(1);
        Draw.SetFillColor(110, 113, 117);
        Draw.Quad(x1, y1, x2, y2, x3, y2, x4, y1);
    }
}
