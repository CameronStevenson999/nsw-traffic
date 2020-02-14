# nsw-traffic
.Net Core console application that retrieves NSW Traffic data to "output.csv"


## Overview
### Application functions
1. Enter your name
2. The current traffic incidents API data is saved to "output.csv" automatically in the solution folder
 * [NSW Open Data Transport API](https://opendata.transport.nsw.gov.au/sites/default/files/Live_Traffic_Data_Developer_Guide.pdf)

## Running the application

### Dependencies
The following dependencies will be required to run the application locally:
1. Install [Dotnet-sdk](https://dotnet.microsoft.com/download)

### Restore/Run
1. Install dependencies
2. Clone repo.
3. Change directory `cd nsw-traffic/nsw-open-data`
4. * Restore project dependencies `dotnet restore`
   * Build Project `dotnet build`
   * Run app via `dotnet run` command

### Testing
XUnit
1. Run from root directory `nsw-traffic/nsw-open-data`:
2. Run tests via `dotnet test` command

### Tools
1. [Postman](https://www.getpostman.com/downloads)
2. [Git](https://git-scm.com/downloads)
3. [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
4. [Visual Studio Code](https://code.visualstudio.com/download)
