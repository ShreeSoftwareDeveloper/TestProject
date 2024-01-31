namespace TestForInterView.ViewModel
{
    public class ResponseViewModel
    {
        public string StudentName { get; set; }
        public List<SubjectWithTeacher> Subjects { get; set; }
    }
    public class SubjectWithTeacher
    {
            public string SubjectName { get; set; }
            public string TeacherName { get; set; }
    }
  
}
