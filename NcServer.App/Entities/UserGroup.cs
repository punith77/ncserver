using System;
using System.Collections.Generic;
using System.Text;

namespace NcServer.App.Entities
{
    public class UserGroup
    {
        public string UserId { get; set; }
        public string GroupId { get; set; }

        public User User { get; set; }
        public Group Group { get; set; }

    }
}
