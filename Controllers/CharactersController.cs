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

        //character skills
        public Skill Bruiser = new Skill(){
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
        public Skill Mage = new Skill(){
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

        //validations
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
                
                Skill skill = new Skill();
                switch(newCharacter.Vocation){
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
                return Ok();
            }
            catch (System.Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }    
    }
}