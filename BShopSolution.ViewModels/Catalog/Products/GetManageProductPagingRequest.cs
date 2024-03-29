﻿using BShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
