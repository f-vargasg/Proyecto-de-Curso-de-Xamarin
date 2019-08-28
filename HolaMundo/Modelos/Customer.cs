using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMundo.Modelos
{
    [Table("Customers")]
    public class Customer
    {
        [PrimaryKey, Column("Id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "companyName")]
        [Column(nameof(CompanyName)), NotNull]
        public string CompanyName { get; set; }
        [JsonProperty(PropertyName = "contactName")]
        [Column(nameof(ContactName)), NotNull]
        public string ContactName { get; set; }
        [Column(nameof(ContactTitle)), NotNull]
        public string ContactTitle { get; set; }
        [Column(nameof(Address)), NotNull]
        public string Address { get; set; }
        [Column(nameof(City)), NotNull]
        public string City { get; set; }
        [Column(nameof(PostalCode)), NotNull]
        public string PostalCode { get; set; }
        [Column(nameof(Country)), NotNull]
        public string Country { get; set; }
        [Column(nameof(Phone)), NotNull]
        public string Phone { get; set; }
        [Column(nameof(Fax)), NotNull]
        public string Fax { get; set; }
    }
}
