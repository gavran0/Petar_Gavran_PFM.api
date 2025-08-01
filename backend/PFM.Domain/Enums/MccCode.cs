﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Enums
{
    public enum MccCode
    {
        [Display(Name = "Telecommunication service including local and long distance calls, credit card calls, calls through use of magneticstrip reading telephones and fax services")]
        TelecommunicationServiceIncludingLocalAndLongDistanceCallsCreditCardCallsCallsThroughUseOfMagneticstripReadingTelephonesAndFaxServices = 4814,
        [Display(Name = "VisaPhone")]
        Visaphone = 4815,
        [Display(Name = "Telegraph services")]
        TelegraphServices = 4821,
        [Display(Name = "Money Orders - Wire Transfer")]
        MoneyOrdersWireTransfer = 4829,
        [Display(Name = "Cable and other pay television (previously Cable Services)")]
        CableAndOtherPayTelevisionPreviouslyCableServices = 4899,
        [Display(Name = "Electric, Gas, Sanitary and Water Utilities")]
        ElectricGasSanitaryAndWaterUtilities = 4900,
        [Display(Name = "Motor vehicle supplies and new parts")]
        MotorVehicleSuppliesAndNewParts = 5013,
        [Display(Name = "Office and Commercial Furniture")]
        OfficeAndCommercialFurniture = 5021,
        [Display(Name = "Construction Materials, Not Elsewhere Classified")]
        ConstructionMaterialsNotElsewhereClassified = 5039,
        [Display(Name = "Office, Photographic, Photocopy, and Microfilm Equipment")]
        OfficePhotographicPhotocopyAndMicrofilmEquipment = 5044,
        [Display(Name = "Computers, Computer Peripheral Equipment, Software")]
        ComputersComputerPeripheralEquipmentSoftware = 5045,
        [Display(Name = "Commercial Equipment, Not Elsewhere Classified")]
        CommercialEquipmentNotElsewhereClassified = 5046,
        [Display(Name = "Medical, Dental Ophthalmic, Hospital Equipment and Supplies")]
        MedicalDentalOphthalmicHospitalEquipmentAndSupplies = 5047,
        [Display(Name = "Metal Service Centers and Offices")]
        MetalServiceCentersAndOffices = 5051,
        [Display(Name = "Electrical Parts and Equipment")]
        ElectricalPartsAndEquipment = 5065,
        [Display(Name = "Hardware Equipment and Supplies")]
        HardwareEquipmentAndSupplies = 5072,
        [Display(Name = "Plumbing and Heating Equipment and Supplies")]
        PlumbingAndHeatingEquipmentAndSupplies = 5074,
        [Display(Name = "Industrial Supplies, Not Elsewhere Classified")]
        IndustrialSuppliesNotElsewhereClassified = 5085,
        [Display(Name = "Precious Stones and Metals, Watches and Jewelry")]
        PreciousStonesAndMetalsWatchesAndJewelry = 5094,
        [Display(Name = "Durable Goods, Not Elsewhere Classified")]
        DurableGoodsNotElsewhereClassified = 5099,
        [Display(Name = "Stationery, Office Supplies, Printing, and Writing Paper")]
        StationeryOfficeSuppliesPrintingAndWritingPaper = 5111,
        [Display(Name = "Drugs, Drug Proprietors, and Druggists Sundries")]
        DrugsDrugProprietorsAndDruggistSundries = 5122,
        [Display(Name = "Piece Goods, Notions, and Other Dry Goods")]
        PieceGoodsNotionsAndOtherDryGoods = 5131,
        [Display(Name = "Mens Womens and Childrens Uniforms and Commercial Clothing")]
        MenWomensAndChildrensUniformsAndCommercialClothing = 5137,
        [Display(Name = "Commercial Footwear")]
        CommercialFootwear = 5139,
        [Display(Name = "Chemicals and Allied Products, Not Elsewhere Classified")]
        ChemicalsAndAlliedProductsNotElsewhereClassified = 5169,
        [Display(Name = "Petroleum and Petroleum Products")]
        PetroleumAndPetroleumProducts = 5172,
        [Display(Name = "Books, Periodicals, and Newspapers")]
        BooksPeriodicalsAndNewspapers = 5192,
        [Display(Name = "Florists Supplies, Nursery Stock and Flowers")]
        FloristsSuppliesNurseryStockAndFlowers = 5193,
        [Display(Name = "Paints, Varnishes, and Supplies")]
        PaintsVarnishesAndSupplies = 5198,
        [Display(Name = "Non-durable Goods, Not Elsewhere Classified")]
        NonDurableGoodsNotElsewhereClassified = 5199,
        [Display(Name = "Home Supply Warehouse Stores")]
        HomeSupplyWarehouseStores = 5200,
        [Display(Name = "Lumber and Building Materials Stores")]
        LumberAndBuildingMaterialsStores = 5211,
        [Display(Name = "Glass Stores")]
        GlassStores = 5231,
        [Display(Name = "Paint and Wallpaper Stores")]
        PaintAndWallpaperStores = 5231,
        [Display(Name = "Wallpaper Stores")]
        WallpaperStores = 5231,
        [Display(Name = "Hardware Stores")]
        HardwareStores = 5251,
        [Display(Name = "Nurseries  Lawn and Garden Supply Store")]
        NurseriesLawnAndGardenSupplyStore = 5261,
        [Display(Name = "Mobile Home Dealers")]
        MobileHomeDealers = 5271,
        [Display(Name = "Wholesale Clubs")]
        WholesaleClubs = 5300,
        [Display(Name = "Duty Free Store")]
        DutyFreeStore = 5309,
        [Display(Name = "Discount Stores")]
        DiscountStores = 5310,
        [Display(Name = "Department Stores")]
        DepartmentStores = 5311,
        [Display(Name = "Variety Stores")]
        VarietyStores = 5331,
        [Display(Name = "Misc. General Merchandise")]
        MiscGeneralMerchandise = 5399,
        [Display(Name = "Grocery Stores")]
        GroceryStores = 5411,
        [Display(Name = "Supermarkets")]
        Supermarkets = 5411,
        [Display(Name = "Freezer and Locker Meat Provisioners")]
        FreezerAndLockerMeatProvisioners = 5422,
        [Display(Name = "Meat Provisioners  Freezer and Locker")]
        MeatProvisionersFrezzerAndLocker = 5422,
        [Display(Name = "Candy Stores")]
        CandyStores = 5441,
        [Display(Name = "Confectionery Stores")]
        ConfectioneryStores = 5441,
        [Display(Name = "Nut Stores")]
        NutStores = 5441,
        [Display(Name = "Dairy Products Stores")]
        DairyProductsStores = 5451,
        [Display(Name = "Bakeries")]
        Bakeries = 5462,
        [Display(Name = "Misc. Food Stores  Convenience Stores and Specialty Markets")]
        MiscFoodStoresAndSpecialtyMarkets = 5499,
        [Display(Name = "Car and Truck Dealers (New and Used) Sales, Service, Repairs, Parts, and Leasing")]
        CarAndTruckDealersNewAndUsedSalesServiceRepairsPartsAndLeasing = 5511,
        [Display(Name = "Automobile and Truck Dealers (Used Only)")]
        AutomobileAndTruckDealersUsedOnly = 5521,
        [Display(Name = "Automobile Supply Stores")]
        AutomobileSupplyStores = 5531,
        [Display(Name = "Automotive Tire Stores")]
        AutomotiveTireStores = 5532,
        [Display(Name = "Automotive Parts, Accessories Stores")]
        AutomotivePartsAccessoriesStores = 5533,
        [Display(Name = "Service Stations ( with or without ancillary services)")]
        ServiceStationsWithOrWithoutAncillaryServices = 5541,
        [Display(Name = "Automated Fuel Dispensers")]
        AutomatedFuelDispensers = 5542,
        [Display(Name = "Boat Dealers")]
        BoatDealers = 5551,
        [Display(Name = "Recreational and Utility Trailers, Camp Dealers")]
        RecreationalAndUtilityTrailersCampDealers = 5561,
        [Display(Name = "Motorcycle Dealers")]
        MotorcycleDealers = 5571,
        [Display(Name = "Motor Home Dealers")]
        MotorHomeDealers = 5592,
        [Display(Name = "Snowmobile Dealers")]
        SnowmobileDealers = 5598,
        [Display(Name = "Mens and Boys Clothing and Accessories Stores")]
        MensAndBoysClothingAndAccessoriesStores = 5611,
        [Display(Name = "Womens Ready - to - Wear Stores")]
        WomensReadyToWearShoes= 5621,
        [Display(Name = "Womens Accessory and Specialty Shops")]
        WomenAccessoryandSpecialtyShops = 5631,
        [Display(Name = "Childrens and Infants Wear Stores")]
        ChildrensAndInfantsWearStores = 5641,
        [Display(Name = "Family Clothing Stores")]
        FamilyClothingStores = 5651,
        [Display(Name = "Sports Apparel, Riding Apparel Stores")]
        SportsApparelRidingApparelStores = 5655,
        [Display(Name = "Shoe Stores")]
        ShoeStores = 5661,
        [Display(Name = "Furriers and Fur Shops")]
        FurriersAndFurShops = 5681,
        [Display(Name = "Mens and Womens Clothing Stores")]
        MensAndWomensClothingStore = 5691,
        [Display(Name = "Tailors, Seamstress, Mending, and Alterations")]
        TailorsSeamstressMendingAndAlterations = 5697,
        [Display(Name = "Wig and Toupee Stores")]
        WigAndToupeeStores = 5698,
        [Display(Name = "Miscellaneous Apparel and Accessory Shops")]
        MiscellaneousApparelAndAccessoryShops = 5699,
        [Display(Name = "Furniture, Home Furnishings, and Equipment Stores, Except Appliances")]
        FurnitureHomeFurnishingsAndEquipmentStoresExceptAppliances = 5712,
        [Display(Name = "Floor Covering Stores")]
        FloorCoveringStores = 5713,
        [Display(Name = "Drapery, Window Covering and Upholstery Stores")]
        DraperyWindowCoveringAndUpholsteryStores = 5714,
        [Display(Name = "Fireplace, Fireplace Screens, and Accessories Stores")]
        FireplaceFireplaceScreensAndAccessoriesStores = 5718,
        [Display(Name = "Miscellaneous Home Furnishing Specialty Stores")]
        MiscellaneousHomeFurnishingSpecialtyStores = 5719,
        [Display(Name = "Household Appliance Stores")]
        HouseholdApplianceStores = 5722,
        [Display(Name = "Electronic Sales")]
        ElectronicSales = 5732,
        [Display(Name = "Music Stores, Musical Instruments, Piano Sheet Music")]
        MusicStoresMusicalInstrumentsPianoSheetMusic = 5733,
        [Display(Name = "Computer Software Stores")]
        ComputerSoftwareStores = 5734,
        [Display(Name = "Record Shops")]
        RecordShops = 5735,
        [Display(Name = "Caterers")]
        Caterers = 5811,
        [Display(Name = "Eating places and Restaurants")]
        EatingPlacesAndRestaurants = 5812,
        [Display(Name = "Drinking Places (Alcoholic Beverages), Bars, Taverns, Cocktail lounges, Nightclubs and Discotheques")]
        DrinkingPlacesAlcoholicBeveragesBarsTavernsCocktailLoungesNightclubsAndDiscotheques = 5813,
        [Display(Name = "Fast Food Restaurants")]
        FastFoodRestaurants = 5814,
        [Display(Name = "Drug Stores and Pharmacies")]
        DrugStoresAndPharmacies = 5912,
        [Display(Name = "Package Stores - Beer, Wine, and Liquor")]
        PackageStoresBeerWineAndLiquor = 5921,
        [Display(Name = "Used Merchandise and Secondhand Stores")]
        UsedMerchandiseAndSecondhandStores = 5931,
        [Display(Name = "Antique Shops - Sales, Repairs, and Restoration Services")]
        AntiqueShopsSalesRepairsAndRestorationServices = 5832,
        [Display(Name = "Pawn Shops and Salvage Yards")]
        PawnShopsAndSalvageYards = 5933,
        [Display(Name = "Wrecking and Salvage Yards")]
        WreckingAndSalvageYards = 5935,
        [Display(Name = "Antique Reproductions")]
        AntiqueReproductions = 5937,
        [Display(Name = "Bicycle Shops - Sales and Service")]
        BicycleShopsSalesAndService = 5940,
        [Display(Name = "Sporting Goods Stores")]
        SportingGoodsStores = 5941,
        [Display(Name = "Book Stores")]
        BookStores = 5942,
        [Display(Name = "Stationery Stores, Office and School Supply Stores")]
        StationeryStoresOfficeAndSchoolSupplyStores = 5943,
        [Display(Name = "Watch, Clock, Jewelry, and Silverware Stores")]
        WatchClockJewelryAndSilverwareStores = 5944,
        [Display(Name = "Hobby, Toy, and Game Shops")]
        HobbyToyAndGameShops = 5945,
        [Display(Name = "Camera and Photographic Supply Stores")]
        CameraAndPhotographicSupplyStores = 5946,
        [Display(Name = "Card Shops, Gift, Novelty, and Souvenir Shops")]
        CardShopsGiftNoveltyAndSouvenirShops = 5947,
        [Display(Name = "Leather Foods Stores")]
        LeatherFoodsStores = 5948,
        [Display(Name = "Sewing, Needle, Fabric, and Price Goods Stores")]
        SewingNeedleFabricAndPriceGoodsStores = 5949,
        [Display(Name = "Glassware/Crystal Stores")]
        GlasswareCrystalStores = 5950,
        [Display(Name = "Direct Marketing - Insurance Service")]
        DirectMarketingInsuranceService = 5960,
        [Display(Name = "Mail Order Houses Including Catalog Order Stores, Book/Record Clubs (No longer permitted for .S. original presentments)")]
        MailOrderHousesIncludingCatalogOrderStoresBookRecordClubsNoLongerPermittedForSOriginalPresentments = 5961,
        [Display(Name = "Direct Marketing - Travel Related Arrangements Services")]
        DirectMarketingTravelRelatedArrangementsServices = 5962,
        [Display(Name = "Door - to - Door Sales")]
        DoorToDoorSales = 5963,
        [Display(Name = "Direct Marketing - Catalog Merchant")]
        DirectMarketingCatalogMerchant = 5964,
        [Display(Name = "Direct Marketing - Catalog and Catalog and Retail Merchant Direct Marketing - Outbound Telemarketing Merchant")]
        DirectMarketingCatalogAndCatalogAndRetailMerchantDirectMarketingOutboundTelemarketingMerchant = 5965,
        [Display(Name = "Direct Marketing -Inbound Teleservices Merchant")]
        DirectMarketingInboundTeleservicesMerchant = 5967,
        [Display(Name = "Direct Marketing - Continuity/Subscription Merchant")]
        DirectMarketingContinuitySubscriptionMerchant = 5968,
        [Display(Name = "Direct Marketing - Not Elsewhere Classified")]
        DirectMarketingNotElsewhereClassified = 5969,
        [Display(Name = "Artists Supply and Craft Shops")]
        SupplyandCraftShops = 5970,
        [Display(Name = "Art Dealers and Galleries")]
        ArtDealersAndGalleries = 5971,
        [Display(Name = "Stamp and Coin Stores - Philatelic and Numismatic Supplies")]
        StampAndCoinStoresPhilatelicAndNumismaticSupplies = 5972,
        [Display(Name = "Religious Goods Stores")]
        ReligiousGoodsStores = 5973,
        [Display(Name = "Hearing Aids - Sales, Service, and Supply Stores")]
        HearingAidsSalesServiceAndSupplyStores = 5975,
        [Display(Name = "Orthopedic Goods Prosthetic Devices")]
        OrthopedicGoodsProstheticDevices = 5976,
        [Display(Name = "Cosmetic Stores")]
        CosmeticStores = 5977,
        [Display(Name = "Typewriter Stores - Sales, Rental, Service")]
        TypewriterStoresSalesRentalService = 5978,
        [Display(Name = "Fuel - Fuel Oil, Wood, Coal, Liquefied Petroleum")]
        FuelFuelOilWoodCoalLiquefiedPetroleum = 5983,
        [Display(Name = "Florists")]
        Florists = 5992,
        [Display(Name = "Cigar Stores and Stands")]
        CigarStoresAndStands = 5993,
        [Display(Name = "News Dealers and Newsstands")]
        NewsDealersAndNewsstands = 5994,
        [Display(Name = "Pet Shops, Pet Foods, and Supplies Stores")]
        PetShopsPetFoodsAndSuppliesStores = 5995,
        [Display(Name = "Swimming Pools - Sales, Service, and Supplies")]
        SwimmingPoolsSalesServiceAndSupplies = 5996,
        [Display(Name = "Electric Razor Stores - Sales and Service")]
        ElectricRazorStoresSalesAndService = 5997,
        [Display(Name = "Tent and Awning Shops")]
        TentAndAwningShops = 5998,
        [Display(Name = "Miscellaneous and Specialty Retail Stores")]
        MiscellaneousAndSpecialtyRetailStores = 5999,
        [Display(Name = "Financial Institutions - Cash Disbursements")]
        FinancialInstitutionsCashDisbursements = 6010,
        [Display(Name = "Financial Institutions - Manual Cash Disbursements")]
        FinancialInstitutionsManualCashDisbursements = 6011,
        [Display(Name = "Financial Institutions - Merchandise and Services")]
        FinancialInstitutionsMerchandiseAndServices = 6012,
        [Display(Name = "Non - Financial Institutions - Foreign Currency, Money Orders (not wire transfer) and Travelers Cheques")]
        NonFinancialInstitutionsForeignCurrencyMoneyOrdersNotWireTransferAndTravelersCheques = 6051,
        [Display(Name = "Security Brokers/Dealers")]
        SecurityBrokersDealers = 6211,
        [Display(Name = "Insurance Sales, Underwriting, and Premiums")]
        InsuranceSalesUnderwritingAndPremiums = 6300,
        [Display(Name = "Insurance Premiums, (no longer valid for first presentment work)")]
        InsurancePremiumsNoLongerValidForFirstPresentmentWork = 6381,
        [Display(Name = "Insurance, Not Elsewhere Classified ( no longer valid for first presentment work)")]
        InsuranceNotElsewhereClassifiedNoLongerValidForFirstPresentmentWork = 6399,
        [Display(Name = "Lodging - Hotels, Motels, Resorts, Central Reservation Services (not elsewhere classified)")]
        LodgingHotelsMotelsResortsCentralReservationServicesNotElsewhereClassified = 7011,
        [Display(Name = "Timeshares")]
        Timeshares = 7012,
        [Display(Name = "Sporting and Recreational Camps")]
        SportingAndRecreationalCamps = 7032,
        [Display(Name = "Trailer Parks and Camp Grounds")]
        TrailerParksAndCampGrounds = 7033,
        [Display(Name = "Laundry, Cleaning, and Garment Services")]
        LaundryCleaningAndGarmentServices = 7210,
        [Display(Name = "Laundry - Family and Commercial")]
        LaundryFamilyAndCommercial = 7211,
        [Display(Name = "Dry Cleaners")]
        DryCleaners = 7216,
        [Display(Name = "Carpet and Upholstery Cleaning")]
        CarpetAndUpholsteryCleaning = 7217,
        [Display(Name = "Photographic Studios")]
        PhotographicStudios = 7221,
        [Display(Name = "Barber and Beauty Shops")]
        BarberAndBeautyShops = 7230,
        [Display(Name = "Shop Repair Shops and Shoe Shine Parlors, and Hat Cleaning Shops")]
        ShopRepairShopsAndShoeShineParlorsAndHatCleaningShops = 7251,
        [Display(Name = "Funeral Service and Crematories")]
        FuneralServiceAndCrematories = 7261,
        [Display(Name = "Dating and Escort Services")]
        DatingAndEscortServices = 7273,
        [Display(Name = "Tax Preparation Service")]
        TaxPreparationService = 7276,
        [Display(Name = "Counseling Service - Debt, Marriage, Personal")]
        CounselingServiceDebtMarriagePersonal = 7277,
        [Display(Name = "Buying/Shopping Services, Clubs")]
        BuyingShoppingServicesClubs = 7278,
        [Display(Name = "Clothing Rental - Costumes, Formal Wear, Uniforms")]
        ClothingRentalCostumesFormalWearUniforms = 7296,
        [Display(Name = "Massage Parlors")]
        MassageParlors = 7297,
        [Display(Name = "Health and Beauty Shops")]
        HealthAndBeautyShops = 7298,
        [Display(Name = "Miscellaneous Personal Services ( not elsewhere classifies)")]
        MiscellaneousPersonalServicesNotElsewhereClassifies = 7299,
        [Display(Name = "Advertising Services")]
        AdvertisingServices = 7311,
        [Display(Name = "Consumer Credit Reporting Agencies")]
        ConsumerCreditReportingAgencies = 7321,
        [Display(Name = "Blueprinting and Photocopying Services")]
        BlueprintingAndPhotocopyingServices = 7332,
        [Display(Name = "Commercial Photography, Art and Graphics")]
        CommercialPhotographyArtAndGraphics = 7333,
        [Display(Name = "Quick Copy, Reproduction and Blueprinting Services")]
        QuickCopyReproductionAndBlueprintingServices = 7338,
        [Display(Name = "Stenographic and Secretarial Support Services")]
        StenographicAndSecretarialSupportServices = 7339,
        [Display(Name = "Disinfecting Services")]
        DisinfectingServices = 7342,
        [Display(Name = "Exterminating and Disinfecting Services")]
        ExterminatingAndDisinfectingServices = 7342,
        [Display(Name = "Cleaning and Maintenance, Janitorial Services")]
        CleaningAndMaintenanceJanitorialServices = 7349,
        [Display(Name = "Employment Agencies, Temporary Help Services")]
        EmploymentAgenciesTemporaryHelpServices = 7361,
        [Display(Name = "Computer Programming, Integrated Systems Design and Data Processing Services")]
        ComputerProgrammingIntegratedSystemsDesignAndDataProcessingServices = 7372,
        [Display(Name = "Information Retrieval Services")]
        InformationRetrievalServices = 7375,
        [Display(Name = "Computer Maintenance and Repair Services, Not Elsewhere Classified")]
        ComputerMaintenanceAndRepairServicesNotElsewhereClassified = 7379,
        [Display(Name = "Management, Consulting, and Public Relations Services")]
        ManagementConsultingAndPublicRelationsServices = 7392,
        [Display(Name = "Protective and Security Services - Including Armored Cars and Guard Dogs")]
        ProtectiveAndSecurityServicesIncludingArmoredCarsAndGuardDogs = 7393,
        [Display(Name = "Equipment Rental and Leasing Services, Tool Rental, Furniture Rental, and Appliance Rental")]
        EquipmentRentalAndLeasingServicesToolRentalFurnitureRentalAndApplianceRental = 7394,
        [Display(Name = "Photofinishing Laboratories, Photo Developing")]
        PhotofinishingLaboratoriesPhotoDeveloping = 7395,
        [Display(Name = "Business Services, Not Elsewhere Classified")]
        BusinessServicesNotElsewhereClassified = 7399,
        [Display(Name = "Car Rental Companies ( Not Listed Below)")]
        CarRentalCompaniesNotListedBelow = 7512,
        [Display(Name = "Truck and Utility Trailer Rentals")]
        TruckAndUtilityTrailerRentals = 7513,
        [Display(Name = "Motor Home and Recreational Vehicle Rentals")]
        MotorHomeAndRecreationalVehicleRentals = 7519,
        [Display(Name = "Automobile Parking Lots and Garages")]
        AutomobileParkingLotsAndGarages = 7523,
        [Display(Name = "Automotive Body Repair Shops")]
        AutomotiveBodyRepairShops = 7531,
        [Display(Name = "Tire Re - treading and Repair Shops")]
        TireReTreadingAndRepairShops = 7534,
        [Display(Name = "Paint Shops - Automotive")]
        PaintShopsAutomotive = 7535,
        [Display(Name = "Automotive Service Shops")]
        AutomotiveServiceShops = 7538,
        [Display(Name = "Car Washes")]
        CarWashes = 7542,
        [Display(Name = "Towing Services")]
        TowingServices = 7549,
        [Display(Name = "Radio Repair Shops")]
        RadioRepairShops = 7622,
        [Display(Name = "Air Conditioning and Refrigeration Repair Shops")]
        AirConditioningAndRefrigerationRepairShops = 7623,
        [Display(Name = "Electrical And Small Appliance Repair Shops")]
        ElectricalAndSmallApplianceRepairShops = 7629,
        [Display(Name = "Watch, Clock, and Jewelry Repair")]
        WatchClockAndJewelryRepair = 7631,
        [Display(Name = "Furniture, Furniture Repair, and Furniture Refinishing")]
        FurnitureFurnitureRepairAndFurnitureRefinishing = 7641,
        [Display(Name = "Welding Repair")]
        WeldingRepair = 7692,
        [Display(Name = "Repair Shops and Related Services - Miscellaneous")]
        RepairShopsAndRelatedServicesMiscellaneous = 7699,
        [Display(Name = "Motion Pictures and Video Tape Production and Distribution")]
        MotionPicturesAndVideoTapeProductionAndDistribution = 7829,
        [Display(Name = "Motion Picture Theaters")]
        MotionPictureTheaters = 7832,
        [Display(Name = "Video Tape Rental Stores")]
        VideoTapeRentalStores = 7841,
        [Display(Name = "Dance Halls, Studios and Schools")]
        DanceHallsStudiosAndSchools = 7911,
        [Display(Name = "Theatrical Producers (Except Motion Pictures), Ticket Agencies")]
        TheatricalProducersExceptMotionPicturesTicketAgencies = 7922,
        [Display(Name = "Bands. Orchestras, and Miscellaneous Entertainers (Not Elsewhere Classified)")]
        BandsOrchestrasAndMiscellaneousEntertainersNotElsewhereClassified = 7929,
        [Display(Name = "Billiard and Pool Establishments")]
        BilliardAndPoolEstablishments = 7932,
        [Display(Name = "Bowling Alleys")]
        BowlingAlleys = 7933,
        [Display(Name = "Commercial Sports, Athletic Fields, Professional Sport Clubs, and Sport Promoters")]
        CommercialSportsAthleticFieldsProfessionalSportClubsAndSportPromoters = 7941,
        [Display(Name = "Tourist Attractions and Exhibits")]
        TouristAttractionsAndExhibits = 7991,
        [Display(Name = "Golf Courses - Public")]
        GolfCoursesPublic = 7992,
        [Display(Name = "Video Amusement Game Supplies")]
        VideoAmusementGameSupplies = 7993,
        [Display(Name = "Video Game Arcades/Establishments")]
        VideoGameArcadesEstablishments = 7994,
        [Display(Name = "Betting (including Lottery Tickets, Casino Gaming Chips, Off - track Betting and Wagers)")]
        BettingIncludingLotteryTicketsCasinoGamingChipsOffTrackBettingAndWagers = 7995,
        [Display(Name = "Amusement Parks, Carnivals, Circuses, Fortune Tellers")]
        AmusementParksCarnivalsCircusesFortuneTellers = 7996,
        [Display(Name = "Membership Clubs (Sports, Recreation, Athletic), Country Clubs, and Private Golf Courses")]
        MembershipClubsSportsRecreationAthleticCountryClubsAndPrivateGolfCourses = 7997,
        [Display(Name = "Aquariums, Sea - aquariums, Dolphinariums")]
        AquariumsSeaAquariumsDolphinariums = 7998,
        [Display(Name = "Recreation Services (Not Elsewhere Classified)")]
        RecreationServicesNotElsewhereClassified = 7999,
        [Display(Name = "Doctors and Physicians (Not Elsewhere Classified)")]
        DoctorsAndPhysiciansNotElsewhereClassified = 8011,
        [Display(Name = "Dentists and Orthodontists")]
        DentistsAndOrthodontists = 8021,
        [Display(Name = "Osteopaths")]
        Osteopaths = 8031,
        [Display(Name = "Chiropractors")]
        Chiropractors = 8041,
        [Display(Name = "Optometrists and Ophthalmologists")]
        OptometristsAndOphthalmologists = 8042,
        [Display(Name = "Opticians, Opticians Goods and Eyeglasses")]
        OpticiansOpticiansGoodsAndEyeglasses = 8043,
        [Display(Name = "Opticians, Optical Goods, and Eyeglasses (no longer valid for first presentments)")]
        OpticiansOpticalGoodsAndEyeglassesNoLongerValidForFirstPresentments = 8044,
        [Display(Name = "Podiatrists and Chiropodists")]
        PodiatristsAndChiropodists = 8049,
        [Display(Name = "Nursing and Personal Care Facilities")]
        NursingAndPersonalCareFacilities = 8050,
        [Display(Name = "Hospitals")]
        Hospitals = 8062,
        [Display(Name = "Medical and Dental Laboratories")]
        MedicalAndDentalLaboratories = 8071,
        [Display(Name = "Medical Services and Health Practitioners (Not Elsewhere Classified)")]
        MedicalServicesAndHealthPractitionersNotElsewhereClassified = 8099,
        [Display(Name = "Legal Services and Attorneys")]
        LegalServicesAndAttorneys = 8111,
        [Display(Name = "Elementary and Secondary Schools")]
        ElementaryAndSecondarySchools = 8211,
        [Display(Name = "Colleges, Junior Colleges, Universities, and Professional Schools")]
        CollegesJuniorCollegesUniversitiesAndProfessionalSchools = 8220,
        [Display(Name = "Correspondence Schools")]
        CorrespondenceSchools = 8241,
        [Display(Name = "Business and Secretarial Schools")]
        BusinessAndSecretarialSchools = 8244,
        [Display(Name = "Vocational Schools and Trade Schools")]
        VocationalSchoolsAndTradeSchools = 8249,
        [Display(Name = "Schools and Educational Services ( Not Elsewhere Classified)")]
        SchoolsAndEducationalServicesNotElsewhereClassified = 8299,
        [Display(Name = "Child Care Services")]
        ChildCareServices = 8351,
        [Display(Name = "Charitable and Social Service Organizations")]
        CharitableAndSocialServiceOrganizations = 8398,
        [Display(Name = "Civic, Fraternal, and Social Associations")]
        CivicFraternalAndSocialAssociations = 8641,
        [Display(Name = "Political Organizations")]
        PoliticalOrganizations = 8651,
        [Display(Name = "Religious Organizations")]
        ReligiousOrganizations = 8661,
        [Display(Name = "Automobile Associations")]
        AutomobileAssociations = 8675,
        [Display(Name = "Membership Organizations ( Not Elsewhere Classified)")]
        MembershipOrganizationsNotElsewhereClassified = 8699,
        [Display(Name = "Testing Laboratories ( non - medical)")]
        TestingLaboratoriesNonMedical = 8734,
        [Display(Name = "Architectural - Engineering and Surveying Services")]
        ArchitecturalEngineeringAndSurveyingServices = 8911,
        [Display(Name = "Accounting, Auditing, and Bookkeeping Services")]
        AccountingAuditingAndBookkeepingServices = 8931,
        [Display(Name = "Professional Services ( Not Elsewhere Defined)")]
        ProfessionalServicesNotElsewhereDefined = 8999,
        [Display(Name = "Court Costs, including Alimony and Child Support")]
        CourtCostsIncludingAlimonyAndChildSupport = 9211,
        [Display(Name = "Fines")]
        Fines = 9222,
        [Display(Name = "Bail and Bond Payments")]
        BailAndBondPayments = 9223,
        [Display(Name = "Tax Payments")]
        TaxPayments = 9311,
        [Display(Name = "Government Services ( Not Elsewhere Classified)")]
        GovernmentServicesNotElsewhereClassified = 9399,
        [Display(Name = "Postal Services - Government Only")]
        PostalServicesGovernmentOnly = 9402,
        [Display(Name = "Intra - Government Transactions")]
        IntraGovernmentTransactions = 9405,
        [Display(Name = "Automated Referral Service (For Visa Only)")]
        AutomatedReferralServiceForVisaOnly = 9700,
        [Display(Name = "Visa Credential Service ( For Visa Only)")]
        VisaCredentialServiceForVisaOnly = 9701,
        [Display(Name = "GCAS Emergency Services ( For Visa Only)")]
        GcasEmergencyServicesForVisaOnly = 9702,
        [Display(Name = "Intra - Company Purchases ( For Visa Only)")]
        IntraCompanyPurchasesForVisaOnly = 9950
    }
}
