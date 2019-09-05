using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorConference.Models
{
    public class ContactRequest : ContactInformation
    {
        public string ToHtml()
        {
            return $@"<h2>Contact Form</h2>
First Name: {FirstName} <br/>
Last Name : {LastName} <br />
Phone     : {Phone} <br/>
Email     : {Email} <br />
Date Sent : {DateTime.Now.ToString("ddd, MMM dd, yyyy hh:mmtt")}";

        }
    }

}
