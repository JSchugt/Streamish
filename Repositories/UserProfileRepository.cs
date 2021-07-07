using Microsoft.Extensions.Configuration;
using Streamish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streamish.Repositories
{
    public class UserProfileRepository : BaseRepository
    {
        UserProfileRepository(IConfiguration configuration) : base(configuration)
        {


        }


        public UserProfile GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {

            throw new NotImplementedException();
        }

        public void Add(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
