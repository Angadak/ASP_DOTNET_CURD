using MagicVilla.Models;
using MagicVilla.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace MagicVilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {


        // Initilizing Constructor
        private readonly IConfiguration _configuration;
        private readonly ApplicationContext _db;


        public VillaController(ApplicationContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;

        }



        //Get Villa Method
        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<DTOClass>> GetVillas()
        {
            return Ok(_db.VillaAPI.ToList());
        }



        //Get villas by Id
        //[Authorize]
        [HttpGet("Id", Name = "GetVillas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DTOClass> GetVillas(int Id)

        {
            if (Id == 0)
            {
                return BadRequest(401);

            }
            var villa = _db.VillaAPI.FirstOrDefault(u => u.Id == Id);
            if (villa == null)
            {
                return NotFound(404);

            }
            return Ok(villa);
        }



        //PostConstruct Villas Method
        [HttpPost]
        [Route("BuildVilla")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DTOClass> BuildVilla([FromBody] DTOClass dTOClass)
        {
            if (dTOClass == null)
            {
                return BadRequest();
            }

            if (_db.VillaAPI.Any(u => u.Name.ToLower() == dTOClass.Name.ToLower()))
            {
                ModelState.AddModelError("Error", "Villa Already Exists");
                return BadRequest(ModelState);
            }

            var model = new Villa
            {
                Name = dTOClass.Name,
                Description = dTOClass.Description,
                Rate = dTOClass.Rate,
                sqrt = dTOClass.sqrt,
                Occupancy = dTOClass.Occupancy,
                image = dTOClass.image,
                Aminety = dTOClass.Aminety
            };
            _db.VillaAPI.Add(model);
            _db.SaveChanges();

            dTOClass.Id = model.Id; // Assign the generated ID to the DTOClass object

            return CreatedAtRoute("GetVillas", new { id = model.Id }, dTOClass);
        }



        //login To Villa 
        [HttpPost]
        [Route("LoginVilla")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DTOClass> LoginVilla([FromBody] DTOClass dTOClass)
        {
            try
            {

                if (dTOClass == null)
                {
                    return BadRequest();
                }
                var entity = _db.VillaAPI.Find(dTOClass.Id);

                if (entity == null)
                {
                    return NotFound();
                }

                if (_db.VillaAPI.Any(u => u.Name.ToLower() == dTOClass.Name.ToLower()) && _db.VillaAPI.Any(u => u.sqrt != 0))
                {
                    var name = entity.Name;
                    var dis = entity.Description;
                    var rate = entity.Rate;
                    var sqrt = entity.sqrt;
                    var ocuupancy = dTOClass.Occupancy;
                    var image = dTOClass.image;
                    var Aminety = dTOClass.Aminety;
                    var acesstoken = GenerateToken(dTOClass);

                    Dictionary<string, String> abc = new Dictionary<string, String>
                    {
                        ["name"] = entity.Name,
                        ["Description"] = entity.Description,
                        ["sqrt"] = entity.sqrt.ToString(),
                        ["Rate"] = entity.Rate.ToString(),
                        ["image"] = entity.image,
                        ["Occupancy"] = entity.Occupancy.ToString(),
                        ["Aminety"] = entity.Aminety,
                        ["acess"] = acesstoken
                    };
                    return Ok(abc);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }

            return Unauthorized();

        }


        //Generating jwt token for authorization 
        private string GenerateToken(DTOClass dTOClass)
        {
            var claims = new[]
            {
              new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
              new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

             };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signin = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"],
            claims,
            expires: DateTime.UtcNow.AddMinutes(10),
            signingCredentials: signin);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }



        //Deconstruct villas    
        [HttpDelete("int:Id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<DTOClass> Deconstruct(int Id, Villa villa)
        {

            if (_db.VillaAPI.FirstOrDefault(u => u.Id == Id) == null)
            {
                ModelState.AddModelError("Error", "Villa does not Exist");
                return NotFound(ModelState);
            }
            else
            {
                _db.VillaAPI.Remove(_db.VillaAPI.FirstOrDefault(u => u.Id == Id));
                _db.SaveChanges();
                ModelState.AddModelError("Message", "Villa has been deconstructed Sucessfully");
                return Ok(ModelState);
            }

        }



        //Updateing Villas
        [HttpPut("int:Id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOClass> renovate(int Id, [FromBody] DTOClass dTOClass)
        {


            var villa = _db.VillaAPI.FirstOrDefault(u => u.Id == Id);
            if (villa == null)
            {
                ModelState.AddModelError("Error", "Villa does not Exist");
                return NotFound(ModelState);
            }
            else
            {
                Villa model = new()
                {
                    Id = dTOClass.Id,
                    Name = dTOClass.Name,
                    Description = dTOClass.Description,
                    Rate = dTOClass.Rate,
                    sqrt = dTOClass.sqrt,
                    Occupancy = dTOClass.Occupancy,
                    image = dTOClass.image,
                    Aminety = dTOClass.Aminety,

                };
                _db.VillaAPI.Update(model);
                _db.SaveChanges();
                ModelState.AddModelError("Message", "Villa has been Renovated Sucessfully");
                return Ok(ModelState);
            }


        }



        //Updateing villas with the help of patch method 
        [HttpPatch("int:Id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOClass> renovateIndividually(int Id, JsonPatchDocument<DTOClass> PatchDto)
        {
            var villa = _db.VillaAPI.AsNoTracking().FirstOrDefault(u => u.Id == Id);


            if (PatchDto == null || Id == 0)
            {
                return BadRequest();

            }
            if (villa == null)
            {
                return NotFound();
            }
            else
            {
                DTOClass DTOClass = new()
                {
                    Id = villa.Id,
                    Name = villa.Name,
                    Description = villa.Description,
                    Rate = villa.Rate,
                    sqrt = villa.sqrt,
                    Occupancy = villa.Occupancy,
                    image = villa.image,
                    Aminety = villa.Aminety
                };
                PatchDto.ApplyTo(DTOClass, ModelState);
                Villa model = new Villa()
                {
                    Id = DTOClass.Id,
                    Name = DTOClass.Name,
                    Description = DTOClass.Description,
                    Rate = DTOClass.Rate,
                    sqrt = DTOClass.sqrt,
                    Occupancy = DTOClass.Occupancy,
                    image = DTOClass.image,
                    Aminety = DTOClass.Aminety
                };
                _db.VillaAPI.Update(model);
                _db.SaveChanges();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok();
            }



        }
    }
}