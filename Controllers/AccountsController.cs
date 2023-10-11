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
    //Create Account
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

    //Validate Account
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

    [HttpPut]
}
