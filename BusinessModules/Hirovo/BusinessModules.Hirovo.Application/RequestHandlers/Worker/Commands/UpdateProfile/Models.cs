namespace BusinessModules.Worker.Application.RequestHandlers.Workers.Commands.UpdateProfile;

public class RequestModel : IRequestModel
{
	public Guid UserId { get; set; }
	public string? PhoneNumber { get; set; }
	public DateTime? BirthDate { get; set; }
	public string? City { get; set; }
	public string? District { get; set; }
	public bool? IsAvailable { get; set; }
}

public class ResponseModel : IResponseModel
{
	public Guid Id { get; set; }
}
