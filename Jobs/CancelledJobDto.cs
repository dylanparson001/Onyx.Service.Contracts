using Onyx.Shared.Enums;

namespace Onyx.Shared.Contracts.Jobs
{
    public class CancelledJobDto : JobDto
    {
        public DateTime RemovedAt { get; set; }
        public CancellationReason RemovedReason { get; set; }
    }
}
