SELECT s.[BusinessEntityID] as Id
     , s.[Name]
     , a.[AddressLine1]
     , a.[AddressLine2]
     , a.[City]
     , sp.[Name] AS [StateProvince]
     , a.[PostalCode]
     , cr.[Name] AS [Country]
     , a.SpatialLocation.Lat as Latitude
     , a.SpatialLocation.Long as Longitude
FROM [Sales].[Store] s
    INNER JOIN [Person].[BusinessEntityAddress] bea
ON bea.[BusinessEntityID] = s.[BusinessEntityID]
    INNER JOIN [Person].[Address] a
    ON a.[AddressID] = bea.[AddressID]
    INNER JOIN [Person].[StateProvince] sp
    ON sp.[StateProvinceID] = a.[StateProvinceID]
    INNER JOIN [Person].[CountryRegion] cr
    ON cr.[CountryRegionCode] = sp.[CountryRegionCode]
    INNER JOIN [Person].[AddressType] at
    ON at.[AddressTypeID] = bea.[AddressTypeID]
WHERE at.[Name] = 'Main Office';