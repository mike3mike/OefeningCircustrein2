using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningCircustreinWithoutUI
{
    public class Animal
    {
        public Animal(object Food, object Size)
        {
            this.Food = Food;
            this.Size = stringSizeToStringInt[Size];
        }
        Dictionary<object, int> stringSizeToStringInt = new Dictionary<object, int>() {
            { size.Small, 1},
            { size.Medium , 3},
            { size.Big , 5 },
        };
        public object Food { get; }
        public int Size { get; }
        public enum food
        {
            meat,
            plants
        }
        public enum size
        {
            Small,
            Medium,
            Big
        }
    }
}
