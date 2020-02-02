using System;
using System.Collections.Generic;
using System.Text;
using long_live_the_king.classes.character;

namespace long_live_the_king.classes.character
{
    public abstract class AbstractCharacter
    {
        public String name { get; set; }

        public int speed { get; set; }

        public bool canMove { get; set; }

        public bool isDead { get; set; }

        public CharState currentState;

        public AbstractCharacter()
        {
            currentState = new StateStopped();
        }

        public void setState(CharState state)
        {
            currentState = state;
            pull();
        }

        public void pull()
        {
            currentState.pull(this);
        }
    }
}
