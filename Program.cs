using cloud_ai_challenge.Components;

var builder = WebApplication.CreateBuilder(args);

// Enable detailed errors for development
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents()
        .AddCircuitOptions(options => options.DetailedErrors = true);
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
