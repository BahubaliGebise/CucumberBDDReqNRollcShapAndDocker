# Use the .NET SDK image for building and running tests
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the entire repository into the container
COPY . ./

# Restore dependencies
RUN dotnet restore "TestAutomationReqnrollCSharpProject.sln"

# Build the solution in Release configuration
RUN dotnet build "TestAutomationReqnrollCSharpProject.sln" -c Release

# Final image for running tests
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS testruntime
WORKDIR /src

# Copy the source and build output
COPY --from=build /src ./

# Run tests when the container starts
ENTRYPOINT ["dotnet", "test", "TestAutomationReqnrollCSharpProject.sln", "--logger:console"]
