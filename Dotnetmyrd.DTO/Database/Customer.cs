using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dotnetmyrd.DTO.Database
{
    public class Customer
    {
        //CustomerID nchar(5)    Unchecked
        //CompanyName nvarchar(40)    Unchecked
        //ContactName nvarchar(30)    Checked
        //ContactTitle    nvarchar(30)    Checked
        //Address nvarchar(60)    Checked
        //City    nvarchar(15)    Checked
        //Region  nvarchar(15)    Checked
        //PostalCode  nvarchar(10)    Checked
        //Country nvarchar(15)    Checked
        //Phone   nvarchar(24)    Checked
        //Fax nvarchar(24)    Checked
        [Required]
        [StringLength(5, ErrorMessage = "Value is out of range!")]
        public string CustomerID { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Value is out of range!")]
        public string CompanyName { get; set; }
        [StringLength(30, ErrorMessage = "Value is out of range!")]
        public string ContactName { get; set; }
        [StringLength(30, ErrorMessage = "Value is out of range!")]
        public string ContactTitle { get; set; }
        [StringLength(60, ErrorMessage = "Value is out of range!")]
        public string Address { get; set; }
        [StringLength(15, ErrorMessage = "Value is out of range!")]
        public string City { get; set; }
        [StringLength(15, ErrorMessage = "Value is out of range!")]
        public string Region { get; set; }
        [StringLength(10, ErrorMessage = "Value is out of range!")]
        public string PostalCode { get; set; }
        [StringLength(15, ErrorMessage = "Value is out of range!")]
        public string Country { get; set; }
        [StringLength(24, ErrorMessage = "Value is out of range!")]
        public string Phone { get; set; }
        [StringLength(24, ErrorMessage = "Value is out of range!")]
        public string Fax { get; set; }

    }
}
