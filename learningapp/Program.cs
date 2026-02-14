var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Configuration.AddAzureAppConfiguration("Endpoint=https://sumathiconfig.azconfig.io;Id=RaXD;Secret=EQuiVxyBVuU23XyExDHq9D4hVYnzYmQA4UjolAIvKIXSr9rhVLkFJQQJ99CBACBsN54H6o97AAACAZAC0DB7");
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
