using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TibiaApi.Data;
using TibiaApi.Models;
using TibiaApi.Utils;


namespace TibiaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{

    [HttpPost("CreateAccount")]
    public async Task<IActionResult> CreateAccount(Account newAccountInfo)
    {
        try
        {
            return Ok();
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("DeleteAccount")]
    public async Task<IActionResult> DeleteAccount(Account existingAccountInfo)
    {
        try
        {
            return Ok();
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("ValidateAccount")]
    public async Task<IActionResult> ValidateAccount(Account existingAccountInfo)
    {
        try
        {
            return Ok();
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("ChangePassword")]
    public async Task<IActionResult> ChangePassword(Account existingAccountInfo)
    {
        try
        {
            return Ok();
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("ChangeEmail")]
    public async Task<IActionResult> ChangeEmail(Account existingAccountInfo)
    {
        try
        {
            return Ok();
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
