using StudentApi.Data;

namespace StudentApi
{
	public static class APIs
	{
		public static void Register(WebApplication app)
		{
			app.MapGet("/students", (StudentContext context) => context.Students.ToArray());
			app.MapGet("/students/{id}", (StudentContext context, int id) => context.Students.Find(id));
		}
	}
}
