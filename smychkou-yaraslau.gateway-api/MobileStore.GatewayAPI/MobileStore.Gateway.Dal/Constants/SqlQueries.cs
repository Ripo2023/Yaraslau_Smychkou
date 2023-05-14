namespace MobileStore.Gateway.Dal.Constants
{
    internal static class SqlQueries
    {
        internal const string GetAllCategories = @"SELECT Id, Name FROM Category";

        internal const string GetCategoryProductsByPage = @"SELECT p.Id, p.Name, p.ImagePath, p.StartPrice
                                                            FROM CategoryProduct cp
                                                            LEFT JOIN Product p ON p.Id = cp.ProductId
                                                            WHERE cp.CategoryId = @categoryId AND p.Id > @lastViewedId 
                                                            LIMIT @pageSize";

        internal const string GetCategoryProductsByFirstPage = @"SELECT p.Id, p.Name, p.ImagePath
                                                                 FROM CategoryProduct cp
                                                                 LEFT JOIN Product p ON p.Id = cp.ProductId
                                                                 WHERE cp.CategoryId = @categoryId
                                                                 LIMIT @pageSize";

        internal const string GetProductDetails = @"SELECT 
                                                        p.Id, p.Name, p.Description, p.ImagePath, p.StartPrice,
                                                        pc.ComponentId, c.Name AS ComponentName, c.ImagePath AS ComponentImagePath,
                                                        c.Price AS ComponentPrice, pc.IsStandart AS ComponentIsStandart,
                                                        pv.Number, pv.Volume
                                                    FROM Product p
                                                    LEFT JOIN ProductComponent pc ON pc.ProductId = p.Id
                                                    LEFT JOIN Component c         ON c.Id = pc.ComponentId
                                                    LEFT JOIN ProductVolume pv    ON pv.ProductId = p.Id";

        internal const string CreateOrder = @"";

        internal const string UpdateOrder = @"";

        internal const string GetAllOrders = @"";

        internal const string GetOrderDetails = @"";
    }
}
