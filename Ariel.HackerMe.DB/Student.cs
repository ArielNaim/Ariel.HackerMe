using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariel.HackerMe.DB
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int TotalPayment { get; set; }
        public int AllReadyPay { get; set; }
        public int NeedToPay { get; set; }
        public List<Course> StudentCourse = new List<Course>();
        public int NumberOfCourses { get; set; }
    }
}
