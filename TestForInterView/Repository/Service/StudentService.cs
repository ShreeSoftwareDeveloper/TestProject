
using Microsoft.EntityFrameworkCore;
using TestForInterView.Model;
using TestForInterView.Model.Entity;
using TestForInterView.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace TestForInterView.Repository.Service
{
    public class StudentService:IStudentInterface
    {
        private readonly TestForInterviewContext _context;

        public StudentService(TestForInterviewContext _context)
        {
            this._context = _context;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            var students = await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return students.Entity;
        }

        public async Task<IEnumerable<Student>>GetTeachers()
        {
            return await _context.Students.ToListAsync();          

        }
        public async Task<IEnumerable<Student>> GetStudentByName(string name)
        {
            IQueryable<Student> query = _context.Students;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }
            return await query.ToListAsync();


        }

    }
}
