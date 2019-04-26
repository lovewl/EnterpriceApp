﻿using App.Domain.Core.Events;
using App.Domain.Models.Shop;
using System;
using System.Collections.Generic;

namespace App.Domain.Events.Shop.Product
{
    public class ProductUpdateEvent : Event
    {
        public ProductUpdateEvent(Guid productId, string productName, Models.Shop.Detail detail, Models.Shop.Category category, Models.Shop.Seller seller, ICollection<Models.Shop.Image> images)
        {
            ProductId = productId;
            ProductName = productName;
            Detail = detail;
            Category = category;
            Seller = seller;
            Images = images;
        }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public Models.Shop.Detail Detail { get; set; }
        public Models.Shop.Category Category { get; set; }
        public Models.Shop.Seller Seller { get; set; }
        public ICollection<Models.Shop.Image> Images { get; set; }

    }
}