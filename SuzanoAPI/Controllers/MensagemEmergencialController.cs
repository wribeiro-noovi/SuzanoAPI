using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Entities;
using SuzanoAPI.UseCase.Msgs_emergenciais.GetCurrent;

namespace SuzanoAPI.Controllers
{
    public class MensagemEmergencialController : SuzanoBaseController
    {
        [HttpPost("GetCurrent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrent([FromServices] GetCurretUseCase useCase)
        {
            var msg = useCase.Execute();

            if (msg is null) return NoContent();
                return Ok(msg.Path);
        }
    }
}
