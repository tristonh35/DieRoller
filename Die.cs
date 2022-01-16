using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{   

    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {   
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool isHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the face value to the new number
        /// <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            //Generate random number
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 6);

            //Set to face value
            FaceValue = newValue;

            return FaceValue;
        }
    }
}
