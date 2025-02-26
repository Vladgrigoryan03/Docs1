using System;

class Student{
    private string _studentName;
    private int _studentAge;
    private double _studentGrade;

    public Student(string name, int age, double grade){
        _studentName = name;
        _studentAge = age;
        _studentGrade = grade;
    }
    public string StudentName { 
        get { 
            return _studentName!;
            }
        set {
            _studentName = value;
        }    
    }
    public int StudentAge {
        get {
            return _studentAge;
        }
        set {
            _studentAge = value;
        }
    }
   
    public double StudentGrade{
        get {
            return _studentGrade;
        }
        set{
            _studentGrade = value;
        }
    }
}
    class Teacher{
        private string _teacherName;
        private string _teacherSubject;
        private double _teacherExperience;
    

    public Teacher(string name, string subject, double experience){
        _teacherName = name;
        _teacherSubject = subject;
        _teacherExperience = experience;
    }
    public string TeacherName{
        get {
            return  _teacherName;
        }
        set{
            _teacherName = value;
        }
    }
    public string TeacherSubject{
        get{
            return _teacherSubject;
        }
        set{
            _teacherSubject = value;
        }
    }
    public double TeacherExperience{
        get {
            return _teacherExperience;
        }
        set {
            _teacherExperience = value;
        }
    }
    }
    class Program{
        public static void student_grade(Student[] student){
            double max = 0;
            string name = "";
            //int index = 0;
            for(int i = 0; i < 5; ++i){
                if(student[i].StudentGrade > max){
                    max = student[i].StudentGrade;
                    //index = i;
                    name = student[i].StudentName;
                }
            }
            Console.WriteLine($"The max grade is {name} and your grade {max}");
        }
        public static void teacher_experience(Teacher[] teacher){
            
            for(int i = 0; i < 5; ++i){
                if(teacher[i].TeacherExperience < 2){
                    Console.WriteLine($"{teacher[i].TeacherName}");
                }
            }
        }
        static void Main(string[] args){
            Student[] student = new Student[5];
            student[0] = new Student("Dav", 22, 8.8);
            student[1] = new Student("Gag", 20, 8.9);
            student[2] = new Student("Vlad", 21, 7.5);
            student[3] = new Student("Arame", 17, 8.0);
            student[4] = new Student("Narek", 21, 7.5);

            Teacher[] teacher = new Teacher[5];
            teacher[0] = new Teacher("Hayk Darbinyan","Arxitektura", 6);
            teacher[1] = new Teacher("Hayk Hakobyan","C#", 0.5);
            teacher[2] = new Teacher("Kima","C++", 3);
            teacher[3] = new Teacher("Anna","TeamLead", 1.5);
            teacher[4] = new Teacher("Tamara","Arxitektura", 5);
              
            student_grade(student);
            teacher_experience(teacher);  
        }
    }

