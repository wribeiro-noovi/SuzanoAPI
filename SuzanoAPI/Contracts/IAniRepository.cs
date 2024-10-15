using SuzanoAPI.Entities;
using SuzanoAPI.Request.Ani;

namespace SuzanoAPI.Contracts
{
    public interface IAniRepository
    {
        Ani? GetStatus(RequestBodyAniJson json);
    }
}
