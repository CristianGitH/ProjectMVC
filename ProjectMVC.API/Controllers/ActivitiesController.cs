using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectMVC.API.Controllers
{
    [RoutePrefix("api/Activities")]
    public class ActivitiesController : ApiController
    {
        [Route("GetActivities")]
        public IHttpActionResult GetActivities()
        {
            try
            {
                Logica.Services.Activities activities = new Logica.Services.Activities();
                var listActivities = activities.GetActivities();

                return Ok(listActivities);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        [Route("CreateActivity")]
        public IHttpActionResult CreateActivities(Logica.Models.BindingModels.ActivitiesCreateBindingModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                Logica.Services.Activities activities = new Logica.Services.Activities();
                activities.CreateActivity(model.Name);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        [Route("EditActivity")]
        public IHttpActionResult EditActivities(Logica.Models.BindingModels.ActivitiesEditBindingModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                Logica.Services.Activities activities = new Logica.Services.Activities();
                activities.UpdateActivity(model.Id, model.Name, model.Active);

                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        [Route("DeleteActivity")]
        public IHttpActionResult DeleteActivities(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                Logica.Services.Activities activities = new Logica.Services.Activities();
                activities.DeleteActivity(id);

                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
