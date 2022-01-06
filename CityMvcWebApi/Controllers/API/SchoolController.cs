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
    public class SchoolController : ApiController
    {
        static string connectionString = "Data Source=DESKTOP-IGIOI52;Initial Catalog=CityDB;Integrated Security=True;Pooling=False";
        SchoolContextDataContext SchoolContext = new SchoolContextDataContext(connectionString);
        // GET: api/School
        public IHttpActionResult Get()
        {

            return Ok(SchoolContext.Schools.ToList());
        }

        // GET: api/School/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(SchoolContext.Schools.First(schoolItem => schoolItem.Id == id));

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return Ok(err.Message);
            }
        }

        // POST: api/School
        public IHttpActionResult Post([FromBody] School schoolItem)
        {
            try
            {
                SchoolContext.Schools.InsertOnSubmit(schoolItem);
                SchoolContext.SubmitChanges();
                return Ok("Saved");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // PUT: api/School/5
        public IHttpActionResult Put(int id, [FromBody] School School)
        {
            try
            {
                School Myschool = SchoolContext.Schools.First(schoolItem => schoolItem.Id == id);
                if (Myschool == null)
                {
                    Myschool.SchoolName = School.SchoolName;
                    Myschool.Street = School.Street;
                    Myschool.isPublic = School.isPublic;
                    Myschool.QuantityOfStudents = School.QuantityOfStudents;
                }
                SchoolContext.SubmitChanges();
                return Ok("UPDATE DONE");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }

        }

        // DELETE: api/School/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                SchoolContext.Schools.DeleteOnSubmit(SchoolContext.Schools.First(schoolItem => schoolItem.Id == id));
                SchoolContext.SubmitChanges();
                return Ok("item Deleted");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
