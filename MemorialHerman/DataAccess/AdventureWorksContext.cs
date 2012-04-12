using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using DataAccess.Entities;
using DataAccess.Mapping;

namespace DataAccess
{
	public class AdventureWorksContext : DbContext, IDbContext
	{
		static AdventureWorksContext()
		{ 
			Database.SetInitializer<AdventureWorksContext>(null);
		}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
			modelBuilder.Configurations.Add(new AWBuildVersionMap());
			modelBuilder.Configurations.Add(new DatabaseLogMap());
			modelBuilder.Configurations.Add(new ErrorLogMap());
			modelBuilder.Configurations.Add(new DepartmentMap());
			modelBuilder.Configurations.Add(new EmployeeMap());
			modelBuilder.Configurations.Add(new EmployeeAddressMap());
			modelBuilder.Configurations.Add(new EmployeeDepartmentHistoryMap());
			modelBuilder.Configurations.Add(new EmployeePayHistoryMap());
			modelBuilder.Configurations.Add(new JobCandidateMap());
			modelBuilder.Configurations.Add(new ShiftMap());
			modelBuilder.Configurations.Add(new AddressMap());
			modelBuilder.Configurations.Add(new AddressTypeMap());
			modelBuilder.Configurations.Add(new ContactMap());
			modelBuilder.Configurations.Add(new ContactTypeMap());
			modelBuilder.Configurations.Add(new CountryRegionMap());
			modelBuilder.Configurations.Add(new StateProvinceMap());
			modelBuilder.Configurations.Add(new BillOfMaterialMap());
			modelBuilder.Configurations.Add(new CultureMap());
			modelBuilder.Configurations.Add(new DocumentMap());
			modelBuilder.Configurations.Add(new IllustrationMap());
			modelBuilder.Configurations.Add(new LocationMap());
			modelBuilder.Configurations.Add(new ProductMap());
			modelBuilder.Configurations.Add(new ProductCategoryMap());
			modelBuilder.Configurations.Add(new ProductCostHistoryMap());
			modelBuilder.Configurations.Add(new ProductDescriptionMap());
			modelBuilder.Configurations.Add(new ProductDocumentMap());
			modelBuilder.Configurations.Add(new ProductInventoryMap());
			modelBuilder.Configurations.Add(new ProductListPriceHistoryMap());
			modelBuilder.Configurations.Add(new ProductModelMap());
			modelBuilder.Configurations.Add(new ProductModelIllustrationMap());
			modelBuilder.Configurations.Add(new ProductModelProductDescriptionCultureMap());
			modelBuilder.Configurations.Add(new ProductPhotoMap());
			modelBuilder.Configurations.Add(new ProductProductPhotoMap());
			modelBuilder.Configurations.Add(new ProductReviewMap());
			modelBuilder.Configurations.Add(new ProductSubcategoryMap());
			modelBuilder.Configurations.Add(new ScrapReasonMap());
			modelBuilder.Configurations.Add(new TransactionHistoryMap());
			modelBuilder.Configurations.Add(new TransactionHistoryArchiveMap());
			modelBuilder.Configurations.Add(new UnitMeasureMap());
			modelBuilder.Configurations.Add(new WorkOrderMap());
			modelBuilder.Configurations.Add(new WorkOrderRoutingMap());
			modelBuilder.Configurations.Add(new ProductVendorMap());
			modelBuilder.Configurations.Add(new PurchaseOrderDetailMap());
			modelBuilder.Configurations.Add(new PurchaseOrderHeaderMap());
			modelBuilder.Configurations.Add(new ShipMethodMap());
			modelBuilder.Configurations.Add(new VendorMap());
			modelBuilder.Configurations.Add(new VendorAddressMap());
			modelBuilder.Configurations.Add(new VendorContactMap());
			modelBuilder.Configurations.Add(new ContactCreditCardMap());
			modelBuilder.Configurations.Add(new CountryRegionCurrencyMap());
			modelBuilder.Configurations.Add(new CreditCardMap());
			modelBuilder.Configurations.Add(new CurrencyMap());
			modelBuilder.Configurations.Add(new CurrencyRateMap());
			modelBuilder.Configurations.Add(new CustomerMap());
			modelBuilder.Configurations.Add(new CustomerAddressMap());
			modelBuilder.Configurations.Add(new IndividualMap());
			modelBuilder.Configurations.Add(new SalesOrderDetailMap());
			modelBuilder.Configurations.Add(new SalesOrderHeaderMap());
			modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonMap());
			modelBuilder.Configurations.Add(new SalesPersonMap());
			modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryMap());
			modelBuilder.Configurations.Add(new SalesReasonMap());
			modelBuilder.Configurations.Add(new SalesTaxRateMap());
			modelBuilder.Configurations.Add(new SalesTerritoryMap());
			modelBuilder.Configurations.Add(new SalesTerritoryHistoryMap());
			modelBuilder.Configurations.Add(new ShoppingCartItemMap());
			modelBuilder.Configurations.Add(new SpecialOfferMap());
			modelBuilder.Configurations.Add(new SpecialOfferProductMap());
			modelBuilder.Configurations.Add(new StoreMap());
			modelBuilder.Configurations.Add(new StoreContactMap());
			modelBuilder.Configurations.Add(new vEmployeeMap());
			modelBuilder.Configurations.Add(new vEmployeeDepartmentMap());
			modelBuilder.Configurations.Add(new vEmployeeDepartmentHistoryMap());
			modelBuilder.Configurations.Add(new vJobCandidateMap());
			modelBuilder.Configurations.Add(new vJobCandidateEducationMap());
			modelBuilder.Configurations.Add(new vJobCandidateEmploymentMap());
			modelBuilder.Configurations.Add(new vAdditionalContactInfoMap());
			modelBuilder.Configurations.Add(new vStateProvinceCountryRegionMap());
			modelBuilder.Configurations.Add(new vProductAndDescriptionMap());
			modelBuilder.Configurations.Add(new vProductModelCatalogDescriptionMap());
			modelBuilder.Configurations.Add(new vProductModelInstructionMap());
			modelBuilder.Configurations.Add(new vVendorMap());
			modelBuilder.Configurations.Add(new vIndividualCustomerMap());
			modelBuilder.Configurations.Add(new vIndividualDemographicMap());
			modelBuilder.Configurations.Add(new vSalesPersonMap());
			modelBuilder.Configurations.Add(new vSalesPersonSalesByFiscalYearMap());
			modelBuilder.Configurations.Add(new vStoreWithDemographicMap());
		}

	    public IQueryable<T> AsQueryable<T>() where T : class
	    {
	        return this.Set<T>();
	    }
	}
}

