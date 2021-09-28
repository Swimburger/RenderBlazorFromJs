using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RenderBlazorFromJs;
using RenderBlazorFromJs.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.RegisterForJavaScript<App>(identifier: "app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
await builder.Build().RunAsync();
