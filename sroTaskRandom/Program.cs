var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


string[] names = {
    "Mike",
    "Jake",
    "Mark"
};

app.MapGet("/", () => "Sitemap:\n/access");

app.MapGet("/access", () => {
    var random = new Random();
    var name = names[random.Next(names.Length)];
    return new { message = name };
});
app.Run();