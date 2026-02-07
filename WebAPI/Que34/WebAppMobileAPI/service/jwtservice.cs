using WebAppMobileAPI.Models;

namespace WebApplicationAPI.service
{
    public class jwtservice
    {
        private readonly MobileManagedContext _dbContext;
        private readonly IConfiguration _configuration;

        public jwtservice(MobileManagedContext db,IConfiguration co)
        {
            _dbContext = db;
            _configuration = co;
        }

        public async
    }
}
