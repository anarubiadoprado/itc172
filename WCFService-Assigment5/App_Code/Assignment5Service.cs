using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Assignment5Service" in code, svc and config file together.
public class Assignment5Service : IAssignment5Service
{

    Community_AssistEntities db = new Community_AssistEntities();
    public int PersonLogin(string email, string password)
    {
        int key = 0;
        int result = db.usp_Login(email, password);
        if (result != -1)
        {
            var personKey = (from k in db.People
                             where k.PersonEmail.Equals(email)
                             select k.PersonKey).FirstOrDefault();

            key = (int)personKey;
        }

        return key;
    }

    public bool Register(PersonInfo p)
    {
        bool result = true;
        int rev = db.usp_Register(p.PersonLastName, p.PersonFirstName, p.PersonEmail, 
            p.PersonPassword, p.PersonApartmentNumber, p.PersonStreet,
            p.PersonCity, p.PersonState, p.PersonZipcode, p.PersonHomePhone, p.PersonWorkPhone);
        
       
        
        return result;
     }

    public List<GrantRequest> GetGrantsRequest(int PersonKey)
    {
        var grqs = from gr in db.GrantRequests
                      select gr;

        List <GrantRequest> gRequest = new List<GrantRequest>();

        foreach (GrantRequest grq in grqs)
        {
            GrantRequest gRequest1 = new GrantRequest();
            gRequest1.GrantRequestDate = grq.GrantRequestDate;
            gRequest1.PersonKey = grq.PersonKey;
            gRequest1.GrantTypeKey = grq.GrantTypeKey;
            gRequest1.GrantRequestExplanation = grq.GrantRequestExplanation;
            gRequest1.GrantRequestAmount = grq.GrantRequestAmount;
            
        }

        return gRequest;
    }


    public bool newGrant(GrantRequest gRequest, GrantReview gReview)
    {
        bool result = true;

        try
        {
            db.GrantRequests.Add(gRequest);
            db.GrantReviews.Add(gReview);
            db.SaveChanges();

        }

        catch
        {
            result = false;
        }

        return result;
    }

    
}



