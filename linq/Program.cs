using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            QuerySpaces();
            Console.WriteLine(Scores());
            TestScores();
            QueryArrayList();
            QueryCollection();
            QueryArray();
        }

        static void QuerySpaces()
        {
            string[] dogs= {"lubort ton", "9 ker", "rottweiler", "Alsatian piggery", "bull dog" };
            //query dog names with space
            var dogspaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;
        
            foreach(var item in dogspaces)
                Console.WriteLine(item);
        }

        //write a query that will return an array of scores gt 20
        static int[] Scores()
        {
            int[] stdScores = { 5, 10, 15, 20, 25, 30, 35 };

            var highestScores = from scores in stdScores
                                where scores > 20
                                orderby scores ascending
                                select scores;

            Console.WriteLine(highestScores.GetType());
            stdScores[0] = 40;
            foreach(var item in highestScores)
                Console.WriteLine(item);
            //convert scores to array
            var ArrayScores = highestScores.ToArray();
            //convert scores to list
            var ListScores = highestScores.ToList<int>();

            return ArrayScores;

        }

        //return a int[] of scores that are between 50-100

        static int[] TestScores()
        {
            int[] testscores = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };
           
            var highest_testscores = from hg_testscores in testscores
                                     where hg_testscores >= 50 && hg_testscores <= 100
                                     orderby hg_testscores ascending
                                     select hg_testscores;

            foreach(var item_7 in highest_testscores)
                Console.WriteLine(item_7);

            var ArrayTestScores = highest_testscores.ToArray();
            return ArrayTestScores;

        }

        //query an arraylist
        static void QueryArrayList()
        {
            //arraylist
            ArrayList FavoriteAnimals = new ArrayList()
            {
                new Animal
                {
                    Name="John",
                    Height=.76,
                    Weight=89
                },
                new Animal
                {
                    Name="Jake",
                    Height=.77,
                    Weight=88
                },
                new Animal
                {
                    Name="Jack",
                    Height=.89,
                    Weight=100
                }
            };
            //make it an enumerable

            var favoriteAnimalEnumerable = FavoriteAnimals.OfType<Animal>();
            var animalCategory = from favanimal in favoriteAnimalEnumerable
                                 where favanimal.Weight > 50 && favanimal.Height < .99
                                 orderby favanimal.Name ascending
                                 select favanimal;

            foreach(var item_8 in animalCategory)
                Console.WriteLine(item_8);

        }

        //query a collection
        static void QueryCollection()
        {
            //collection
            var animalList = new List<Animal>() {

                  new Animal
                {
                    Name="John",
                    Height=.76,
                    Weight=89
                },
                new Animal
                {
                    Name="Jake",
                    Height=.77,
                    Weight=88
                },
                new Animal
                {
                    Name="Jack",
                    Height=.89,
                    Weight=100
                }
            };

            var bigDogs = from big_dogs in animalList
                          where (big_dogs.Height > 50) && (big_dogs.Weight > 0.6)
                          orderby big_dogs.Name descending
                          select big_dogs;

            foreach(var item_9 in bigDogs)
                Console.WriteLine("{0} is quite big and he weighs {1}",item_9.Name,item_9.Weight);
                          
        }

        //further use cases of select
        static void QueryArray()
        {
            //animal raray
            Animal[] animals = new[]
            {
                  new Animal
                {
                    Name="John",
                    Height=.76,
                    Weight=89,
                    AnimalID=1
                },
                new Animal
                {
                    Name="Jake",
                    Height=.77,
                    Weight=88,
                    AnimalID=1
                },
                new Animal
                {
                    Name="Jack",
                    Height=.89,
                    Weight=100,
                    AnimalID=2
                }
            };

            Owner[] owners = new[]
            {
                new Owner
                {
                    Name="Billy",
                    OwnerID = 1
                },
                new Owner
                {
                    Name="Billy kimber",
                    OwnerID= 2
                },
                new Owner
                {
                    Name="Druid defner",
                    OwnerID= 3
                }
            };

            //select only the name and height from the animal array
            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };

            foreach(var item_9 in nameHeight)
                Console.WriteLine("{0} has a height of {1}",item_9.Name, item_9.Height);


            //working with inner join
            var ownerNameAnimal = from animal in animals
                                  join owner in owners
                                  on animal.AnimalID equals owner.OwnerID
                                  select new
                                  {
                                      ownerName=owner.Name,
                                      animalName=animal.Name
                                  };

            foreach(var item_10 in ownerNameAnimal)
                Console.WriteLine("{0} owns {1}",item_10.ownerName,item_10.animalName);

            //group join

            var groupjoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals
                            on owner.OwnerID equals animal.AnimalID
                            into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animal = from owner2 in ownerGroup
                                         orderby owner2.Name
                                         select owner2
                                         
                            };

            foreach(var item_1 in groupjoin)
            {
                Console.WriteLine(item_1.Owner);
                foreach (var animal in item_1.Animal)
                {
                    Console.WriteLine( "{0}", animal.Name);

                }
            }
        }


      

    }
}
