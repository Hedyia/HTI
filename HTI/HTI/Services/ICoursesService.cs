using HTI.Models;
using System.Collections.ObjectModel;

namespace HTI.Services
{
    public interface ICoursesService
    {
        ObservableCollection<Course> GetCourses();
    }
}
