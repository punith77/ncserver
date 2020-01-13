using System;
using System.Collections.Generic;
using System.Text;

namespace NcServer.App.Entities
{
    public class Group
    {
        public string Id { get; set; }
        public string GroupName { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IList<UserGroup> UserGroups { get; set; }
    }
}
