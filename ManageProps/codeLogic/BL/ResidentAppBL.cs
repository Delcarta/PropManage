using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResidentApp
/// </summary>
public class ResidentAppBL
{
    private ApplicationResidentApplication app;
    private List<ApplicationApplicant> applicants;
    private List<ApplicationPets> pets;
    private List<ApplicationOccupants> others;

    public ResidentAppBL()
    {
        app = new ApplicationResidentApplication();
        applicants = new List<ApplicationApplicant>();
        pets = new List<ApplicationPets>();
        others = new List<ApplicationOccupants>();

    }

    public void AddApplicant(ApplicationApplicant Applicant)
    {
        applicants.Add(Applicant);
    }

    public void AddPet(ApplicationPets Pet)
    {
        pets.Add(Pet);
    }

    public void AddPets(List<ApplicationPets> Pets)
    {
        foreach (ApplicationPets critter in Pets)
        {
            AddPet(critter);
        }
    }

    public void AddOccupant(ApplicationOccupants other)
    {

        others.Add(other);

    }

    public void AddOccupants(List<ApplicationOccupants> others)
    {
        foreach (ApplicationOccupants other in others)
        {
            AddOccupant(other);
        }
    }

    public void ProcessApp()
    {
        app.Applicants = applicants.Count;
        app.Occupants = others.Count;
        app.Pets = pets.Count;
        app.Vehicles = 0;

        ApplyDAL appProcess = new ApplyDAL();
        appProcess.StoreApplicationData(app,applicants, pets, others);
    }
}