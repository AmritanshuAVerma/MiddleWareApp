using System.ComponentModel.DataAnnotations;

namespace MiddleWareApp.Model
{

    public class Employee
    {
       
        public int Id { get; set; }

        [Required]
        public string EmployeeType { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeId { get; set; }


    }
    public class ErrorModel
    {
        
        public int Id { get; set; }

        public string? ErrorType { get; set; }

        public string? ErrorName { get; set; }

        public string? ErrorDescription { get; set; }

        public int LineNumber { get; set; }

        public string? ApiId { get; set; }


    }
}
