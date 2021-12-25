﻿using Bshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefualt { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public int FileSize { get; set; }

        public Product Product { get; set; }

    }
}
