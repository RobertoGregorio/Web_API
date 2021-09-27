using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Api.DataBase;
using Web_Api.Models.DAOS;
using Web_Api.Models.DTOS;
using Web_Api.Models.Entities;

namespace Web_Api.Services
{
    public class PersonService
    {
        public static Person CreatePerson(CreatePersonDTO createPersonDTO)
        {
            try
            {
                Person person = new Person()
                {
                    Name = createPersonDTO.Name,
                    Age = createPersonDTO.Age,
                    CPF = createPersonDTO.CPF,
                    CreationDate = DateTime.Now
                };

                PersonDAO personDAO = new PersonDAO();
                personDAO.SavePerson(person);


                Credential credential = new Credential()
                {
                    PersonId = person.Id,
                    email = createPersonDTO.Email,
                    Password = createPersonDTO.Password,
                    CreationDate = DateTime.Now
                };

                CredentialDAO credentialDAO = new CredentialDAO();
                credentialDAO.SaveCredential(credential);

                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Person GetPerson(long PersonId)
        {
            PersonDAO personDAO = new PersonDAO();

            return personDAO.GetPersonById(PersonId);
        }


        public static void UpdatePerson(UpdatePersonDTO updatePersonDTO) 
        {
            Person newPersonInfo = new Person()
            {
                Age = updatePersonDTO.NewPersonAge,
                CPF = updatePersonDTO.NewPersonCPF,
                Name = updatePersonDTO.NewPersonName,
            };

            long oldPersonId = updatePersonDTO.OldPersonId;

            PersonDAO personDAO = new PersonDAO();
            personDAO.UpdatePerson(newPersonInfo, oldPersonId);
        }

        public static void DeleterPerson(DeletePersonDTO deletePersonDTO)
        {
            long personId = deletePersonDTO.PersonId;
            new PersonDAO().DeleterPersonById(personId);
            
            
        }
    }
}