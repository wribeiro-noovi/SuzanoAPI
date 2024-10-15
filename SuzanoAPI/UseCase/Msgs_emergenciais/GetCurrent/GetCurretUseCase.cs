using Mysqlx.Prepare;
using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;

namespace SuzanoAPI.UseCase.Msgs_emergenciais.GetCurrent
{
    public class GetCurretUseCase
    {
        private readonly IMsgEmergencialRepository _repository;
        public GetCurretUseCase(IMsgEmergencialRepository repository) => _repository = repository;

        public Msg_emergencial? Execute() => _repository.GetCurrent();
    }
}
