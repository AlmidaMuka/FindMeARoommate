// See https://aka.ms/new-console-template for more information
using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;


//Retrieve and print all students records


var context= new Roommate_DBContext();
var students=context.Students.ToList();

foreach  (var s in students)
{

    Console.WriteLine(s.Name+ " " + s.Surname + " " + s.Address );
}

//Add dormitory

//take data from UI(Console)

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Register");
var student = new Student();
Console.WriteLine("Enter your name");
student.Name=Console.ReadLine();
Console.WriteLine(student.Name);

//Add student to database
AddStudent(context);
static void AddStudent(Roommate_DBContext? context)
{
    Console.WriteLine("Enter student name: ");
    string name = Console.ReadLine();

    Console.WriteLine(" Enter your surname:");
    string surname = Console.ReadLine();


    Console.WriteLine(" Enter your Adress:");
    string address = Console.ReadLine();

    Console.WriteLine(" Enter your Gender:");
    string gender = Console.ReadLine();

    Console.WriteLine(" Enter your Emial:");
    string email = Console.ReadLine();
    Console.WriteLine(" Enter your Password:");
    string password = Console.ReadLine();

    
    var student = new Student();
    student.Name = Console.ReadLine();
    student.Surname = Console.ReadLine();
    student.Address = Console.ReadLine();
    student.Gender = Console.ReadLine();
    student.Email = Console.ReadLine();
    student.Password = Console.ReadLine();

    context.Students.Add(student);
    context.SaveChanges();

}


