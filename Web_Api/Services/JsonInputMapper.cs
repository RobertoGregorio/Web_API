using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Api.Models.DTOS;
using Web_Api.Models.InputModels;

namespace Web_Api.Services
{
    public class JsonInputMapper
    {
        public static CreatePersonDTO MapperJsonCreatePerson(CreatePersonJsonInput createPersonJsonInput)
        {
            return new CreatePersonDTO()
            {
                Age = createPersonJsonInput.Age,
                CPF = createPersonJsonInput.CPF,
                Name = createPersonJsonInput.Name,
                Email = createPersonJsonInput.Email,
                Password = createPersonJsonInput.Password
            };
        }

        public static GetPersonDTO MapperJsonGetPerson(GetPersonJsonInput getPersonJsonInput)
        {
            return new GetPersonDTO()
            {
                PersonId = getPersonJsonInput.PersonId
            };
        }

        public static UpdatePersonDTO MapperJsonUpdatePerson(UpdatePersonJsonInput updatePersonJsonInput)
        {
            return new UpdatePersonDTO()
            {
                OldPersonId = updatePersonJsonInput.OldPersonId,
                NewPersonAge = updatePersonJsonInput.NewPersonAge,
                NewPersonCPF = updatePersonJsonInput.NewPersonCPF,
                NewPersonName = updatePersonJsonInput.NewPersonName
            };
        }

        public static DeletePersonDTO MapperJsonDeletePerson(DeletePersonJsonInput deletePersonJsonInput)
        {
            return new DeletePersonDTO()
            {
                PersonId = deletePersonJsonInput.PersonId
            };
        }
    }
}
