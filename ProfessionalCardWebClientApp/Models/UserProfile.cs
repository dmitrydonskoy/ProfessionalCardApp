namespace ProfessionalCardWebClientApp.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public string Interests { get; set; }
        public List<string> SavedProfessions { get; set; }
        public List<string> SavedCourses { get; set; }
        public string CurrentRoute { get; set; }
        public List<string> CompletedSteps { get; set; }
        public List<string> Recommendations { get; set; }
    }
}
