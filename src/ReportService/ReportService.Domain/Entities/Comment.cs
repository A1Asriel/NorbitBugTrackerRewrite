namespace ReportService.Domain.Entities;
public record struct Comment(long Id, long authorId, string content);
