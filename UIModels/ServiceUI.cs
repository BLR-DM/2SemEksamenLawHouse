﻿namespace UIModels
{
    public class ServiceUI
    {
        public int ServiceID { get; set; }

        //attributes
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public string PriceType { get; set; }
        public int ServicePriceTypeID { get; set; }
    }
}
