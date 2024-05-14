using Business.BLL;
using DTO.Model;
using System.Net.Http.Json;
namespace GUI
{
    public partial class MainPage : ContentPage
    {
        BusinessBLL businessBLL = new BusinessBLL();

        public MainPage()
        {
            InitializeComponent();
        }


        private async void GetStudents_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            List<Student> students = await client.GetFromJsonAsync<List<Student>>("http://localhost:5183/api/Students/ShowStudents");
            StudentsView.ItemsSource = students;
        }

        private async void GetStudentById_Clicked(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(IdEntryGetStudent.Text);
            HttpClient client = new HttpClient();
            Student student = await client.GetFromJsonAsync<Student>($"http://localhost:5183/api/Students/GetStudentById/{StudentId}");
            List<Student> students = new List<Student> { student };
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

        private void AddStudentToTeam_Clicked(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(IdEntryStudent.Text);
            int TeamId = Convert.ToInt32(IdEntryTeam.Text);
            businessBLL.AddStudentToTeam(StudentId, TeamId);
        }

        private void ShowStudentsOnTeam_Clicked(object sender, EventArgs e)
        {
            int TeamId = Convert.ToInt32(IdEntryTeam.Text);
            TeamDetail teamDetail = businessBLL.GetTeamDetail(TeamId);
            StudentsOnTeamView.ItemsSource = teamDetail.Students;
        }
    }
}
