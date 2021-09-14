using System.Collections.Generic;
using StudentRepository.Model;
using System.Linq;

namespace StudentRepository.Repository
{
    public class StudentsList : IStudentsRepository
    {

        List<StudentsInfo> LstudentInfo=new List<StudentsInfo>();

        void IStudentsRepository.Add(StudentsInfo studentsInfo)
        {
            LstudentInfo.Add(studentsInfo);
        }

        IEnumerable<StudentsInfo> IStudentsRepository.getall()
        {
            return LstudentInfo;
        }

        void IStudentsRepository.update(StudentsInfo studentsInfo)
        {
            var SearchRecord=LstudentInfo.Where(abc=>abc.StudentId==studentsInfo.StudentId).First();
            if(SearchRecord!=null)
            {
                SearchRecord.StudentName=studentsInfo.StudentName;
                SearchRecord.StudentAge=studentsInfo.StudentAge;
            }
        }
    }
}