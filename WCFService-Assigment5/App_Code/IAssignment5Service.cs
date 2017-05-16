using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAssignment5Service" in both code and config file together.
[ServiceContract]
public interface IAssignment5Service
{
    [OperationContract]
    int PersonLogin(string email, string password);

    [OperationContract]
    bool Register(PersonInfo p);

    [OperationContract]
    bool newGrant(GrantRequest gRequest, GrantReview gReview); 

    [OperationContract]
    List<GrantRequest> GetGrantsRequest(int PersonKey);

}

[DataContract]
public class PersonInfo

{
    [DataMember]
    public string PersonLastName { get; set; }

    [DataMember]
    public string PersonFirstName { get; set; }
    [DataMember]
    public string PersonEmail { get; set; }

    [DataMember]
    public string PersonPassword { get; set; }

    [DataMember]
    public string PersonApartmentNumber { get; set; }

    [DataMember]
    public string PersonStreet { get; set; }

    [DataMember]
    public string PersonCity { get; set; }

    [DataMember]
    public string PersonState { get; set; }

    [DataMember]
    public string PersonZipcode { get; set; }

    [DataMember]
    public string PersonHomePhone { get; set; }

    [DataMember]
    public string PersonWorkPhone { get; set; }

}


