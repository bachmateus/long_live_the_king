using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class StateDead : CharState
    {
        public override void pull(AbstractCharacter character)
        {
            character.speed = 0;
            character.canMove = false;
            character.isDead = true;
        }
    }
}
