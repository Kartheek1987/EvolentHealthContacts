using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ContactWebApiController : ApiController
    {
        ContactsProvider ContactsProvider = new ContactsProvider();

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ContactsProvider.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [AcceptVerbs("POST", "PUT")]
        public HttpResponseMessage Post(Contact contact)
        {
            if (!ModelState.IsValid || contact == null)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            var flag = ContactsProvider.Upsert(contact, contact.Id == 0 ? true : false);

            if (flag)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [HttpDelete]
        public HttpResponseMessage Delete(Contact contact)
        {
            if (contact == null)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            var flag = ContactsProvider.Delete(contact);

            if (flag)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
