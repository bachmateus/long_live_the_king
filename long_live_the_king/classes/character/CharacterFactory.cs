using System;
using System.Collections.Generic;
using System.Text;

namespace long_live_the_king.classes.character
{
    public class CharacterFactory
    {
        public  AbstractCharacter CreateCharacter(CharactersList character)
        {
            return CreateCharacter(character.ToString());
        }

        public  AbstractCharacter CreateCharacter(String character)
        {
            switch(character)
            {
                default:
                case "KingChar":
                    return new KingChar(); break;
            }
        }
    }

}
