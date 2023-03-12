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
    
    
##### Technology and Framework - Frontend
    1. Angular 15
    2. UI Bootstrap


##### No Error handing is done on Client and Backend

##### Database 
     1. SQL Server Express
     ![image](https://user-images.githubusercontent.com/25218865/224533142-6d965084-7133-4f1c-b718-bfc58756db6f.png)

##### Shipper_Shipment_Details SP Code 
        USE [Transport]
        GO
        /****** Object:  StoredProcedure [dbo].[Shipper_Shipment_Details]    Script Date: 12-03-2023 13:55:49 ******/
        SET ANSI_NULLS ON
        GO
        SET QUOTED_IDENTIFIER ON
        GO
        ALTER PROCEDURE [dbo].[Shipper_Shipment_Details] @shipper_id int
        AS
        SELECT A.[shipment_id]
              ,A.[shipment_description]
              ,A.[shipment_weight]
              ,A.[shipment_rate_id]
              ,d.[shipment_rate_description]
              ,A.[shipper_id]
              ,B.[shipper_name]
              ,A.[carrier_id]
              ,C.[carrier_name]
              ,c.[carrier_mode]
          FROM [Transport].[dbo].[SHIPMENT] as A
          inner join [Transport].[dbo].[SHIPPER] as B on A.shipper_id = B.shipper_id
          inner join [Transport].[dbo].[CARRIER] as C on A.carrier_id = c.carrier_id
          inner join [Transport].[dbo].[SHIPMENT_RATE] as D on A.shipment_rate_id = D.shipment_rate_id
          where A.shipper_id = @shipper_id
          order by B.shipper_name asc
         
##### Backend API's details
      1. https://localhost:44326/api/Quote/Random
     
![image](https://user-images.githubusercontent.com/25218865/224533252-551389cf-4d10-4f94-a362-52c8346b1c5e.png)
 
      2. https://localhost:44326/api/Quote?authorName=Albert Einstein&page=1&limit=30
     
![image](https://user-images.githubusercontent.com/25218865/224533279-e6823940-bef2-42e6-9300-fd7a84d709a7.png)

      3. https://localhost:44326/api/Shipper
     
![image](https://user-images.githubusercontent.com/25218865/224533293-aead075a-35a8-43a5-96e1-64d8cbbcd4dc.png)
      
      4. https://localhost:44326/api/Shipper/1/Shipment
     
![image](https://user-images.githubusercontent.com/25218865/224533305-7a45fcaf-5427-4f36-8910-7f29ab5b0ad1.png)

##### Client UI -> No loading is implemented 
      1. Random Quote Page
        -> Click on button to get random quote
 ![image](https://user-images.githubusercontent.com/25218865/224533394-2843235c-1755-4771-aebb-c9d6508e3117.png)
 
      2. Quote List Page
 ![image](https://user-images.githubusercontent.com/25218865/224533416-09081541-9fc4-452a-a9bf-baa6dccdd3d2.png)

      3. Shipper Names and Shipment Details
        -> Click on shipper name to fetch its shipments
 ![image](https://user-images.githubusercontent.com/25218865/224533436-f01d0b47-666d-450f-9122-9b42e601a523.png)
 
 
 
 ##### How to run 
      1. Backend 
        -> To run backend need Visual Studio and DotNet 6 installed.
        -> Hit start button on Visual Studio and note down the port its running check launch profile to config launch settings.
        
      2. Frontend 
        -> Node.js
        -> Angular
        -> Install packages using NPM install inside src\Frontend\shipment Folder.
        -> configure api endpoints , currently api url is hardcoded inside quote.service and shipper.service please update this endpoint to match your api endpoint
![image](https://user-images.githubusercontent.com/25218865/224533658-95ac52de-ac72-4220-b4d4-6756b6f9b0a5.png)
       

        





      
