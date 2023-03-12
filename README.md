# Shipment Project 

Folder Structure Conventions
============================

> Folder structure options and naming conventions for software projects
### A typical top-level directory layout

    .
    ├── src                          # Source files 
    │   ├── Backend                  # Backend Project
    │   │   ├── Application          # Application logic
    │   │   ├── Domain               # Bussiness Domain entiries and bussiness logic if any
    │   │   ├── Infrastructure       # Infrastructure call to external services and database
    │   │   ├── Shipment.Api         # Main API endpoint and configuration
    │   ├── Frontend                 # Frontend Project
    └── README.md
    
 ### Backend - DOTNET 6
 ![image](https://user-images.githubusercontent.com/25218865/224532782-e057787c-a28f-488a-a0c3-d2fe099129fb.png)



##### Technology and Framework
    1. All projects are in DotNet 6
    2. For Database access Dapper Micro ORM is used.
    3. Mediator and Reporitory pattern is used
    4. Trying to use Domain Driven Design 
    5. SQL Server Express for database
      

      
