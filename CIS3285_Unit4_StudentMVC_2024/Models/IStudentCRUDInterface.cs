namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public interface IStudentCRUDInterface
    {
        public List<IStudentInterface> getAllStudent();
        public IStudentInterface getStudentById(int id);
        public void AddStudent(IStudentInterface newStudent);
        public void UpdateStudent(int studentId, IStudentInterface updatedStudent);
        public void DeleteStudent(int studentId);
    }
}
