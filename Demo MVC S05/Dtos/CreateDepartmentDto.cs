using System.ComponentModel.DataAnnotations;

namespace  Demo_MVC_Session_04
{
    public class CreateDepartmentDto
    {
        // Properties for creating a department
        // Data Transfer Object (DTO)
        // to transfer data between layers
        // Data Annotation
        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CreateAt Is Required")]
        public DateTime CreateAt { get; set; }
    }
}
