using System;
using System.Collections.Generic;
using System.Text;

namespace EmailService
{
    public class MessageDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string JsonContent { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
