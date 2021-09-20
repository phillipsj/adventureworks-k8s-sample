SELECT CONCAT([FirstName], ' ', [LastName]) as Name,
       ISNULL([SalesQuota], 0),
       [SalesYTD]
FROM [Sales].[vSalesPerson];