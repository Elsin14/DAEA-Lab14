using API_Lab14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Lab14.Controllers
{
    public class PersonsController : ApiController
    {
        public List<PersonResponse> Get()
        {
            var result = new List<PersonResponse>();
            for(int i=0; i < 1; i++)
            {
                result.Add(new PersonResponse { FullName = "Elsin Vila" });
                result.Add(new PersonResponse { FullName = "Yeridi Huaman" });
                result.Add(new PersonResponse { FullName = "Gustavo Blanco" });
                result.Add(new PersonResponse { FullName = "Marcos Lavado" });
                result.Add(new PersonResponse { FullName = "Brayan Blas" });
            }
            return result;
        }

        public PersonResponse Insert(PersonRequest request)
        {
            var result = new PersonResponse();

            result.FullName = string.Concat(request.FirstName, request.LastName);

            return result;
        }

    }
}
