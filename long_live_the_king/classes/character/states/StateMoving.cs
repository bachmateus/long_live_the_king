﻿using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class StateMoving : CharState
    {
        public override void pull(AbstractCharacter character)
        {
            character.speed = 1;
            character.canMove = true;
        }
    }
}
