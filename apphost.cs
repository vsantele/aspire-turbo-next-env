#:package Aspire.Hosting.JavaScript@13.1.0
#:package CommunityToolkit.Aspire.Hosting.JavaScript.Extensions@13.0.0
#:sdk Aspire.AppHost.Sdk@13.1.0

var builder = DistributedApplication.CreateBuilder(args);

var turbo = builder.AddTurborepoApp("turbo", ".").WithPnpm().WithPackageManagerLaunch("pnpm");

var web = turbo.AddApp("web", "web").WithEnvironment("TEST_ENV", "WebApp").WithExternalHttpEndpoints();

builder.Build().Run();
