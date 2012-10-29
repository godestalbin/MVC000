using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc000.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}