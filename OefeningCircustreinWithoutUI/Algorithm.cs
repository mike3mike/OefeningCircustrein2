using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningCircustreinWithoutUI
{
    public class Algorithm
    {
        private bool AlreadySmallMeat(Animal animal, Wagon wagon)
        {
            if (animal.Food?.ToString() == Animal.food.meat.ToString())
            {
                foreach (Animal wagonanimal in wagon.animals)
                {
                    if (wagonanimal.Food.ToString() == Animal.food.meat.ToString() && wagonanimal.Size >= animal.Size)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool IsSpace(Animal animal, Wagon wagon)
        {
            if (Wagon.weight + animal.Size <= 10)
            {
                return true;
            }
            return false;
        }
        public List<Wagon> DistributeAnimals(List<Animal> animals)
        {
            List<Wagon> allWagons = new List<Wagon>();
            Wagon firstWagon = new Wagon();
            allWagons.Add(firstWagon);
            foreach (Animal animal in animals)
            {
                foreach (Wagon wagon in allWagons)
                {
                    bool alreadySmallMeat = AlreadySmallMeat(animal, wagon);
                    bool isSpace = IsSpace(animal, wagon);
                    if (alreadySmallMeat == false)
                    {
                        if (isSpace == true)
                        {
                            wagon.animals.Add(animal);
                        }
                        else
                        {
                            Wagon newWagon = new Wagon();
                            wagon.animals.Add(animal);
                            break;
                        }
                    }
                    else
                    {
                        Wagon newWagon = new Wagon();
                        wagon.animals.Add(animal);
                        break;
                    }
                }
            }
            return allWagons;
        }
    }
}