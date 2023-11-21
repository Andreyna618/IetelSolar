var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IVagasData, VagasSql>();
builder.Services.AddTransient<IAgendamentoData, AgendamentoSql>();
builder.Services.AddTransient<IOrcamentoData, OrcamentoSql>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default", "/{controller=Informacao}/{action=Index}/{id?}");

app.Run();