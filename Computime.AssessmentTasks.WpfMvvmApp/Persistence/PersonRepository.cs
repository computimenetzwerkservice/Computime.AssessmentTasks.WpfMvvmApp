using System.Collections.Generic;
using System.Threading.Tasks;
using Computime.AssessmentTasks.WpfMvvmApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Computime.AssessmentTasks.WpfMvvmApp.Persistence
{
    /// <summary>
    /// Implementiert die 4 CRUD Ooperationen
    /// auf den übergebenen Datenbankkontext, 
    /// alle Operationen sind asynchron, damit es in der GUI zu keinen blocking kommt
    /// </summary>
    public class PersonRepository
    {
        //Backing field for the Context
        private readonly AppDbContext _context;

        // Constructor mit dem Datenbank Kontext mittels DI übergeben.
        public PersonRepository (AppDbContext context)
        {
            _context = context;
        }

        // Create
        public async Task AddPersonAsync(Person person)
        {
            await _context.People.AddAsync(person);
            await _context.SaveChangesAsync();
        }

        // Read
        public async Task<List<Person>> ReadAllPeopleAsync()
        {
            return await _context.People.ToListAsync();
        }


        // Update
        public async Task UpdatePersonAsync(Person person)
        {
            _context.People.Update(person);
            await _context.SaveChangesAsync();
        }

        // delete
        public async Task DeletePersonAsync(Person person)
        {
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}
