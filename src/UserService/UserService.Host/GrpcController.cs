using Grpc.Core;
using UserService.Domain;
using UserService.Infrastructure.Managers;
using UserService.Host.Protos;

namespace UserService.Host;

public class GrpcController : ReportAdder.ReportAdderBase
{
    public override Task<AddReportReply> AddReport(AddReportRequest request, ServerCallContext context)
    {
        // UserManager.GetById(request.UserId);
        return Task.FromResult(new AddReportReply
        {
            User = ""
        });
    }
}
