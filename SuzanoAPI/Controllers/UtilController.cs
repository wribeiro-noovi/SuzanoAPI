using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Request.Util;
using SuzanoAPI.Util.Doc;

namespace SuzanoAPI.Controllers
{
    public class UtilController : SuzanoBaseController
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPost("ValidarDocumento")]
        public IActionResult GetDocValido([FromBody] RequestBodyUtilJson doc)
        {
            if (VerificarNumero.VerificarDoc(doc))
            {
                return Ok(true);
            }
            else return BadRequest(false);
        }
    }
}
