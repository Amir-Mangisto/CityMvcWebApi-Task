using CityMvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityMvcWebApi.Controllers.API
{
    public class CityController : ApiController
    {
        static string connectionString = "Data Source=DESKTOP-IGIOI52;Initial Catalog=CityDB;Integrated Security=True;Pooling=False";
        CityContextDataContext CityContext = new CityContextDataContext(connectionString);

        // GET: api/City
        public IHttpActionResult Get()
        {
            try
            {
                
                return Ok(CityContext.Citizens.ToList());
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/City/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(CityContext.Citizens.First(item => item.Id == id));
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/City
        public IHttpActionResult Post([FromBody] Citizen citizen)
        {
            try
            {
                CityContext.Citizens.InsertOnSubmit(citizen);
                CityContext.SubmitChanges();
                return Ok("UPDATE SUCSSES");
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);    
            }
        }

        // PUT: api/City/5
        public IHttpActionResult Put(int id, [FromBody] Citizen citizen)
        {
            Citizen citizenOne = CityContext.Citizens.First(citizenItem => citizenItem.Id == id);
            if(citizenOne == null)
            {
                citizenOne.FirstName = citizen.FirstName;
                citizen.LastName = citizen.LastName;
                citizen.Birth= citizenOne.Birth;
                citizen.YearsInCity = citizenOne.YearsInCity;
                citizen.Adress= citizenOne.Adress;
            }
            CityContext.SubmitChanges();
            return Ok("change Saved");
        }

        // DELETE: api/City/5
        public IHttpActionResult Delete(int id)
        {
            CityContext.Citizens.DeleteOnSubmit(CityContext.Citizens.First(citizenItem => citizenItem.Id == id));
            CityContext.SubmitChanges();
            return Ok("Citizen was Deleted");
        }
    }
}
