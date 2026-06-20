using Onyx.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onyx.Shared.Contracts.Jobs
{
    public class JobDto
    {
        public long Id { get; set; }
        public Guid JobGuid { get; set; }
        public long TechnicianId { get; set; }
        public long CustomerId { get; set; }
        public DateTime ScheduledStartTime { get; set; }
        public DateTime ScheduledEndTime { get; set; }
        public string JobDescription { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime ServiceDate { get; set; }
        public Job ToJob()
        {
            return new Job()
            {
                JobGuid = JobGuid,
                TechnicianId = TechnicianId,
                CustomerId = CustomerId,
                ScheduledStartTime = ScheduledStartTime,
                ScheduledEndTime = ScheduledEndTime,
                IsCompleted = false,
                JobDescription = JobDescription,
                Status = string.IsNullOrEmpty(Status) ? Enum.Parse<JobStatus>(Status) : JobStatus.Scheduled,
                ServiceDate = ServiceDate
            };
        }
    }
}
