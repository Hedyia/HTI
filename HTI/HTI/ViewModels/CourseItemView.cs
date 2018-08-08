using HTI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTI.ViewModels
{
    public class CourseItemView
    {
        public CourseItemView(Course course)
        {
            var staticResource = MainViewModel.StaticMainView();
            staticResource.CourseDetail = new CourseDetailViewModel(course);
            staticResource.pdfCourseViewer = new PdfCourseViewerViewModel(course.PdfFileName);
            staticResource.playList = new PlayListViewModel(course);
        }
    }
}
