using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendWork.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
