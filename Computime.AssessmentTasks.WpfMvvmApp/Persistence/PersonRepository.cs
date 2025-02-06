using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computime.AssessmentTasks.WpfMvvmApp.Models;

namespace Computime.AssessmentTasks.WpfMvvmApp.Persistence
{
    /// <summary>
    /// Implementiert die 4 CRUD Ooperationen
    /// </summary>
    public class PersonRepository
    {

        private readonly AppDbContext _context;

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
        // Update
        // delete

    }
}
