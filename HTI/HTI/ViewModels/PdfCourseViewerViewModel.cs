using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HTI.ViewModels
{
    public class PdfCourseViewerViewModel : ViewModelBase
    {

        private Stream _pdfDocumentStream;

        public Stream PdfDocumentStream
        {
            get => _pdfDocumentStream;
            set { SetValue(ref _pdfDocumentStream, value); }
        }

        public PdfCourseViewerViewModel(string fileName)
        {
            //Accessing the PDF document that is added as embedded resource as stream.
            PdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream($"HTI.Assets.{fileName}.pdf");
        }


    }
}
