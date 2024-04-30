using Business.BLL;
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
            List<Student> students = businessBLL.GetStudents();
            StudentsView.ItemsSource = students;
        }

        private void GetStudentById_Clicked(object sender, EventArgs e)
        {
            Student student = businessBLL.GetStudent(-1);
            List<Student> students = new List<Student>();
            students.Add(student);
            StudentsView.ItemsSource = students;
        }

        private void AddStudent_Clicked(object sender, EventArgs e)
        {
            Student newStudent = new Student("Mads", DateTime.Now, DTO.Enum.StudentTypes.Master, -1);
            businessBLL.AddEmployee(newStudent);
        }

        private void DeleteStudent_Clicked(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdEntryDelete.Text);
            businessBLL.DeleteEmployee(id);
        }

        private void UpdateStudent_Clicked(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdEntryUpdate.Text);
            string name = NameEntryUpdate.Text;
            Student s = businessBLL.GetStudent(id);
            s.Name = name;
            businessBLL.EditEmployee(s);
        }

        private void GetTeams_Clicked(object sender, EventArgs e)
        {
            List<Team> teams = businessBLL.GetTeams();
            TeamsView.ItemsSource = teams;
        }

        private void AddTeam_Clicked(object sender, EventArgs e)
        {
            Team t = new Team("HoldAbC", "Det sjove hold");
            businessBLL.AddTeam(t);
        }
    }

}
