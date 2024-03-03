using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Repositories
{
    public class StudentRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)

        {  //DbContext Add method
            var dbContext = new Roommate_DBContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }
        //Get All students

        // Get All Student
        public void GetAllStudent(Student student)
        {
            var context = new Roommate_DBContext();
            var students = context.Students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + "         " + s.Surname + "        " + s.Address);
            }
        }
        // Get By ID
        public Student FindByID(int id)
        {
            try
            {
                var dbContext = new Roommate_DBContext();
                var student = dbContext.Students.Where(p => p.Id == id)
                    .FirstOrDefault();
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        public void DeleteStudent(Student student)
        {
            try
            {
                var dbContext = new Roommate_DBContext();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                var dbContext = new Roommate_DBContext();
                dbContext.Students.Update(student);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
