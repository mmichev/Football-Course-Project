using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FootballCollector;
using FootballLibraryREST.Models;

namespace FootballLibraryREST.Controllers
{
    public class FootballController : ApiController
    {
        private IFootballLibrary library = InMemoryFootballProvider.GetLibrary();
            
        [HttpGet]
        [Route("api/football")]
        public HttpResponseMessage GetFootballs()
        {
            List<Football> footballs = new List<Football>();
            return Request.CreateResponse(HttpStatusCode.OK, library.GetAll());
        }
        [HttpPost]
        [Route("api/football/add")]
        public HttpResponseMessage AddFootball()
        {
        string footballId = library.AddFootball();
            return Request.CreateResponse(HttpStatusCode.Created, footballId);
        }

        [HttpDelete]
        [Route("api/football/clean/{id}")]
        public HttpResponseMessage CleanFootball(string id)
        {
            try
            {
                library.CleanFootball(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (FootballNotFoundException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
           
        }
        [HttpPost]
        [Route("api/football")]
        public HttpResponseMessage AddAutograph([FromBody] AutographRequest request)
        {
            try
            {
                Football football = library.AddAutograph(request.Id, request.Autograph);
                return Request.CreateResponse(HttpStatusCode.OK, football);
            }
            catch (FootballFullException e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Football is full!");
            }
            catch (FootballNotFoundException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }
        [HttpGet]
        [Route("api/football/{id}")]
        public HttpResponseMessage GetFootball(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, library.GetFootball(id));
            }
            catch (FootballNotFoundException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
