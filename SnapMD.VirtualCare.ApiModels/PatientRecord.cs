using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents Patient Record.
    /// </summary>
    public class PatientRecord
    {
        /// <summary>
        /// Get or set the Height
        /// </summary>
        /// <value>
        /// Height
        /// </value>
        public string Height { get; set; }

        /// <summary>
        /// Get or set the Weight
        /// </summary>
        /// <value>
        /// Weight
        /// </value>
        public string Weight { get; set; }

        /// <summary>
        /// Get or set the HeightUnit
        /// </summary>
        /// <value>
        /// HeightUnit
        /// </value>
        public string HeightUnit { get; set; }

        /// <summary>
        /// Get or set the WeightUnit
        /// </summary>
        /// <value>
        /// WeightUnit
        /// </value>
        public string WeightUnit { get; set; }

        /// <summary>
        /// Get or set the Address
        /// </summary>
        /// <value>
        /// Address
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Get or set the AddressObject
        /// </summary>
        /// <value>
        ///    Line 1
        ///    Line 2
        ///    City 
        ///    State
        ///    StateCode
        ///    PostalCode
        ///    Country
        ///    CountryCode
        ///    AddressText
        /// </value>
        public AddressObject AddressObject { get; set; }

        /// <summary>
        /// Get or set the HomePhone
        /// </summary>
        /// <value>
        /// HomePhone
        /// </value>
        public string HomePhone { get; set; }

        /// <summary>
        /// Get or set the MobilePhone
        /// </summary>
        /// <value>
        /// MobilePhone
        /// </value>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Get or set the Dob
        /// </summary>
        /// <value>
        /// Dob
        /// </value>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Get or set the Organization Name
        /// </summary>
        /// <value>
        /// OrganizationName
        /// </value>
        public string OrganizationName { get; set; }


        /// <summary>
        /// Get or set the Location Name
        /// </summary>
        /// <value>
        /// LocationName
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Get or set the FirstName
        /// </summary>
        /// <value>
        /// FirstName
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Get or set the LastName
        /// </summary>
        /// <value>
        /// LastName
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Get or set the Profile Image Path
        /// </summary>
        /// <value>
        /// ProfileImagePath
        /// </value>
        public string ProfileImagePath { get; set; }
    }
}
