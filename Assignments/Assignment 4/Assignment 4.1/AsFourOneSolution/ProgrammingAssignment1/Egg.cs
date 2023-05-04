using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// An egg
    /// </summary>
    public class Egg
    {
        #region Fields

        int amountLeft;
        EggColor color;
        HowCooked howCooked = HowCooked.NotCooked;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size">egg size</param>
        /// <param name="color">egg color</param>
        public Egg(int size, EggColor color)
        {
            amountLeft = size;
            this.color = color;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets how much egg is left to eat
        /// </summary>
        public int AmountLeft => amountLeft;

        /// <summary>
        /// Gets the color of the egg
        /// </summary>
        public EggColor Color => color;

        /// <summary>
        /// Gets how the egg is cooked
        /// </summary>
        public HowCooked CookedStatus => howCooked;

        /// <summary>
        /// Gets whether or not the egg is cooked
        /// </summary>
        public bool IsCooked => howCooked != HowCooked.NotCooked;

        #endregion

        #region Methods

        /// <summary>
        /// Cook egg
        /// </summary>
        /// <param name="howToCook">how the egg should be cooked</param>
        public void Cook(HowCooked howToCook)
        {
            if (!IsCooked)
            {
                howCooked = howToCook;
            }
        }

        /// <summary>
        /// Takes a bite of the given size from the egg
        /// </summary>
        /// <param name="size">size of the bite to take</param>
        public void TakeBite(int size)
        {
            if (!IsCooked) return;
            if (size <= amountLeft)
            {
                amountLeft -= size;
            }
            else
            {
                amountLeft = 0;
            }
        }

        /// <summary>
        /// Dyes the egg 
        /// </summary>
        /// <param name="color">color to dye the egg</param>
        public void Dye(EggColor color)
        {
            if (this.color == EggColor.White && color == EggColor.Blue)
            {
                this.color = color;
            }
        }

        #endregion
    }
}

