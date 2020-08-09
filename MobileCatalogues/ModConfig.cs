﻿using Microsoft.Xna.Framework;

namespace MobileCatalogues
{
    class ModConfig
    {
        public bool EnableMod { get; set; } = true;
        public bool EnableCatalogue { get; set; } = true;
        public bool EnableFurnitureCatalogue { get; set; } = true;
        public bool EnableSeedCatalogue { get; set; } = true;
        public bool EnableTravelingCatalogue { get; set; } = true;
        public bool LimitTravelingCatalogToInTown { get; set; } = true;
        public bool EnableDesertCatalogue { get; set; } = true;
        public bool LimitDesertCatalogToBusFixed { get; set; } = true;
        public bool EnableHatCatalogue { get; set; } = true;
        public bool FreeCatalogue { get; set; } = false;
        public bool FreeFurnitureCatalogue { get; set; } = false;
        public bool FreeSeedCatalogue { get; set; } = false;
        public string SeedsToInclude { get; set; } = "season";
        public float PriceMult { get; set; } = 1f;
    }
}