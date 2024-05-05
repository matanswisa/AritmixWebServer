using AritmixWebServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


[ApiController]
[Route("api/[controller]")]

public class PatientsController : ControllerBase
{

    private static List<Patient> _patients = new List<Patient>
    {
        // Patients with meeting records
        new Patient { Id = 1, FullName = "John Smith", MeetingDate = DateTime.Now.AddDays(1), MeetingType = "Initial Consultation" },
        new Patient { Id = 2, FullName = "Emma Johnson", MeetingDate = DateTime.Now.AddDays(2), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 3, FullName = "Michael Brown", MeetingDate = DateTime.Now.AddDays(3), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 4, FullName = "Sophia Davis", MeetingDate = DateTime.Now.AddDays(4), MeetingType = "Treatment Planning" },
        new Patient { Id = 5, FullName = "Matthew Wilson", MeetingDate = DateTime.Now.AddDays(5), MeetingType = "Initial Consultation" },
        new Patient { Id = 6, FullName = "Emily Martinez", MeetingDate = DateTime.Now.AddDays(6), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 7, FullName = "Ethan Thomas", MeetingDate = DateTime.Now.AddDays(7), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 8, FullName = "Olivia Garcia", MeetingDate = DateTime.Now.AddDays(8), MeetingType = "Treatment Planning" },
        new Patient { Id = 9, FullName = "William Taylor", MeetingDate = DateTime.Now.AddDays(9), MeetingType = "Initial Consultation" },
        new Patient { Id = 10, FullName = "Amelia Anderson", MeetingDate = DateTime.Now.AddDays(10), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 11, FullName = "James Hernandez", MeetingDate = DateTime.Now.AddDays(11), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 12, FullName = "Isabella Lopez", MeetingDate = DateTime.Now.AddDays(12), MeetingType = "Treatment Planning" },
        new Patient { Id = 13, FullName = "Daniel Gonzalez", MeetingDate = DateTime.Now.AddDays(13), MeetingType = "Initial Consultation" },
        new Patient { Id = 14, FullName = "Ava Wilson", MeetingDate = DateTime.Now.AddDays(14), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 15, FullName = "Alexander Clark", MeetingDate = DateTime.Now.AddDays(15), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 16, FullName = "Mia Moore", MeetingDate = DateTime.Now.AddDays(16), MeetingType = "Treatment Planning" },
        new Patient { Id = 17, FullName = "Noah King", MeetingDate = DateTime.Now.AddDays(17), MeetingType = "Initial Consultation" },
        new Patient { Id = 18, FullName = "Chloe Hill", MeetingDate = DateTime.Now.AddDays(18), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 19, FullName = "Elijah Rivera", MeetingDate = DateTime.Now.AddDays(19), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 20, FullName = "Grace Carter", MeetingDate = DateTime.Now.AddDays(20), MeetingType = "Treatment Planning" },
        // Patients without meeting records
        new Patient { Id = 21, FullName = "Liam Baker", MeetingDate = null, MeetingType = null },
        new Patient { Id = 22, FullName = "Mia Adams", MeetingDate = null, MeetingType = null },
        new Patient { Id = 23, FullName = "Oliver Mitchell", MeetingDate = null, MeetingType = null },
        new Patient { Id = 24, FullName = "Sophia Perez", MeetingDate = null, MeetingType = null },
        new Patient { Id = 25, FullName = "Lucas Turner", MeetingDate = null, MeetingType = null },
        new Patient { Id = 26, FullName = "Harper Cooper", MeetingDate = null, MeetingType = null },
        new Patient { Id = 27, FullName = "Benjamin Bell", MeetingDate = null, MeetingType = null },
        new Patient { Id = 28, FullName = "Emma Diaz", MeetingDate = null, MeetingType = null },
        new Patient { Id = 29, FullName = "Mason Murphy", MeetingDate = null, MeetingType = null },
        new Patient { Id = 30, FullName = "Evelyn Richardson", MeetingDate = null, MeetingType = null },
        // Additional patients with meeting records
        new Patient { Id = 31, FullName = "Ethan Hill", MeetingDate = DateTime.Now.AddDays(21), MeetingType = "Initial Consultation" },
        new Patient { Id = 32, FullName = "Madison Reed", MeetingDate = DateTime.Now.AddDays(22), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 33, FullName = "Jacob Scott", MeetingDate = DateTime.Now.AddDays(23), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 34, FullName = "Ella Price", MeetingDate = DateTime.Now.AddDays(24), MeetingType = "Treatment Planning" },
        new Patient { Id = 35, FullName = "Avery Ward", MeetingDate = DateTime.Now.AddDays(25), MeetingType = "Initial Consultation" },
        new Patient { Id = 36, FullName = "Sofia Butler", MeetingDate = DateTime.Now.AddDays(26), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 37, FullName = "David Gomez", MeetingDate = DateTime.Now.AddDays(27), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 38, FullName = "Aria Evans", MeetingDate = DateTime.Now.AddDays(28), MeetingType = "Treatment Planning" },
        new Patient { Id = 39, FullName = "Jack Cooper", MeetingDate = DateTime.Now.AddDays(29), MeetingType = "Initial Consultation" },
        new Patient { Id = 40, FullName = "Nora Hughes", MeetingDate = DateTime.Now.AddDays(30), MeetingType = "Follow-up Appointment" },
        // Patients without meeting records
        new Patient { Id = 41, FullName = "Lucas Perez", MeetingDate = null, MeetingType = null },
        new Patient { Id = 42, FullName = "Ella Long", MeetingDate = null, MeetingType = null },
        new Patient { Id = 43, FullName = "Henry Cox", MeetingDate = null, MeetingType = null },
        new Patient { Id = 44, FullName = "Charlotte Reed", MeetingDate = null, MeetingType = null },
        new Patient { Id = 45, FullName = "Amelia Hughes", MeetingDate = null, MeetingType = null },
        new Patient { Id = 46, FullName = "Elijah Mitchell", MeetingDate = null, MeetingType = null },
        new Patient { Id = 47, FullName = "Scarlett Kelly", MeetingDate = null, MeetingType = null },
        new Patient { Id = 48, FullName = "Gabriel Bennett", MeetingDate = null, MeetingType = null },
        new Patient { Id = 49, FullName = "Grace Gray", MeetingDate = null, MeetingType = null },
        new Patient { Id = 50, FullName = "Jackson Rivera", MeetingDate = null, MeetingType = null },
        // Additional patients with meeting records
        new Patient { Id = 51, FullName = "Natalie Evans", MeetingDate = DateTime.Now.AddDays(31), MeetingType = "Initial Consultation" },
        new Patient { Id = 52, FullName = "Lucas Mitchell", MeetingDate = DateTime.Now.AddDays(32), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 53, FullName = "Eliana Nelson", MeetingDate = DateTime.Now.AddDays(33), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 54, FullName = "Mason Bell", MeetingDate = DateTime.Now.AddDays(34), MeetingType = "Treatment Planning" },
        new Patient { Id = 55, FullName = "Aria Hayes", MeetingDate = DateTime.Now.AddDays(35), MeetingType = "Initial Consultation" },
        new Patient { Id = 56, FullName = "Emma Peterson", MeetingDate = DateTime.Now.AddDays(36), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 57, FullName = "David Ward", MeetingDate = DateTime.Now.AddDays(37), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 58, FullName = "Sophia Cox", MeetingDate = DateTime.Now.AddDays(38), MeetingType = "Treatment Planning" },
        new Patient { Id = 59, FullName = "Liam Evans", MeetingDate = DateTime.Now.AddDays(39), MeetingType = "Initial Consultation" },
        new Patient { Id = 60, FullName = "Harper Mitchell", MeetingDate = DateTime.Now.AddDays(40), MeetingType = "Follow-up Appointment" },
        // Patients without meeting records
        new Patient { Id = 61, FullName = "Jacob Carter", MeetingDate = null, MeetingType = null },
        new Patient { Id = 62, FullName = "Aurora Watson", MeetingDate = null, MeetingType = null },
        new Patient { Id = 63, FullName = "Eva Coleman", MeetingDate = null, MeetingType = null },
        new Patient { Id = 64, FullName = "Nathan Jenkins", MeetingDate = null, MeetingType = null },
        new Patient { Id = 65, FullName = "Aiden Turner", MeetingDate = null, MeetingType = null },
        new Patient { Id = 66, FullName = "Zoe Long", MeetingDate = null, MeetingType = null },
        new Patient { Id = 67, FullName = "Luna Cox", MeetingDate = null, MeetingType = null },
        new Patient { Id = 68, FullName = "Logan Young", MeetingDate = null, MeetingType = null },
        new Patient { Id = 69, FullName = "Charlotte Garcia", MeetingDate = null, MeetingType = null },
        new Patient { Id = 70, FullName = "Ryan Martin", MeetingDate = null, MeetingType = null },
        // Additional patients with meeting records
        new Patient { Id = 71, FullName = "Aria Martinez", MeetingDate = DateTime.Now.AddDays(41), MeetingType = "Initial Consultation" },
        new Patient { Id = 72, FullName = "Oliver Adams", MeetingDate = DateTime.Now.AddDays(42), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 73, FullName = "Leah Butler", MeetingDate = DateTime.Now.AddDays(43), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 74, FullName = "Gabriel Hernandez", MeetingDate = DateTime.Now.AddDays(44), MeetingType = "Treatment Planning" },
        new Patient { Id = 75, FullName = "Zoe Rivera", MeetingDate = DateTime.Now.AddDays(45), MeetingType = "Initial Consultation" },
        new Patient { Id = 76, FullName = "Aiden Turner", MeetingDate = DateTime.Now.AddDays(46), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 77, FullName = "Emma Perez", MeetingDate = DateTime.Now.AddDays(47), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 78, FullName = "Lucas Hughes", MeetingDate = DateTime.Now.AddDays(48), MeetingType = "Treatment Planning" },
        new Patient { Id = 79, FullName = "Avery Richardson", MeetingDate = DateTime.Now.AddDays(49), MeetingType = "Initial Consultation" },
        new Patient { Id = 80, FullName = "Sophia Clark", MeetingDate = DateTime.Now.AddDays(50), MeetingType = "Follow-up Appointment" },
        // Patients without meeting records
        new Patient { Id = 81, FullName = "Henry Lopez", MeetingDate = null, MeetingType = null },
        new Patient { Id = 82, FullName = "Mia Parker", MeetingDate = null, MeetingType = null },
        new Patient { Id = 83, FullName = "David Smith", MeetingDate = null, MeetingType = null },
        new Patient { Id = 84, FullName = "Emily Turner", MeetingDate = null, MeetingType = null },
        new Patient { Id = 85, FullName = "Elijah Wilson", MeetingDate = null, MeetingType = null },
        new Patient { Id = 86, FullName = "Chloe Garcia", MeetingDate = null, MeetingType = null },
        new Patient { Id = 87, FullName = "Alexander Reed", MeetingDate = null, MeetingType = null },
        new Patient { Id = 88, FullName = "Aria Murphy", MeetingDate = null, MeetingType = null },
        new Patient { Id = 89, FullName = "Charlotte Baker", MeetingDate = null, MeetingType = null },
        new Patient { Id = 90, FullName = "Lucas Davis", MeetingDate = null, MeetingType = null },
        // Additional patients with meeting records
        new Patient { Id = 91, FullName = "Mason Adams", MeetingDate = DateTime.Now.AddDays(51), MeetingType = "Initial Consultation" },
        new Patient { Id = 92, FullName = "Sophia Perez", MeetingDate = DateTime.Now.AddDays(52), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 93, FullName = "Ella Mitchell", MeetingDate = DateTime.Now.AddDays(53), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 94, FullName = "Jackson Rivera", MeetingDate = DateTime.Now.AddDays(54), MeetingType = "Treatment Planning" },
        new Patient { Id = 95, FullName = "Emma Hernandez", MeetingDate = DateTime.Now.AddDays(55), MeetingType = "Initial Consultation" },
        new Patient { Id = 96, FullName = "David Lopez", MeetingDate = DateTime.Now.AddDays(56), MeetingType = "Follow-up Appointment" },
        new Patient { Id = 97, FullName = "Ava Butler", MeetingDate = DateTime.Now.AddDays(57), MeetingType = "Diagnostic Testing" },
        new Patient { Id = 98, FullName = "Lucas Hughes", MeetingDate = DateTime.Now.AddDays(58), MeetingType = "Treatment Planning" },
        new Patient { Id = 99, FullName = "Elijah Richardson", MeetingDate = DateTime.Now.AddDays(59), MeetingType = "Initial Consultation" },
        new Patient { Id = 100, FullName = "Avery Clark", MeetingDate = DateTime.Now.AddDays(60), MeetingType = "Follow-up Appointment" },
    };


