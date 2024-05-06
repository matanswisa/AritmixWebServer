using AritmixWebServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AritmixWebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private static List<Patient> _patients = new List<Patient>
        {
            // Patients with meeting records
            new Patient
            {
                Id = 1,
                FullName = "John Smith",
                Appointments = new List<Appointment>
                {
                    new Appointment
                    {
                        Id = 1,
                        AppointmentgDate = DateTime.Now.AddDays(1),
                        AppointmentType = new AppointmentType { name = "Initial Consultation" }
                    }
                }
            },
            new Patient
            {
                Id = 2,
                FullName = "Emma Johnson",
                Appointments = new List<Appointment>
                {
                    new Appointment
                    {
                        Id = 2,
                        AppointmentgDate = DateTime.Now.AddDays(2),
                        AppointmentType = new AppointmentType { name = "Follow-up Appointment" }
                    }
                }
            },
            new Patient
            {
                Id = 3,
                FullName = "Michael Brown",
                Appointments = new List<Appointment>
                {
                    new Appointment
                    {
                        Id = 3,
                        AppointmentgDate = DateTime.Now.AddDays(3),
                        AppointmentType = new AppointmentType { name = "Diagnostic Testing" }
                    }
                }
            },
            new Patient
            {
                Id = 4,
                FullName = "Micheal Ross",
                Appointments = new List<Appointment>()
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_patients);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var patient = _patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [HttpGet("paged")]
        public IActionResult GetPaged(int skip = 0, int take = 10)
        {
            try
            {
                if (skip < 0)
                {
                    return BadRequest("Invalid skip parameter");
                }

                var remainingLength = _patients.Count - skip;
                if (remainingLength <= 0)
                {
                    return Ok(new List<Patient>());
                }

                var actualTake = Math.Min(remainingLength, take);

                var patients = _patients.Skip(skip).Take(actualTake).ToList();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
