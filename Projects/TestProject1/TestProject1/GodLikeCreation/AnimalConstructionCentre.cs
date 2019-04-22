using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject1.Animals;

namespace TestProject1.GodLikeCreation
{
    class AnimalConstructionCentre
    {
        public void CreateAnimals()
        {
            Dog _Jeff = new Dog();
            _Jeff.NumberOfLegs = 5;

            if(_Jeff.NumberOfLegs == 5)
            {
                _Jeff.NumberOfLegs = 4;
            }
        }
    }
}
