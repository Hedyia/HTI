using HTI.Models;
using HTI.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HTI.Helpers
{
    public class DatabaseHelper
    {
        private SQLiteAsyncConnection _sqliteConnection;
        private ObservableCollection<Course> _courses;
        public ObservableCollection<Course> Courses { get; set; }

        public DatabaseHelper()
        {
            _sqliteConnection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _sqliteConnection.CreateTableAsync<Course>();
            LoadTable();
        }

        private async void LoadTable()
        {
            var courses = await _sqliteConnection.Table<Course>().ToListAsync();
            Courses = new ObservableCollection<Course>(courses);
        }

        // Get All Courses data      
        public async Task<ObservableCollection<Course>> GetAllCoursesData()
        {
            var courses = await _sqliteConnection.Table<Course>().ToListAsync();
            _courses = new ObservableCollection<Course>(courses);
            return _courses;
        }
        public async Task<ObservableCollection<Course>> GetAllFavCoursesData()
        {
            var courses = await _sqliteConnection.Table<Course>().Where(c=>c.IsFavoirate == true).ToListAsync();
            _courses = new ObservableCollection<Course>(courses);
            return _courses;
        }

        // Delete all Contacts Data  
        public async void DeleteAllCourses()
        {
            await _sqliteConnection.DropTableAsync<Course>();
        }

        // Delete Specific Contact  
        public async void DeleteCourse(Course course)
        {
             await _sqliteConnection.DeleteAsync(course);
        }

        // Insert new Course to DB   
        public void InsertCourse(Course course)
        {
            _sqliteConnection.InsertAsync(course);
        }
        public async void InsertAllCourses(IEnumerable<Course> courses)
        {
            await _sqliteConnection.InsertAllAsync(courses);
        }

        // Update Course Data  
        public async void UpdateContact(Course course)
        {
            await _sqliteConnection.UpdateAsync(course);
        }
    }
}
