//global using Microsoft.EntityFrameworkCore;
global using MudBlazor.Services;
using EcommerceWeb.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
//builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient("EcommerceWeb.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("EcommerceWeb.ServerAPI"));

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
