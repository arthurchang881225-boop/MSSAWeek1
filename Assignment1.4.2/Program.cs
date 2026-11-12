/*Write a class: “Student” with private backing fields: StudentId ( int), StudentFirstname (string), StudentLastname (string ), StudentGrade ( char ).Add a public property for each backing field. Instantiate the class and assign data to properties. Display the data back on console.*/
using System;
class Student
{
  private int studentId;
  private string studentFirstname;
  private string studentLastname;
  private char studentGrade;
  public int StudentId 
  {
    get { return studentId; }
    set { studentId = value; }
  }
  public string StudentFirstname 
  {
    get { return studentFirstname; }
    set { studentFirstname = value; }
  }
  public string StudentLastname 
  {
    get { return studentLastname; }
    set { studentLastname = value; }
  }
  public char StudentGrade 
  {
    get { return studentGrade; }
    set { studentGrade = value; }
  }
}

class Program
{
    static void Main()
  {
    Student student = new Student();
    student.StudentId = 12345;
    student.StudentFirstname = "John";
    student.StudentLastname = "Doe";
    student.StudentGrade = 'A';
    Console.WriteLine($"Student ID: {student.StudentId}");
    Console.WriteLine($"Student First Name: {student.StudentFirstname}");
    Console.WriteLine($"Student Last Name: {student.StudentLastname}");
    Console.WriteLine($"Student Grade: {student.StudentGrade}");
  }
}