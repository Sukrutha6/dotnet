namespace Management
{
    public static class DataBank
    {
        public static List<Student> students;
        static DataBank()
        {
            students.Add(new Student(){ StudentId=1, Name="Sukrutha", ClassName="First Year BE CSC"});
            students.Add(new Student(){ StudentId=1, Name="Karthik", ClassName="First Year BE CSC"});
            students.Add(new Student(){ StudentId=1, Name="Manju", ClassName="First Year BE CSC"});
            students.Add(new Student(){ StudentId=1, Name="Vijay", ClassName="First Year BE CSC"});
            students.Add(new Student(){ StudentId=1, Name="Kumar", ClassName="First Year BE CSC"});
            students.Add(new Student(){ StudentId=1, Name="Madhavi", ClassName="First Year BE CSC"});
        }
        public static List<Student> GetStudents()
        {
            return students;
        }
    }
}