using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETP.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Title { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Traveler> Travelers { get; set; }
    }

    public class Traveler
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Citizenship { get; set; }
        public string BirthMonth { get; set; }
        public string BirthDay { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string ContactEmailAddress { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string TravelerPosition { get; set; }
        public string PassportCountryId { get; set; }
    }

    public class Address
    {
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string CountyStateProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string ZIPCode { get; set; }
    }

    public class Placeholders
    {
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
    }

    public class Validation
    {
        public string AddressOne { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string CountyStateProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string ZIPCode { get; set; }
    }

    public class Dropdowns
    {
        public string StoredFrequentFlyerProgram { get; set; }
    }

    public class SeatSelection
    {
        public string AnySeat { get; set; }
        public string WindowSeat { get; set; }
        public string AisleSeat { get; set; }
        public string InfantInLap { get; set; }
        public string Traveler { get; set; }
        public string Interstitial { get; set; }
        public string PreferredSeat { get; set; }
    }

    public class PaidSeats
    {
        public string Seat { get; set; }
    }

    public class PaymentTypes
    {
        public string CreditCard { get; set; }
        public string PayPal { get; set; }
        public string BillPayInvoice { get; set; }
        public string BillPayDirectDebit { get; set; }
        public string BillPayInstallments { get; set; }
        public string KlarnaPayLater { get; set; }
        public string KlarnaPayOverTime { get; set; }
        public string KlarnaPayNow { get; set; }
        public string IBP { get; set; }
        public string Bitcoin { get; set; }
        public string Alipay { get; set; }
        public string ELV { get; set; }
        public string Affirm { get; set; }
        public string ApplePay { get; set; }
        public string Paysbuy { get; set; }
        public string Default { get; set; }
    }

    public class BookingTypes
    {
        public string ReserveNow { get; set; }
        public string Reservation { get; set; }
        public string Default { get; set; }
    }

    public class Button
    {
        public PaymentTypes PaymentTypes { get; set; }
        public BookingTypes BookingTypes { get; set; }
    }

    public class ImportantInformation
    {
        public string Traveller { get; set; }
    }

    public class Insurance
    {
        public string Interstitial { get; set; }
    }

    public class Login
    {
        public string Signin { get; set; }
        public string Hello { get; set; }
        public string HelloUser { get; set; }
        public string HelloUserName { get; set; }
        public string Loading { get; set; }
        public string SigningIn { get; set; }
        public string SignInComplete { get; set; }
        public string Cancel { get; set; }
    }

    public class Points
    {
        public string Update { get; set; }
        public string UpdateComplete { get; set; }
    }

    public class MultiPage
    {
        public string Interstitial { get; set; }
    }

    public class TravelerDropdownOption
    {
        public string Default { get; set; }
        public string RecentlyAdded { get; set; }
    }

    public class MultiItem
    {
        public TravelerDropdownOption TravelerDropdownOption { get; set; }
    }

    public class Cruise
    {
        public string Interstitial { get; set; }
    }

    public class Hotels
    {
        public string DualCurrencyMessage { get; set; }
    }

    public class Fields2
    {
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PostalCode { get; set; }
    }

    public class Placeholders2
    {
        public string State { get; set; }
    }

    public class Validation2
    {
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PostalCode { get; set; }
    }

    public class HomeAddress
    {
        public Fields2 Fields { get; set; }
        public Placeholders2 Placeholders { get; set; }
        public Validation2 Validation { get; set; }
    }

    public class TravelToCuba
    {
        public HomeAddress HomeAddress { get; set; }
    }

    public class Wifi
    {
        public string Excellent { get; set; }
        public string Great { get; set; }
        public string Good { get; set; }
    }

    public class Breakfast
    {
        public string Excellent { get; set; }
        public string Great { get; set; }
        public string Good { get; set; }
    }

    public class Pool
    {
        public string Excellent { get; set; }
        public string Great { get; set; }
        public string Good { get; set; }
    }

    public class Location
    {
        public string Excellent { get; set; }
        public string Great { get; set; }
        public string Good { get; set; }
    }

    public class Parking
    {
        public string Excellent { get; set; }
        public string Great { get; set; }
        public string Good { get; set; }
    }

    public class Tags
    {
        public Wifi Wifi { get; set; }
        public Breakfast Breakfast { get; set; }
        public Pool Pool { get; set; }
        public Location Location { get; set; }
        public Parking Parking { get; set; }
        public string GuestsLoveIt { get; set; }
        public string RelatedReviews { get; set; }
    }

    public class SuperlativeAmenity
    {
        public Tags Tags { get; set; }
    }

    public class CheckoutDebitCardIncentiveMessaging
    {
        public string Variant1Messaging { get; set; }
        public string Variant2Messaging { get; set; }
    }
    
}
