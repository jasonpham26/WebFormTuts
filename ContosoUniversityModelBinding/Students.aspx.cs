using ContosoUniversityModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ContosoUniversityModelBinding
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Student> studentsGrid_GetData()
        {
            SchoolContext db = new SchoolContext();
            var query = db.Students.Include(s => s.Enrollments.Select(e => e.Course));
            return query;
        }
    }
}