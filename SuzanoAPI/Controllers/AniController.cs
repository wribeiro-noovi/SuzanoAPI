using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Request.Ani;
using SuzanoAPI.UseCase.ANI.GetStatus;

namespace SuzanoAPI.Controllers
{
    public class AniController : SuzanoBaseController
    {
        [HttpPost("GetStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetStatus([FromBody] RequestBodyAniJson json,
                                       [FromServices] GetStatusUseCase useCase)
        {
            var phone = useCase.Execute(json);

            if(phone is null) return NoContent();
            return Ok(phone.Status);
        }
    }
}
