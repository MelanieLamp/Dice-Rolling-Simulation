using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Simulation
{
    class Die
    {
        //Class instance variable
        int face = 0;    //# rolled by die.
        static Random myRandom = new Random();

        //Default Constructor
        public Die()
        {
            face = 1;   //Roll();
        }

        //Overloaded Constructor
        //Created new instance of Die with 
        //specific face.
        public Die(int num)
        {
            this.face = num; // Returns the # that was rolled.
        }

        //Roll Method
        public static int Roll()
        {
            //The Static in the method has to be called to connect
            //with the constructor.
            return (myRandom.Next(6) + 1);
        }

        //Retrieves face value
        //Allows access to value
        public int GetSide()
        {
            return face; 
        }

        //Outputs value & connects to constructor.

        public void SetSide(int num) //Structured output
        {
            this.face = num;
        }

        public bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Die other = (Die)obj;
            if (this.face != other.face)
            {
                return false;
            }
            return false;
        }
    }

}
