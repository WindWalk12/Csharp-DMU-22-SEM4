﻿using Business.BLL;
using DTO.Model;
namespace GUI
{
    public partial class MainPage : ContentPage
    {
        BusinessBLL businessBLL = new BusinessBLL();

        public MainPage()
        {
            InitializeComponent();
        }


        private void GetStudents_Clicked(object sender, EventArgs e)
        {
            List<Student> students = businessBLL.getStudents();
            StudentsView.ItemsSource = students;
        }

        private void GetStudentById_Clicked(object sender, EventArgs e)
        {
            Student student = businessBLL.getStudent(-1);
            List<Student> students = new List<Student>();
            students.Add(student);
            StudentsView.ItemsSource = students;
        }

        private void AddStudent_Clicked(object sender, EventArgs e)
        {
            Student newStudent = new Student("Mads", DateTime.Now, DTO.Enum.StudentTypes.Master);
            businessBLL.AddEmployee(newStudent);
        }
    }

}