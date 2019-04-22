using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.Animals
{
    class Dog
    {
        #region Constructor
        public Dog()
        {
            _NumberOfEyes = 2;
            _NumberOfLegs = 4;
        }

        #endregion

        #region Properties
        public int NumberOfLegs { get; set; }

        #endregion

        #region Public Methods
        public void Walk()
        {
            //code for dog walking goes here
        }
        
        public void Jump()
        {
            //code for dog jumping goes here
        }

        #endregion

        #region Private Methods

        #endregion

        #region Fields
        private int _NumberOfLegs;
        private int _NumberOfEyes;

        #endregion

        #region Constants

        #endregion
    }
}
