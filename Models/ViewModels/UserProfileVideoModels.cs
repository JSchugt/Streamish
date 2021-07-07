using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streamish.Models.ViewModels
{
    public class UserProfileVideoModels
    {
        public UserProfile userProfile { get; set; }
        public List<Video> videos { get; set; }
    }
}
