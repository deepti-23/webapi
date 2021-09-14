using StudentRepository.Model;
using System.Collections.Generic;

namespace StudentRepository.Repository
{
    public interface IStudentsRepository
    {
        void Add(StudentsInfo studentsInfo);
        void update(StudentsInfo studentsInfo);
        public IEnumerable<StudentsInfo> getall(); 
    }
}