﻿using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class StateStopped : CharState
    {
        public override void pull(Character character)
        {
            character.speed = 0;
        }
    }
}
