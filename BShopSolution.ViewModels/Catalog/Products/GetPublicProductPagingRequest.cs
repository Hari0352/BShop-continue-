﻿using BShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
