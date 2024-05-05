using AritmixWebServer.Models;
using System;
using System.Collections.Generic;

public class PatientService
{
    private static List<Patient> _patients;

    public List<Patient> GetPatients()
    {
        if (_patients == null)
        {
            GeneratePatients();
        }
        return _patients;
    }

    private void GeneratePatients()
    {
        _patients = new List<Patient>();
        Random random = new Random();

        // Create 100 patients
        for (int i = 1; i <= 100; i++)
        {
            DateTime? meetingDate = null;
            if (random.Next(10) < 5)
            {
                meetingDate = null;
            }
            else
            {
                meetingDate = DateTime.Now.AddDays(random.Next(1, 30));
            }

            _patients.Add(new Patient
            {
                Id = i,
                FullName = $"Patient{i}",
                MeetingDate = (DateTime)meetingDate,
                MeetingType = meetingDate.HasValue ? "Follow-up" : null
            });
        }


    }
}
