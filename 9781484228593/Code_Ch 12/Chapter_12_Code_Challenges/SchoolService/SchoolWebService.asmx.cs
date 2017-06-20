using SchoolService.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace SchoolService
{
    /// <summary>
    /// Summary description for SchoolWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SchoolWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int id, string name)
        {
            SchoolEntities db = new SchoolEntities();
            Student st = new Student();
            st.StudentID = id;
            st.StudentName = name;
            db.Students.Add(st);
            return db.SaveChanges();

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]//Return result as a JSON object
        public List<StudentDto> ReadAll()
        {
            SchoolEntities db = new SchoolEntities();
            var students = db.Students.ToList();

            //Custom class implemented attributes for serialization because serialized data tavel
            //over the network
            List<StudentDto> studentList = new List<StudentDto>();
            foreach (var item in students)
            {
                StudentDto st = new StudentDto();
                st.StudentID = item.StudentID;
                st.StudentName = item.StudentName;
                studentList.Add(st);
            }
            return studentList;
        }
    }
}
