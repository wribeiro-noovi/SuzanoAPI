using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;

namespace SuzanoAPI.Repositories.DataAcess
{
    public class MsgEmergencialRepository : IMsgEmergencialRepository
    {
        private readonly SuzanoDbContext _context;
        public MsgEmergencialRepository(SuzanoDbContext context) => _context = context;

        public Msg_emergencial? GetCurrent() => _context.msg_emergencial.FirstOrDefault(msg => msg.Status == true);
    }
}
