using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFiles.Models
{
    public class Payload
    {

        public string employerId { get; set; }
        public string payerId { get; set; }
        public string planId { get; set; }
        public string planName { get; set; }
        public object networkId { get; set; }
        public object networkName { get; set; }
        public string memberId { get; set; }
        public string requestId { get; set; }
        public string alphaPrefix { get; set; }
        public string healthCardId { get; set; }
        public object ssn { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middle { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string relationshipCode { get; set; }
        public string subscriberEmployeeId { get; set; }
        public bool includeFamilyRequest { get; set; }
        public string subscriberHealthCardId { get; set; }
        public object subscriberSsn { get; set; }
        public string subscriberLastName { get; set; }
        public string subscriberFirstName { get; set; }
        public string subscriberMiddle { get; set; }
        public string subscriberDateOfBirth { get; set; }
        public string subscriberGender { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public object addressLine3 { get; set; }
        public string addressCity { get; set; }
        public string addressState { get; set; }
        public string addressZip { get; set; }
        public object addressLat { get; set; }
        public object addressLon { get; set; }
        public string employerName { get; set; }
        public string payerName { get; set; }
        public object haId { get; set; }
        public Dependent[] dependents { get; set; }

        public class Dependent
        {
            public string employerId { get; set; }
            public string payerId { get; set; }
            public string planId { get; set; }
            public string planName { get; set; }
            public object networkId { get; set; }
            public object networkName { get; set; }
            public string memberId { get; set; }
            public string requestId { get; set; }
            public object alphaPrefix { get; set; }
            public string healthCardId { get; set; }
            public object ssn { get; set; }
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string middle { get; set; }
            public string dateOfBirth { get; set; }
            public string gender { get; set; }
            public string relationshipCode { get; set; }
            public string subscriberEmployeeId { get; set; }
            public bool includeFamilyRequest { get; set; }
            public string subscriberHealthCardId { get; set; }
            public object subscriberSsn { get; set; }
            public string subscriberLastName { get; set; }
            public string subscriberFirstName { get; set; }
            public string subscriberMiddle { get; set; }
            public string subscriberDateOfBirth { get; set; }
            public string subscriberGender { get; set; }
            public string addressLine1 { get; set; }
            public string addressLine2 { get; set; }
            public object addressLine3 { get; set; }
            public string addressCity { get; set; }
            public string addressState { get; set; }
            public string addressZip { get; set; }
            public object addressLat { get; set; }
            public object addressLon { get; set; }
            public string employerName { get; set; }
            public string payerName { get; set; }
            public object haId { get; set; }
        }

    }
}
