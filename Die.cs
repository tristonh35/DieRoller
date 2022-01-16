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
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool isHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the face value to the new number
        /// </summary>
        public void Roll()
        {
            // Generate random number and set to face value
        }
    }
}
