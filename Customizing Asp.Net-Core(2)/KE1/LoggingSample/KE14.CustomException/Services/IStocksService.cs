using KE14.CustomException.Model;
using System;
using System.Collections.Generic;

namespace KE14.CustomException.Services
{
    public interface IStocksService
    {
        /// <summary>
        /// Returns all <see cref="Stock"/>s
        /// </summary>
        /// <returns>An enumerable of <see cref="Stock"/>s</returns>
        public IEnumerable<Stock> GetAllStocks();

        /// <summary>
        /// Returns the <see cref="Stock"/> with the requested <see cref="stockId"/>
        /// </summary>
        /// <param name="stockId">The ID of the <see cref="Stock"/> to return</param>
        /// <returns>The <see cref="Stock"/> with the requested <see cref="stockId"/></returns>
        /// <exception cref="NotFoundException"></exception>
        public Stock GetStock(Guid stockId);
    }
}
