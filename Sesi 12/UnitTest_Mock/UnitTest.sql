/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Destination]
  FROM [UnitTest].[dbo].[Employees]



  Insert INTO Employees Values('Kevin', 'Jakarta-Bandung'),('Andi', 'Jakarta-Surabaya'),('Budi', 'Palembang-Bandung');