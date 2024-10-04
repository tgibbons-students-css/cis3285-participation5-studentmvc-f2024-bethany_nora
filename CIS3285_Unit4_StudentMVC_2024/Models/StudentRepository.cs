namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class StudentRepository : IStudentCRUDInterface
    {
        static List<StudentModel> myStudents = new List<StudentModel>();

        public StudentRepository()
        {
            if (myStudents.Count == 0)
            {
                // if list is empty, initialize it
                myStudents.Add(new StudentModel(1001, "Tom", 16));
                myStudents.Add(new StudentModel(1002, "Jen", 8));
                myStudents.Add(new StudentModel(1003, "Sabah", 16));
            }

        }

        public List<StudentModel> getAllStudent()
        {
            return myStudents;
        }


        public StudentModel getStudentById(int id)
        {
            //Console.WriteLine("Getting student with id = " + id);
            //return myStudents.Find(s => s.Id == id);
            foreach (StudentModel student in myStudents)
            {
                if (student.Id == id)
                {
                    return (student);
                }
            }
            // if you can't find the correct student return the first one
            return (new NullStudent());
        }



        public StudentModel getOneStudent(int index)
        {
            return (myStudents[index]);
        }


        public void AddStudent(StudentModel newStudent)
        {
            myStudents.Add(newStudent);
        }

        public void DeleteStudent(int studentId)
        {
            // search the list for the student that matches the student ID
            // DEBT --- Handle case when student id not found and index is -1
            int index = myStudents.FindIndex(student => (student.Id == studentId));
            myStudents.RemoveAt(index);
        }

        public void UpdateStudent(int studentId, StudentModel updatedStudent)
        {
            // search the list for the student that matches the student ID
            // DEBT --- Handle case when student id not found and index is -1
            int index = myStudents.FindIndex(student => (student.Id == studentId));
            myStudents[index] = updatedStudent;
        }
    }
}
