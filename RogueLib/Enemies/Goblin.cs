using System;
using System.Collections.Generic;
using System.Text;
using RogueLib.Dungeon;
using RogueLib.Utilities;

namespace RogueLib.Enemies;

public class Goblin : Enemy
{
    public Goblin(Vector2 pos) : base('G', pos, "Goblin")
    {

    }

    public override void Draw(IRenderWindow disp)
    {
        disp.Draw(Glyph, Pos, ConsoleColor.DarkRed);
    }
}
