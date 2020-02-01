using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class Character
    {
        public int speed = 20;
        private CharState currentState;

        public Character()
        {
            currentState = new StateMoving();
            //currentState = new StateStopped();
        }

        public void setState( CharState state )
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
