var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Designer_ApiService>("apiservice");

builder.AddProject<Projects.Designer_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
