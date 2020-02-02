using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class KingChar : AbstractCharacter
    {
        public KingChar()
        {
            this.name = "King";
            this.speed = 3;
            this.canMove = true;
            this.isDead = false;
        }
    }
}
