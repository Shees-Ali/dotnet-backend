namespace TodoApi.Models;

public class TaskItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? StartDate { get; set; }
    public string? EndData { get; set; }
    public bool IsComplete { get; set; }
}