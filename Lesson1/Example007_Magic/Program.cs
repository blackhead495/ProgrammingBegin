﻿Console.Clear();

int xa = 70,  ya = 1,
    xb = 1,  yb = 55,
    xc = 141, yc = 55;

int x = xa, y = xb;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3)  0 1 2
    if (what == 0)
    {
        x = (x+xa)/2; y = (y+ya)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2; y = (y+yb)/2;
    }
    if (what == 2)
    {
        x = (x+xc)/2; y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}