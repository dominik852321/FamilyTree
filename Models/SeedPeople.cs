using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DominikO_Tree.Models
{
    public class SeedPeople
    {

        public static async Task SeedPeoples(AppDbContext context)
        {
            try
            {
                if (!context.People.Any())
                {
                    var peopleData = File.ReadAllText("Models/people.json");
                    var people = JsonSerializer.Deserialize<List<Person>>(peopleData); ;

                    foreach (var person in people)
                    {
                        context.People.Add(person);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
               
            
        }

    }
}
