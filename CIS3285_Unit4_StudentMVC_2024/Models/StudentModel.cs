using System.ComponentModel.DataAnnotations;

namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class StudentModel : IStudentInterface
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public StudentModel(int id, string name, int credits)
        {
            Id = id;
            Name = name;
            Credits = credits;
        }
        public StudentModel()
        {
            Id = -1;
            Name = "none";
            Credits = -1;
        }
    }

}
