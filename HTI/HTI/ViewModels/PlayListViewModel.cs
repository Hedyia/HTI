using HTI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HTI.ViewModels
{
    public class PlayListViewModel : ViewModelBase
    {
        private string _playListUrl;

        public string PlayListUrl
        {
            get => _playListUrl;
            set { SetValue(ref _playListUrl, value); }
        }

        public PlayListViewModel(Course course)
        {
            PlayListUrl = course.PlayListUrl;
        }
    }
}
