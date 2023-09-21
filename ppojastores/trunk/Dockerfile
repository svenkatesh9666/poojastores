# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:3.1
WORKDIR . /app/

# Copy the tools.json file to the working directory
COPY tools.json .

# Install the dotnet-ef tool using dotnet CLI
RUN dotnet tool install --global dotnet-ef --version 3.1

# Add the tool's path to the PATH environment variable
ENV PATH="/root/.dotnet/tools:${PATH}"

# Set the entry point to run dotnet-ef
CMD ["dotnet-ef"]
