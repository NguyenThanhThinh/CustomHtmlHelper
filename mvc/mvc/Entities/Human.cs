using System.Collections.Generic;

namespace mvc.Entities
{
    public class Human
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        public static List<Human> GetAll()
        {
            return new List<Human>
            {
                new Human { Id = 1, Name = "A"},
                new Human { Id = 2, Name = "B"},
                new Human { Id = 3, Name = "C"},
                new Human { Id = 4, Name = "D"}
            };
        }
    }
}