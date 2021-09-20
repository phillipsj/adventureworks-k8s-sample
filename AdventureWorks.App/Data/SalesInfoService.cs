using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace AdventureWorks.App.Data {
    public class SalesInfoService {
        private readonly IDbConnection _connection;

        public SalesInfoService(IDbConnection connection) {
            _connection = connection;
        }

        public List<SalesInfo> GetSalesInfo() {
            return _connection.Query<SalesInfo>(@"SELECT CONCAT([FirstName], ' ', [LastName]) as Name,
            ISNULL([SalesQuota], 0) as Quota,
            [SalesYTD] as Ytd
            FROM [Sales].[vSalesPerson];").ToList();
        }
    }
}