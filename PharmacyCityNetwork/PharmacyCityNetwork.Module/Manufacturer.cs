﻿namespace PharmacyCityNetwork;

    /// <summary>
    /// Сlass describing an Manufacturer
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Unique Id of Manufacturer
        /// </summary>
        public int ManufacturerId { get; set; } = 0;
        /// <summary>
        /// Manufacturer Name
        /// </summary>
        public string ManufacturerName { get; set; } = string.Empty;
        public List<Product> Product = new();
        public Manufacturer() { }
        public Manufacturer(string manufacturerName, int manufacturerId)
        {
            ManufacturerName = manufacturerName;
            ManufacturerId = manufacturerId;
        }
    }
