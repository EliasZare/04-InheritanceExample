using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhetitance
{
    public class Admin : User
    {
        public string Role { get; set; }
        public string Organization { get; set; }
        public Admin(string role, string organization, string name, string biography):base(name, biography)
        {
            Role= role;
            Organization= organization;
        }

        //Method Hiding
        public new string GetFullBio()
        {
            return $"I'm {this.Name} and {this.Biography} and I work in {CompanyName} in this company my role is {this.Role} in {this.Organization} organization";
        }
        //Method overriding
        public override string GetName()
        {
            return base.GetName()+" This is Method Overrided text";

        }
    }
}
