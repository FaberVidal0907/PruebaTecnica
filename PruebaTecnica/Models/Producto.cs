using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PruebaTecnica.Models
{
    public class _0
    {
        public List<object> DeliverySlaPerTypes { get; set; }
        public object Region { get; set; }
    }

    public class ClusterHighlights
    {
    }

    public class CommertialOffer
    {
        public DeliverySlaSamplesPerRegion DeliverySlaSamplesPerRegion { get; set; }
        public List<Installment> Installments { get; set; }
        public List<object> DiscountHighLight { get; set; }
        public List<object> GiftSkuIds { get; set; }
        public List<object> Teasers { get; set; }
        public List<object> BuyTogether { get; set; }
        public List<object> ItemMetadataAttachment { get; set; }
        public double Price { get; set; }
        public double ListPrice { get; set; }
        public double PriceWithoutDiscount { get; set; }
        public double RewardValue { get; set; }
        public DateTime PriceValidUntil { get; set; }
        public int AvailableQuantity { get; set; }
        public bool IsAvailable { get; set; }
        public double Tax { get; set; }
        public List<DeliverySlaSample> DeliverySlaSamples { get; set; }
        public string GetInfoErrorMessage { get; set; }
        public string CacheVersionUsedToCallCheckout { get; set; }
        public PaymentOptions PaymentOptions { get; set; }
    }

    public class DeliverySlaSample
    {
        public List<object> DeliverySlaPerTypes { get; set; }
        public object Region { get; set; }
    }

    public class DeliverySlaSamplesPerRegion
    {
        public _0 _0 { get; set; }
    }

    public class Image
    {
        public string imageId { get; set; }
        public object imageLabel { get; set; }
        public string imageTag { get; set; }
        public string imageUrl { get; set; }
        public string imageText { get; set; }
        public DateTime imageLastModified { get; set; }
    }

    public class Installment
    {
        public double Value { get; set; }
        public double? InterestRate { get; set; }
        public double TotalValuePlusInterestRate { get; set; }
        public int NumberOfInstallments { get; set; }
        public string PaymentSystemName { get; set; }
        public string PaymentSystemGroupName { get; set; }
        public string Name { get; set; }
    }

    public class Installment2
    {
        public int count { get; set; }
        public bool? hasInterestRate { get; set; }
        public int? interestRate { get; set; }
        public int value { get; set; }
        public int total { get; set; }
        public List<SellerMerchantInstallment> sellerMerchantInstallments { get; set; }
    }

    public class InstallmentOption
    {
        public string paymentSystem { get; set; }
        public object bin { get; set; }
        public string paymentName { get; set; }
        public string paymentGroupName { get; set; }
        public int value { get; set; }
        public List<Installment> installments { get; set; }
    }

    public class Item
    {
        public string itemId { get; set; }
        public string name { get; set; }
        public string nameComplete { get; set; }
        public string complementName { get; set; }
        public string ean { get; set; }
        public List<ReferenceId> referenceId { get; set; }
        public string measurementUnit { get; set; }
        public double unitMultiplier { get; set; }
        public object modalType { get; set; }
        public bool isKit { get; set; }
        public List<Image> images { get; set; }
        public List<Seller> sellers { get; set; }
        public List<object> Videos { get; set; }
        public object estimatedDateArrival { get; set; }
    }

    public class PaymentOptions
    {
        public List<InstallmentOption> installmentOptions { get; set; }
        public List<PaymentSystem> paymentSystems { get; set; }
        public List<object> payments { get; set; }
        public List<object> giftCards { get; set; }
        public List<object> giftCardMessages { get; set; }
        public List<object> availableAccounts { get; set; }
        public List<object> availableTokens { get; set; }
    }

    public class PaymentSystem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string groupName { get; set; }
        public object validator { get; set; }
        public string stringId { get; set; }
        public string template { get; set; }
        public bool requiresDocument { get; set; }
        public bool isCustom { get; set; }
        public string description { get; set; }
        public bool requiresAuthentication { get; set; }
        public DateTime dueDate { get; set; }
        public object availablePayments { get; set; }
    }

    public class ProductClusters
    {
        public string _142 { get; set; }
        public string _143 { get; set; }
    }

    public class ReferenceId
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Producto
    {
        public string productId { get; set; }
        public string productName { get; set; }
        public string brand { get; set; }
        public int brandId { get; set; }
        public object brandImageUrl { get; set; }
        public string linkText { get; set; }
        public string productReference { get; set; }
        public string productReferenceCode { get; set; }
        public string categoryId { get; set; }
        public string productTitle { get; set; }
        public string metaTagDescription { get; set; }
        public DateTime releaseDate { get; set; }
        public ClusterHighlights clusterHighlights { get; set; }
        public ProductClusters productClusters { get; set; }
        public SearchableClusters searchableClusters { get; set; }
        public List<string> categories { get; set; }
        public List<string> categoriesIds { get; set; }
        public string link { get; set; }
        public List<string> Tonalidad { get; set; }
        public List<string> Características { get; set; }

        
        public List<string> CuidadosDeLaPrenda { get; set; }
        public List<string> Contenidos { get; set; }
        public List<string> allSpecifications { get; set; }
        public List<string> allSpecificationsGroups { get; set; }
        public string description { get; set; }
        public List<Item> items { get; set; }
    }

    public class SearchableClusters
    {
    }

    public class Seller
    {
        public string sellerId { get; set; }
        public string sellerName { get; set; }
        public string addToCartLink { get; set; }
        public bool sellerDefault { get; set; }
        public CommertialOffer commertialOffer { get; set; }
    }

    public class SellerMerchantInstallment
    {
        public string id { get; set; }
        public int count { get; set; }
        public bool? hasInterestRate { get; set; }
        public int? interestRate { get; set; }
        public int value { get; set; }
        public int total { get; set; }
    }
}