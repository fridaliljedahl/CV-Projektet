namespace MessageWebAPI.Models
{
	public class AddProjectMembersViewModel
	{
		public Project Project { get; set; }
		public string? UserName { get; set; }
		public int? Id { get; set; }
		public string? ErrorMessage { get; set; }

	}
}
