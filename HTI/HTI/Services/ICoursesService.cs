using HTI.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HTI.Services
{
    public interface ICoursesService
    {
        Task<ObservableCollection<Course>> GetCourses();
    }
}
