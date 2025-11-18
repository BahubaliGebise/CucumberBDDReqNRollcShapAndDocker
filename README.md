# CucumberBDDReqNRollcShapAndDocker

docker file:
# -------------------------
# 1. Build Stage
# -------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy full repo first (avoid broken paths)
COPY . ./

# Restore solution
RUN dotnet restore ReqnrollProjectCucumberBDD.sln

# Build the project
RUN dotnet build ReqnrollProjectCucumberBDD.sln -c Release --no-restore

# -------------------------
# 2. Test Stage
# -------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS testrunner

WORKDIR /app

# Copy everything from the build stage
COPY --from=build /src ./

# Create reports directory
RUN mkdir -p /app/reports

# Run tests + generate report
RUN dotnet test ReqnrollProjectCucumberBDD.sln \
    --logger "trx;LogFileName=test_results.trx" \
    --results-directory /app/reports \
    --collect:"XPlat Code Coverage"

# Keep container alive so we can inspect reports
CMD ["bash", "-c", "echo 'Tests completed. Reports stored in /app/reports'; tail -f /dev/null"]


#Docker file ends here
# ================================================================================###

✔ COPY . ./ preserves your entire folder structure
✔ dotnet restore ReqnrollProjectCucumberBDD.sln now finds all csproj files
✔ Tests run successfully
✔ Results + coverage output saved into /app/reports
# ==================================Build the image===============
docker build -t reqnroll-tests .

# ==================================Run the container===============
docker run -it --name reqnroll-runner reqnroll-tests

# =========================Copy report files to your machine==========
docker cp reqnroll-runner:/app/reports ./reports


