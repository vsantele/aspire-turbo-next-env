#:package Aspire.Hosting.JavaScript@13.2.0-preview.1.25621.2
#:package CommunityToolkit.Aspire.Hosting.JavaScript.Extensions@13.0.1-beta.468
#:sdk Aspire.AppHost.Sdk@13.2.0-preview.1.25621.2

var builder = DistributedApplication.CreateBuilder(args);

var turbo = builder.AddTurborepoApp("turbo", ".").WithPnpm().WithPackageManagerLaunch("pnpm");

var web = turbo.AddApp("web", "web").WithEnvironment("TEST_ENV", "WebApp").WithExternalHttpEndpoints();

builder.Build().Run();