    [HttpGet]
    public IActionResult GetPatients()
    {
        return Ok(_patients);
    }

    [HttpGet("{id}")]
    public IActionResult GetPatient(int id)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }

    [HttpGet("Paged")] // Modified route attribute for better clarity
    [ProducesResponseType(typeof(IEnumerable<Patient>), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public ActionResult<IEnumerable<Patient>> GetPagedPatients(int skip = 0, int take = 10)
    {
        try
        {
            // Validate skip parameter
            if (skip < 0)
            {
                return BadRequest("Invalid skip parameter");
            }

            // Calculate the number of records to take based on the remaining length of the list
            var remainingLength = _patients.Count - skip;
            if (remainingLength <= 0)
            {
                return Ok(new List<Patient>()); // Return an empty list if there are no more records to retrieve
            }

            // Take the minimum of remaining length and the specified take parameter
            var actualTake = Math.Min(remainingLength, take);

            // Retrieve the specified number of patients skipping the specified number of records
            var patients = _patients.Skip(skip).Take(actualTake).ToList();
            return Ok(patients);
        }
        catch (Exception ex)
        {
            // Handle exception
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }



    [HttpPost]
    public IActionResult AddPatient([FromBody] Patient patient)
    {
        patient.Id = _patients.Count + 1;
        _patients.Add(patient);
        return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePatient(int id, [FromBody] Patient updatedPatient)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == id);
        if (patient == null)
        {
            return NotFound();
        }
        patient.FullName = updatedPatient.FullName;
        patient.MeetingDate = updatedPatient.MeetingDate;
        patient.MeetingType = updatedPatient.MeetingType;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePatient(int id)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == id);
        if (patient == null)
        {
            return NotFound();
        }
        _patients.Remove(patient);
        return NoContent();
    }
}
