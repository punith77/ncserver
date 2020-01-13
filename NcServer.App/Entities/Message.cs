using System;
using System.Collections.Generic;
using System.Text;

namespace NcServer.App.Entities
{
    public class Message
    {
        public string Id { get; set; }

        // userId of the user
        public string AddedBy { get; set; }
        public string message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // references
        //public string  GroupId { get; set; }
        public Group Group { get; set; }

    }
}
