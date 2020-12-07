using Microsoft.VisualStudio.TestTools.UnitTesting;
using OefeningCircustreinWithoutUI;
using System.Collections.Generic;

namespace UnitTestProjectOefeningCircustreinWithoutUI2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Animal> animals = new List<Animal>();
            Animal animal1 = new Animal(Animal.food.meat, Animal.size.Medium);
            animals.Add(animal1);
            Animal animal2 = new Animal(Animal.food.meat, Animal.size.Small);
            animals.Add(animal2);
            Animal animal3 = new Animal(Animal.food.plants, Animal.size.Medium);
            animals.Add(animal3);
            Algorithm algorithm = new Algorithm();
            List<Wagon> distributedAnimals = algorithm.DistributeAnimals(animals);
            foreach (Wagon wagon in distributedAnimals)
            {
                bool animalInWagon = false;
                foreach (Animal animal in animals)
                {
                    if (wagon.animals.Contains(animal))
                    {
                        animalInWagon = true;
                    }
                }
                Assert.IsTrue(animalInWagon);
            }
        }
    }
}
