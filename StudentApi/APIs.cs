using StudentApi.Data;
using StudentApi.Models;

namespace StudentApi
{
	public static class APIs
	{
		public static void Register(WebApplication app)
		{
			app.MapGet("/students", (StudentContext context) => context.Students.ToArray());
			app.MapGet("/students/{id}", (StudentContext context, int id) => context.Students.Find(id));
			app.MapPost("/student/create", (StudentContext context, Student newStudent) =>
			{
				context.Students.Add(newStudent);
				context.SaveChanges();
				return Results.NoContent();
			});
		}
	}
}
