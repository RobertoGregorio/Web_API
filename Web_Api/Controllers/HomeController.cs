using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api.DataBase;
using Web_Api.Models.DAOS;
using Web_Api.Models.DTOS;
using Web_Api.Models.Entities;
using Web_Api.Models.InputModels;
using Web_Api.Services;

namespace Web_Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult teste(CreatePersonJsonInput createPersonJsonInput)
        {
            try
            {
                Validators.ValidateModel(createPersonJsonInput);

                CreatePersonDTO createPersonDTO = JsonInputMapper.MapperJsonCreatePerson(createPersonJsonInput);

                Person person = PersonService.CreatePerson(createPersonDTO);

                return  Ok(new { Status = "sucess", PersonId = person.Id });
            }
            catch (Exception ex)
            {
                return BadRequest($"Status: error - {ex.Message}");
            }

        }

        [HttpGet]
        public IHttpActionResult GetPerson(GetPersonJsonInput getPersonJsonInput)
        {
            try
            {
                Validators.ValidateModel(getPersonJsonInput);

                GetPersonDTO getPersonDTO = JsonInputMapper.MapperJsonGetPerson(getPersonJsonInput);

                Person person = PersonService.GetPerson(getPersonDTO.PersonId);

                return Ok(new { Status = "sucess", Person = person });
            }
            catch (Exception ex)
            {
                return BadRequest($"Status: error - {ex.Message}");
            }
        }

        [HttpPut]
        public IHttpActionResult UpdatePerson(UpdatePersonJsonInput updatePersonJsonInput)
        {
            try
            {
                Validators.ValidateModel(updatePersonJsonInput);

                UpdatePersonDTO updatePersonDTO = JsonInputMapper.MapperJsonUpdatePerson(updatePersonJsonInput);
                PersonService.UpdatePerson(updatePersonDTO);

                return Ok(new { Status = "sucess", message = $" Informações da Pessoa Atualizadas , PersonId: {updatePersonJsonInput.OldPersonId} " });
            }
            catch (Exception ex)
            {
                return BadRequest($"Status: error - {ex.Message}");
            }
        }

        [HttpDelete]
        public IHttpActionResult DeletePerson(DeletePersonJsonInput deletePersonJsonInput)
        {
            try
            {
                Validators.ValidateModel(deletePersonJsonInput);

                DeletePersonDTO deletePersonDTO = JsonInputMapper.MapperJsonDeletePerson(deletePersonJsonInput);

                return Ok(new { Status = "sucess", message = "Pessoa Deletada" });

            }
            catch (Exception ex)
            {
                return BadRequest($"Status: error - {ex.Message}");
            }
        }
    }
}
