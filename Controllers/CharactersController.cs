using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TibiaApi.Data;
using TibiaApi.Models;
using TibiaApi.Utils;


namespace TibiaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CharactersController : ControllerBase
{
    //declarate database reference
    private readonly DataContext _context;
    public CharactersController(DataContext context)
    {
        _context = context;
    }
    //end

    //character skills
    public Skill Bruiser = new Skill()
    {
        Level = 8,
        MagicLevel = 0,
        FistFigthing = 10,
        ClubFigthing = 10,
        SwordFigthing = 10,
        AxeFigthing = 10,
        DistanceFigthing = 10,
        Shielding = 10,
        Fishing = 10
    };
    public Skill Mage = new Skill()
    {
        Level = 8,
        MagicLevel = 10,
        FistFigthing = 10,
        ClubFigthing = 10,
        SwordFigthing = 10,
        AxeFigthing = 10,
        DistanceFigthing = 10,
        Shielding = 10,
        Fishing = 10
    };
    //end

    //validations methods
    private async Task<bool> InUseCharacterName(string name)
    {
        if (await _context.TB_CHARACTERS.AnyAsync(x => x.Name.ToLower() == name.ToLower()))
        {
            return true;
        }
        return false;
    }
    private async Task<bool> CharacterCount(int accountId)
    {
        List<Character> list = await _context.TB_CHARACTERS.Where(a => a.Account.Id == accountId).ToListAsync();
        if (list.Count >= 10)
        {
            return true;
        }
        return false;
    }
    //end

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            List<Character> list = await _context.TB_CHARACTERS.ToListAsync();
            return Ok(list);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSingle(int id)
    {
        try
        {
            Character? character = await _context.TB_CHARACTERS.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(character);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("account/{id}")]
    public async Task<IActionResult> GetPerAccount(int id)
    {
        try
        {
           List<Character> list = await _context.TB_CHARACTERS
                .Where(c => c.AccountId == id).ToListAsync();
            return Ok(list);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("skill/{id}")]
    public async Task<IActionResult> GetSkill(int id)
    {
        try
        {
            Skill? skill = await _context.TB_SKILLS.FirstOrDefaultAsync(x => x.CharacterId == id);
            return Ok(skill);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost("create")]
    public async Task<IActionResult> CreateCharacter(Character newCharacter)
    {
        try
        {
            //validations
            if (newCharacter.Name == "")
                throw new Exception("Character name must be completed");

            if (await InUseCharacterName(newCharacter.Name))
                throw new Exception("Character name is already in use");

            Account? account = await _context.TB_ACCOUNTS
                .FirstOrDefaultAsync(x => x.Id == newCharacter.AccountId);

            if (account == null)
                throw new Exception("Account not found");

            if (await CharacterCount(newCharacter.AccountId))
                throw new Exception("Limit of characters per account reached");
            //end

            newCharacter.Account = account;
            newCharacter.CreationDate = DateTime.Now;

            Skill skill = new Skill();
            switch (newCharacter.Vocation)
            {
                case Models.Enums.VocationEnum.Knight:
                    newCharacter.Skills = Bruiser;
                    break;

                case Models.Enums.VocationEnum.Paladin:
                    newCharacter.Skills = Bruiser;
                    break;

                case Models.Enums.VocationEnum.Sorcerer:
                    newCharacter.Skills = Mage;
                    break;

                case Models.Enums.VocationEnum.Druid:
                    newCharacter.Skills = Mage;
                    break;
            }

            await _context.TB_CHARACTERS.AddAsync(newCharacter);
            await _context.TB_SKILLS.AddAsync(newCharacter.Skills);
            await _context.SaveChangesAsync();
            string message = "Character created successfully";
            return Ok(message);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(int id)
    {
        try
        {
            Character searchChar = await _context.TB_CHARACTERS.FirstOrDefaultAsync(p => p.Id == id);
            Skill searchSkill = await _context.TB_SKILLS.FirstOrDefaultAsync(p => p.CharacterId == id);

            _context.TB_CHARACTERS.Remove(searchChar);
            _context.TB_SKILLS.Remove(searchSkill);
            await _context.SaveChangesAsync();
            return Ok("Character deleted successfully");
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}