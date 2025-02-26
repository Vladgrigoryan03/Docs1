/*


*/
using System;

public class Student{
    public string Name;
    public string Age;
    public string Grade;

    public Student(string name, string age, string grade){
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
    }
    public void DisplayDetails(){
        Console.WriteLine($"\nname: {Name}\nage: {Age}\nGrad: {Grade}");
    }

}
class Program {

    static void Main(string[] args){
        int count = 5;
        Student [] student = new Student[count];
        string name;
        string age;
        string grade;

        for(int i = 0; i < count; ++i){
            Console.WriteLine("Check your name");
            name = Console.ReadLine();

            Console.WriteLine("Check your age");
            age = Console.ReadLine();

            Console.WriteLine("Check your grade");
            grade = Console.ReadLine();

            student[i] = new Student(name, age, grade);
        }

        for(int i = 0; i < count; ++i)
        {
            student[i].DisplayDetails();
        }
    }
}
