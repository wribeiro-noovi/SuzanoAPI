using SuzanoAPI.Entities;

namespace SuzanoAPI.Contracts
{
    public interface IMsgEmergencialRepository
    {
        Msg_emergencial? GetCurrent();
    }
}
