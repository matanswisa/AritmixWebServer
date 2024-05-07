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

        public static string GenerateRandomId()
        {
            // Define the length of the ID
            int length = 8;

            // Characters allowed in the ID
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Random number generator
            Random random = new Random();

            // Generate a random ID
            char[] id = new char[length];
            for (int i = 0; i < length; i++)
            {
                id[i] = chars[random.Next(chars.Length)];
            }

            return new string(id);
        }

        private static List<Patient> _patients = new List<Patient>
        {
   new Patient
    {
        Id = 1,
        FullName = "John Smith",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(4),
                AppointmentType = new AppointmentType { name = "Initial Consultation" }
            },
                 new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(1),
                AppointmentType = new AppointmentType { name = "Follow Up" }
            },
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(14),
                AppointmentType = new AppointmentType { name = "US" }
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
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(2),
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
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(3),
                AppointmentType = new AppointmentType { name = "Diagnostic Testing" }
            },
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(1),
                AppointmentType = new AppointmentType { name = "Follow-up Appointment" }
            }
        }
    },
    new Patient
    {
        Id = 4,
        FullName = "David Wilson",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(4),
                AppointmentType = new AppointmentType { name = "Regular Checkup" }
            },
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(10),
                AppointmentType = new AppointmentType { name = "CT" }
            }
        }
    },
    new Patient
    {
        Id = 5,
        FullName = "Sophia Martinez",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 6,
        FullName = "James Johnson",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(5),
                AppointmentType = new AppointmentType { name = "Dental Cleaning" }
            }
        }
    },
    new Patient
    {
        Id = 7,
        FullName = "Isabella Taylor",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(6),
                AppointmentType = new AppointmentType { name = "Eye Checkup" }
            }
        }
    },
    new Patient
    {
        Id = 8,
        FullName = "William Brown",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 9,
        FullName = "Olivia Moore",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(7),
                AppointmentType = new AppointmentType { name = "Physical Therapy" }
            }
        }
    },
    new Patient
    {
        Id = 10,
        FullName = "Lucas Davis",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 11,
        FullName = "Benjamin Lee",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(8),
                AppointmentType = new AppointmentType { name = "Ultrasound" }
            }
        }
    },
    new Patient
    {
        Id = 12,
        FullName = "Ava Wilson",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 13,
        FullName = "Ethan Thompson",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(9),
                AppointmentType = new AppointmentType { name = "X-ray" }
            }
        }
    },
    new Patient
    {
        Id = 14,
        FullName = "Emily Anderson",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 15,
        FullName = "Alexander Garcia",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(10),
                AppointmentType = new AppointmentType { name = "Blood Test" }
            }
        }
    },
    new Patient
    {
        Id = 16,
        FullName = "Madison Thomas",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 17,
        FullName = "Jackson Hernandez",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(11),
                AppointmentType = new AppointmentType { name = "MRI Scan" }
            }
        }
    },
    new Patient
    {
        Id = 18,
        FullName = "Chloe Clark",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 19,
        FullName = "Carter Lewis",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(12),
                AppointmentType = new AppointmentType { name = "EKG" }
            }
        }
    },
    new Patient
    {
        Id = 20,
        FullName = "Penelope Perez",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 21,
        FullName = "Mason Rodriguez",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(13),
                AppointmentType = new AppointmentType { name = "CT Scan" }
            }
        }
    },
    new Patient
    {
        Id = 22,
        FullName = "Grace Young",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 23,
        FullName = "Luke Walker",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(14),
                AppointmentType = new AppointmentType { name = "Physical Exam" }
            }
        }
    },
    new Patient
    {
        Id = 24,
        FullName = "Avery King",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 25,
        FullName = "Evelyn Hill",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(15),
                AppointmentType = new AppointmentType { name = "Allergy Testing" }
            }
        }
    },
    new Patient
    {
        Id = 26,
        FullName = "Daniel Young",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 27,
        FullName = "Hannah Scott",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(16),
                AppointmentType = new AppointmentType { name = "Dermatology Consultation" }
            }
        }
    },
    new Patient
    {
        Id = 28,
        FullName = "Caleb Green",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 29,
        FullName = "Addison Adams",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(17),
                AppointmentType = new AppointmentType { name = "Endoscopy" }
            }
        }
    },
    new Patient
    {
        Id = 30,
        FullName = "Matthew Baker",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 31,
        FullName = "Lily Nelson",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(18),
                AppointmentType = new AppointmentType { name = "Podiatry Evaluation" }
            }
        }
    },
    new Patient
    {
        Id = 32,
        FullName = "Wyatt Carter",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 33,
        FullName = "Victoria Rivera",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(19),
                AppointmentType = new AppointmentType { name = "Psychiatry Consultation" }
            }
        }
    },
    new Patient
    {
        Id = 34,
        FullName = "Jack Mitchell",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 35,
        FullName = "Mia Price",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(20),
                AppointmentType = new AppointmentType { name = "Neurology Evaluation" }
            },
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddHours(1),
                AppointmentType = new AppointmentType { name = "Neurology Evaluation" }
            }
        }
    },
    new Patient
    {
        Id = 36,
        FullName = "Julian Cooper",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 37,
        FullName = "Nora Barnes",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(21),
                AppointmentType = new AppointmentType { name = "Nutrition Counseling" }
            }
        }
    },
    new Patient
    {
        Id = 38,
        FullName = "Andrew Coleman",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 39,
        FullName = "Scarlett Long",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(22),
                AppointmentType = new AppointmentType { name = "Orthopedic Consultation" }
            }
        }
    },
    new Patient
    {
        Id = 40,
        FullName = "Joseph Reed",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 41,
        FullName = "Leah Cox",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(23),
                AppointmentType = new AppointmentType { name = "Pulmonary Function Test" }
            }
        }
    },
    new Patient
    {
        Id = 42,
        FullName = "Owen Powell",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 43,
        FullName = "Audrey Hughes",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(24),
                AppointmentType = new AppointmentType { name = "Rheumatology Consultation" }
            }
        }
    },
    new Patient
    {
        Id = 44,
        FullName = "Henry Foster",
        Appointments = new List<Appointment>()
    },
    new Patient
    {
        Id = 45,
        FullName = "Savannah Simmons",
        Appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = GenerateRandomId(),
                AppointmentDate = DateTime.Now.AddDays(25),
                AppointmentType = new AppointmentType { name = "Sleep Study" }
            }
        }
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
