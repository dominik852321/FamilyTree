using System.Collections.Generic;

namespace DominikO_Tree.Models
{
    public class VM
    {
        public List<Person> People { get; set; }
        public List<Person> SearchPeople { get; set; }

        public int Id { get; set; }

        public string search { get; set; }
        public int sort { get; set; }

    }
}