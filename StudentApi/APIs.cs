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

			app.MapDelete("/student/delete/{id}", (StudentContext context, int id) =>
			{
				var student = context.Students.Find(id);
				if (student == null) return Results.NotFound();
				context.Students.Remove(student);
				context.SaveChanges();
				return Results.NoContent();
			});

			app.MapPost("/courses/create", (StudentContext context, Course course) =>
			{
				context.Courses.Add(course);
				context.SaveChanges();
				return Results.NoContent();
			});

			app.MapGet("/courses", (StudentContext context) => context.Courses.ToArray());
		}
	}
}
