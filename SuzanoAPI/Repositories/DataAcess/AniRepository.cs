using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;
using SuzanoAPI.Request.Ani;

namespace SuzanoAPI.Repositories.DataAcess
{
    public class AniRepository : IAniRepository
    {
        private readonly SuzanoDbContext _context;
        public AniRepository(SuzanoDbContext context) => _context = context;

        public Ani? GetStatus(RequestBodyAniJson json) => _context.ani.FirstOrDefault(ani => ani.Phone == json.phone);
    }
}
