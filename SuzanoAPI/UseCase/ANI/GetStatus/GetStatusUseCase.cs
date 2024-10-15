using SuzanoAPI.Entities;
using SuzanoAPI.Contracts;
using SuzanoAPI.Request.Ani;

namespace SuzanoAPI.UseCase.ANI.GetStatus
{
    public class GetStatusUseCase
    {
        private readonly IAniRepository _repository;
        public GetStatusUseCase(IAniRepository repository) => _repository = repository;

        public Ani? Execute(RequestBodyAniJson json) => _repository.GetStatus(json);
    }
}
