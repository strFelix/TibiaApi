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


namespace TibiaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        //declarate database reference
        private readonly DataContext _context;
        public CharactersController(DataContext context){
            _context = context;
        }
        //end

        private async Task<bool> InUseCharacterName(string name){
        if (await _context.TB_CHARACTERS.AnyAsync(x => x.Name.ToLower() == name.ToLower()))
        {
            return true;
        }
            return false;
        }
        //end

        [HttpPost("CreateCharacter")]
        public async Task<IActionResult> CreateCharacter(Character newCharacter)
        {
            try
            {
                if(newCharacter.Name == "")
                    throw new Exception("Character name must be completed");

                if(await InUseCharacterName(newCharacter.Name))
                    throw new Exception("Character name is already in use");

                Account? account = await _context.TB_ACCOUNTS
                    .FirstOrDefaultAsync(x => x.Id == newCharacter.AccountId);

                if(account == null)
                    throw new Exception("Account not found");

                newCharacter.Account = account;
                newCharacter.CreationDate = DateTime.Now;
                newCharacter.Skills.CharacterId = newCharacter.Id;

                Skill skill = new Skill();
                switch(newCharacter.Vocation){
                    case Models.Enums.VocationEnum.Knight:
                        newCharacter.Skills = skill.DefaultSkills;
                        break;

                    case Models.Enums.VocationEnum.Paladin:
                        newCharacter.Skills = skill.DefaultSkills;
                        break;
                    
                    case Models.Enums.VocationEnum.Sorcerer:
                        newCharacter.Skills = skill.DefaultMageSkills;
                        break;

                    case Models.Enums.VocationEnum.Druid:
                        newCharacter.Skills = skill.DefaultMageSkills;
                        break;
                }

                await _context.TB_CHARACTERS.AddAsync(newCharacter);
                await _context.TB_SKILLS.AddAsync(newCharacter.Skills);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }    
    }
}