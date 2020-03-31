﻿namespace NetCoreWebAPI.Domain.Models
{
    public class SpeakerEvent
    {
        public int SpeakerId { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

        public Speaker Speaker { get; set; }
    }
}
