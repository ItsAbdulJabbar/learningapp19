var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Configuration.AddAzureAppConfiguration("Endpoint=https://app-configurations-19.azconfig.io;Id=Q89k;Secret=E70y0z6RMKoajAH8y9U6KAGdcE7QGR45HiN2zr7lWyIXmmyCvD25JQQJ99BDAC5RqLJazOPaAAACAZAC2oeV");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
