using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolService
{
    [DataContract]
    public class StudentDto
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string StudentName { get; set; }
    }
}