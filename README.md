# EvolentHealthContacts

## About
EvolentHealthContacts Project maintains contacts information.

## Software Requirements
1. .Net Framework 4.5.2
2. IIS
3. SQL Server 2012

## Instructions
1. Pull source code from Github.
2. Execute SQL Scripts to create database and tables.
3. Create a Website in IIS and refer the source code.
4. Launch the Website then navigate to "~/api/ContactWebApi"(This request will list all the contacts info)
5. To verify add/edit/delete features, use any Web API testing tools like Postman.
	for add use same link with POST Http request
	for edit use same link with PUT Http request
	for delete use same link with DELETE Http request

## Architechture
1. DataAccessLayer:	This layer is responsible to perform CRUD operations.
2. BusinessLayer:		This layer is responsible to enforce business operations on data entities.
3. WebAPI:				This layer is responsible to get a WebApi request and contact other layers to process the request.



