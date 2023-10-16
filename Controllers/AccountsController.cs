using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TibiaApi.Data;
using TibiaApi.Models;
using TibiaApi.Utils;


namespace TibiaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{

    //declarate database reference
    private readonly DataContext _context;
    public AccountsController(DataContext context){
        _context = context;
    }
    //end

    private async Task<bool> InUseUsername(string username){
        if (await _context.TB_ACCOUNTS.AnyAsync(x => x.Username.ToLower() == username.ToLower()))
        {
            return true;
        }
        return false;
    }

    private async Task<bool> InUseEmail(string email){
        if (await _context.TB_ACCOUNTS.AnyAsync(x => x.Email.ToLower() == email.ToLower()))
        {
            return true;
        }
        return false;
    }


    [HttpPost("CreateAccount")]
    public async Task<IActionResult> CreateAccount(Account newAccount)
    {
        try
        {
            //validations
            if(newAccount.Username == "" || newAccount.PasswordString == "" || newAccount.Email == "")
                throw new System.Exception("All credentials must be completed");

            if(await InUseUsername(newAccount.Username))
                throw new System.Exception("Username is already in use");
            
            if(await InUseEmail(newAccount.Email))
                throw new System.Exception("Email is already in use");
            //end 

            Cryptography.CreatePasswordHash(newAccount.PasswordString, out byte[] hash, out byte[]salt);
            newAccount.PasswordString = string.Empty;
            newAccount.PasswordHash = hash;
            newAccount.PasswordSalt = salt;
            newAccount.CreationDate = DateTime.Now;

            await _context.TB_ACCOUNTS.AddAsync(newAccount);
            await _context.SaveChangesAsync();

            string message = $"Id: {newAccount.Id}, Username: {newAccount.Username}, has been created.";
            return Ok(message);
             
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("DeleteAccount")]
    public async Task<IActionResult> DeleteAccount(Account existingAccount)
    {
        try
        {
            Account? accountFound = await _context.TB_ACCOUNTS
                .FirstOrDefaultAsync(x => 
                    x.Id == existingAccount.Id &&
                    x.Username.ToLower() == existingAccount.Username.ToLower() &&
                    x.Email.ToLower() == existingAccount.Email.ToLower()
                );

            if(accountFound == null){
                throw new System.Exception("Account not found");
            }
            else if(!Cryptography.ValidatePasswordHash(existingAccount.PasswordString, accountFound.PasswordHash, accountFound.PasswordSalt)){
                throw new System.Exception("Incorrect password");
            }
            else{
                _context.TB_ACCOUNTS.Remove(accountFound);
                await _context.SaveChangesAsync();
                string message = $"Id: {accountFound.Id}, Username: {accountFound.Username}, has been deleted.";
                return Ok(message);
            }
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("ValidateAccount")]
    public async Task<IActionResult> ValidateAccount(Account accountCredentials)
    {
        try
        {
            Account? accountFound = await _context.TB_ACCOUNTS
                .FirstOrDefaultAsync(x => 
                    x.Email.ToLower() == accountCredentials.Email.ToLower()
                );
            
            if(accountFound == null){
                throw new System.Exception("Account not found");
            }
            else if(!Cryptography.ValidatePasswordHash(accountCredentials.PasswordString, accountFound.PasswordHash, accountFound.PasswordSalt)){
                throw new System.Exception("Incorrect password");
            }
            else{
                accountFound.AcessDate = DateTime.Now;
                await _context.SaveChangesAsync();
                string message = $"Account {accountFound.Username} has been logged in";
                return Ok(message);
            }
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("ChangePassword")]
    public async Task<IActionResult> ChangePassword(Account accountCredentials, [FromBody] string newPassword)
    {
        try
        {
            Account? accountFound = await _context.TB_ACCOUNTS
                .FirstOrDefaultAsync(x => 
                    x.Username.ToLower() == accountCredentials.Username.ToLower() ||
                    x.Email.ToLower() == accountCredentials.Email.ToLower()
                );

            if(accountFound == null){
                throw new System.Exception("Account not found");
            }
            else if(!Cryptography.ValidatePasswordHash(accountCredentials.PasswordString, accountFound.PasswordHash, accountFound.PasswordSalt)){
                throw new System.Exception("Incorrect password");
            }
            else{
                Cryptography.CreatePasswordHash(newPassword, out byte[] hash, out byte[]salt);
                accountFound.PasswordHash = hash;
                accountFound.PasswordSalt = salt;
                await _context.SaveChangesAsync();

                return Ok("Password changed successfully");
            }
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("ChangeEmail")]
    public async Task<IActionResult> ChangeEmail(Account accountCredentials, string newEmailAccount)
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
