using System;
using System.Collections.Generic;
using System.Text;

namespace NcServer.App.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // relationships
        public IList<UserGroup> UserGroups { get; set; }


    }
}
