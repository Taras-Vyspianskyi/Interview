using System.Runtime.Serialization;

namespace InterviewTask.Common.Contract.Person
{
    [DataContract]
    public class PersonApiResponse
    {
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string FaceBookLink { get; set; }

        [DataMember]
        public string TwitterLink { get; set; }
    }
}
