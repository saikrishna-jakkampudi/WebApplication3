using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Population
    {
        int applicationId, memberId;
        string firstName, middleName, lastName, suffix, gender;
        DateTime dateOfBirth;

        public int ApplicationId { get => applicationId; set => applicationId = value; }
        public int MemberId { get => memberId; set => memberId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}