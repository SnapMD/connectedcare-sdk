using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Standard types for FHIR identifier datatype.
    /// </summary>
    /// <remarks>
    /// See http://hl7.org/fhir/valueset-identifier-type.html.<br/>
    /// Enum constant names (except None) are intentionally uppercase, so ToString() and Parse() methods correctly 
    /// represent case-sensitive FHIR codes.
    /// </remarks>
    public enum IdentifierTypeCode
    {
        /// <summary>
        ///  Identifier device is None.
        /// </summary>
        None = 0,

        /// <summary>Universal Device Identifier</summary>
        /// <remarks>
        /// A identifier assigned to a device using the Universal Device Identifier framework as defined by FDA (http://www.fda.gov/MedicalDevices/DeviceRegulationandGuidance/UniqueDeviceIdentification/).
        /// </remarks>
        UDI = 1,

        /// <summary>Serial Number</summary>
        /// <remarks>
        /// An identifier affixed to an item by the manufacturer when it is first made, where each item has a different identifier.
        /// </remarks>
        SNO = 2,

        /// <summary>Social Beneficiary Identifier</summary>
        /// <remarks>
        /// An identifier issued by a governmental organization to an individual for the purpose of the receipt of social services and benefits.
        /// </remarks>
        SB = 3,

        /// <summary>Placer Identifier</summary>
        /// <remarks>
        /// The identifier associated with the person or service that requests or places an order.
        /// </remarks>
        PLAC = 4,

        /// <summary>Filler Identifier</summary>
        /// <remarks>
        /// The Identifier associated with the person, or service, who produces the observations or fulfills the order requested by the requestor.
        /// </remarks>
        FILL = 5,

        /// <summary>Accession ID</summary>
        /// <remarks>
        /// Accession Identifier
        /// </remarks>
        ACSN = 100,

        /// <summary>American Express</summary>
        /// <remarks>
        /// Deprecated and replaced by BC in v 2.5.
        /// </remarks>
        AM = 101,

        /// <summary>American Medical Association Number</summary>
        /// <remarks>
        /// A physician identifier assigned by the AMA.
        /// </remarks>
        AMA = 102,

        /// <summary>Account number</summary>
        /// <remarks>
        /// An identifier that is unique to an account.
        /// </remarks>
        AN = 103,

        /// <summary>Account number Creditor</summary>
        /// <remarks>
        /// Class: Financial&lt;p&gt;A more precise definition of an account number: sometimes two distinct account numbers must be transmitted in the same message, one as the creditor, the other as the debitor.&lt;p&gt;Kreditorenkontonummer
        /// </remarks>
        ANC = 104,

        /// <summary>Account number debitor</summary>
        /// <remarks>
        /// Class: Financial&lt;p&gt;A more precise definition of an account number: sometimes two distinct account numbers must be transmitted in the same message, one as the creditor, the other as the debitor.&lt;p&gt;Debitorenkontonummer
        /// </remarks>
        AND = 105,

        /// <summary>Anonymous identifier</summary>
        /// <remarks>
        /// An identifier for a living subject whose real identity is protected or suppressed&lt;p&gt;Justification: For public health reporting purposes, anonymous identifiers are occasionally used for protecting patient identity in reporting certain results. For instance
        /// </remarks>
        ANON = 106,

        /// <summary>Temporary Account Number</summary>
        /// <remarks>
        /// Class: Financial&lt;p&gt;Temporary version of an Account Number.&lt;p&gt;Use Case: An ancillary system that does not normally assign account numbers is the first time to register a patient. This ancillary system will generate a temporary account number that will only
        /// </remarks>
        ANT = 107,

        /// <summary>Advanced Practice Registered Nurse number</summary>
        /// <remarks>
        /// An identifier that is unique to an advanced practice registered nurse within the jurisdiction of a certifying board
        /// </remarks>
        APRN = 108,

        /// <summary>Ancestor Specimen ID</summary>
        /// <remarks>
        /// A unique identifier for the ancestor specimen. All child, grandchild, etc. specimens of the ancestor specimen share the same Ancestor Specimen ID.
        /// </remarks>
        ASID = 109,

        /// <summary>Bank Account Number</summary>
        /// <remarks>
        /// Class: Financial
        /// </remarks>
        BA = 110,

        /// <summary>Bank Card Number</summary>
        /// <remarks>
        /// Class: Financial&lt;p&gt;An identifier that is unique to a person's bank card. Replaces AM, DI, DS, MS, and VS beginning in v 2.5.
        /// </remarks>
        BC = 111,

        /// <summary>Birth Certificate</summary>
        /// <remarks>
        /// A number associated with a document identifying the event of a person's birth.
        /// </remarks>
        BCT = 112,

        /// <summary>Birth registry number</summary>
        /// <remarks>
        /// An identifier unique within the Assigning Authority that is the official legal record of a person's birth.
        /// </remarks>
        BR = 113,

        /// <summary>Breed Registry Number</summary>
        BRN = 114,

        /// <summary>Primary physician office number</summary>
        /// <remarks>
        /// Betriebsstättennummer - for use in the German realm.
        /// </remarks>
        BSNR = 115,

        /// <summary>Cost Center number</summary>
        /// <remarks>
        /// Class: Financial&lt;p&gt;Use Case: needed especially for transmitting information about invoices.
        /// </remarks>
        CC = 116,

        /// <summary>Change of Name Document</summary>
        /// <remarks>
        /// A number associated with a document identifying a person's legal change of name.
        /// </remarks>
        CONM = 117,

        /// <summary>County number</summary>
        CY = 118,

        /// <summary>Citizenship Card</summary>
        /// <remarks>
        /// A number assigned by a person's country of residence to identify a person's citizenship.
        /// </remarks>
        CZ = 119,

        /// <summary>Dentist license number</summary>
        /// <remarks>
        /// An identifier that is unique to a dentist within the jurisdiction of the licensing board
        /// </remarks>
        DDS = 120,

        /// <summary>Drug Enforcement Administration registration number</summary>
        /// <remarks>
        /// An identifier for an individual or organization relative to controlled substance regulation and transactions.&lt;p&gt;Use case: This is a registration number that identifies an individual or organization relative to controlled substance regulation and transacti
        /// </remarks>
        DEA = 121,

        /// <summary>Drug Furnishing or prescriptive authority Number</summary>
        /// <remarks>
        /// An identifier issued to a health care provider authorizing the person to write drug orders&lt;p&gt;Use Case: A nurse practitioner has authorization to furnish or prescribe pharmaceutical substances; this identifier is in component 1.
        /// </remarks>
        DFN = 122,

        /// <summary>Diner's Club card</summary>
        /// <remarks>
        /// Deprecated and replaced by BC in v 2.5.
        /// </remarks>
        DI = 123,

        /// <summary>Driver's license number</summary>
        DL = 124,

        /// <summary>Doctor number</summary>
        DN = 125,

        /// <summary>Osteopathic License number</summary>
        /// <remarks>
        /// An identifier that is unique to an osteopath within the jurisdiction of a licensing board.
        /// </remarks>
        DO = 126,

        /// <summary>Diplomatic Passport</summary>
        /// <remarks>
        /// A number assigned to a diplomatic passport.
        /// </remarks>
        DP = 127,

        /// <summary>Podiatrist license number</summary>
        /// <remarks>
        /// An identifier that is unique to a podiatrist within the jurisdiction of the licensing board.
        /// </remarks>
        DPM = 128,

        /// <summary>Donor Registration Number</summary>
        DR = 129,

        /// <summary>Discover Card</summary>
        /// <remarks>
        /// Deprecated and replaced by BC in v 2.5.
        /// </remarks>
        DS = 130,

        /// <summary>Employee number</summary>
        /// <remarks>
        /// A number that uniquely identifies an employee to an employer.
        /// </remarks>
        EI = 131,

        /// <summary>Employer number</summary>
        EN = 132,

        /// <summary>Staff Enterprise Number</summary>
        /// <remarks>
        /// An identifier that is unique to a staff member within an enterprise (as identified by the Assigning Authority).
        /// </remarks>
        ESN = 133,

        /// <summary>Facility ID</summary>
        FI = 134,

        /// <summary>Guarantor internal identifier</summary>
        /// <remarks>
        /// Class: Financial
        /// </remarks>
        GI = 135,

        /// <summary>General ledger number</summary>
        /// <remarks>
        /// Class: Financial
        /// </remarks>
        GL = 136,

        /// <summary>Guarantor external  identifier</summary>
        /// <remarks>
        /// Class: Financial
        /// </remarks>
        GN = 137,

        /// <summary>Health Card Number</summary>
        HC = 138,

        /// <summary>Indigenous/Aboriginal</summary>
        /// <remarks>
        /// A number assigned to a member of an indigenous or aboriginal group outside of Canada.
        /// </remarks>
        IND = 139,

        /// <summary>Jurisdictional health number (Canada)</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;2 uses: a) UK jurisdictional CHI number; b) Canadian provincial health card number:
        /// </remarks>
        JHN = 140,

        /// <summary>Laboratory Accession ID</summary>
        /// <remarks>
        /// A laboratory accession id is used in the laboratory domain. The concept of accession is used in other domains such as radiology, so the LACSN is used to distinguish a lab accession id from an radiology accession id
        /// </remarks>
        LACSN = 141,

        /// <summary>Lifelong physician number</summary>
        /// <remarks>
        /// Lebenslange Arztnummer - for use in German realm.
        /// </remarks>
        LANR = 142,

        /// <summary>Labor and industries number</summary>
        LI = 143,

        /// <summary>License number</summary>
        LN = 144,

        /// <summary>Local Registry ID</summary>
        LR = 145,

        /// <summary>Patient Medicaid number</summary>
        /// <remarks>
        /// Class: Insurance
        /// </remarks>
        MA = 146,

        /// <summary>Member Number</summary>
        /// <remarks>
        /// An identifier for the insured of an insurance policy (this insured always has a subscriber), usually assigned by the insurance carrier.&lt;p&gt;Use Case: Person is covered by an insurance policy. This person may or may not be the subscriber of the policy.
        /// </remarks>
        MB = 147,

        /// <summary>Patient's Medicare number</summary>
        /// <remarks>
        /// Class: Insurance
        /// </remarks>
        MC = 148,

        /// <summary>Practitioner Medicaid number</summary>
        /// <remarks>
        /// Class: Insurance
        /// </remarks>
        MCD = 149,

        /// <summary>Microchip Number</summary>
        MCN = 150,

        /// <summary>Practitioner Medicare number</summary>
        /// <remarks>
        /// Class: Insurance
        /// </remarks>
        MCR = 151,

        /// <summary>Marriage Certificate</summary>
        /// <remarks>
        /// A number associated with a document identifying the event of a person's marriage.
        /// </remarks>
        MCT = 152,

        /// <summary>Medical License number</summary>
        /// <remarks>
        /// An identifier that is unique to a medical doctor within the jurisdiction of a licensing board.&lt;p&gt;Use Case: These license numbers are sometimes used as identifiers. In some states, the same authority issues all three identifiers, e.g. medical, osteopathic
        /// </remarks>
        MD = 153,

        /// <summary>Military ID number</summary>
        /// <remarks>
        /// A number assigned to an individual who has had military duty, but is not currently on active duty. The number is assigned by the DOD or Veterans' Affairs (VA).
        /// </remarks>
        MI = 154,

        /// <summary>Medical record number</summary>
        /// <remarks>
        /// An identifier that is unique to a patient within a set of medical records, not necessarily unique within an application.
        /// </remarks>
        MR = 155,

        /// <summary>Temporary Medical Record Number</summary>
        /// <remarks>
        /// Temporary version of a Medical Record Number&lt;p&gt;Use Case: An ancillary system that does not normally assign medical record numbers is the first time to register a patient. This ancillary system will generate a temporary medical record number that will only
        /// </remarks>
        MRT = 156,

        /// <summary>MasterCard</summary>
        /// <remarks>
        /// Deprecated and replaced by BC in v 2.5.
        /// </remarks>
        MS = 157,

        /// <summary>Secondary physician office number</summary>
        /// <remarks>
        /// Nebenbetriebsstättennummer - for use in the German realm.
        /// </remarks>
        NBSNR = 158,

        /// <summary>Naturalization Certificate</summary>
        /// <remarks>
        /// A number associated with a document identifying a person's retention of citizenship in a particular country.
        /// </remarks>
        NCT = 159,

        /// <summary>National employer identifier</summary>
        /// <remarks>
        /// In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions.
        /// </remarks>
        NE = 160,

        /// <summary>National Health Plan Identifier</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;Used for the UK NHS national identifier.&lt;p&gt;In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions.
        /// </remarks>
        NH = 161,

        /// <summary>National unique individual identifier</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions.
        /// </remarks>
        NI = 162,

        /// <summary>National Insurance Organization Identifier</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;In Germany a national identifier for an insurance company. It is printed on the insurance card (health card). It is not to be confused with the health card number itself.&lt;p&gt;Krankenkassen-ID der KV-Karte
        /// </remarks>
        NII = 163,

        /// <summary>National Insurance Payor Identifier (Payor)</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;In Germany the insurance identifier addressed as the payor.&lt;p&gt;Krankenkassen-ID des Rechnungsempfängers&lt;p&gt;Use case: a subdivision issues the card with their identifier, but the main division is going to pay the invoices.
        /// </remarks>
        NIIP = 164,

        /// <summary>Nurse practitioner number</summary>
        /// <remarks>
        /// An identifier that is unique to a nurse practitioner within the jurisdiction of a certifying board.
        /// </remarks>
        NP = 165,

        /// <summary>National provider identifier</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions.
        /// </remarks>
        NPI = 166,

        /// <summary>Optometrist license number</summary>
        /// <remarks>
        /// A number that is unique to an individual optometrist within the jurisdiction of the licensing board.
        /// </remarks>
        OD = 167,

        /// <summary>Physician Assistant number</summary>
        /// <remarks>
        /// An identifier that is unique to a physician assistant within the jurisdiction of a licensing board
        /// </remarks>
        PA = 168,

        /// <summary>Parole Card</summary>
        /// <remarks>
        /// A number identifying a person on parole.
        /// </remarks>
        PC = 169,

        /// <summary>Penitentiary/correctional institution Number</summary>
        /// <remarks>
        /// A number assigned to individual who is incarcerated.
        /// </remarks>
        PCN = 170,

        /// <summary>Living Subject Enterprise Number</summary>
        /// <remarks>
        /// An identifier that is unique to a living subject within an enterprise (as identified by the Assigning Authority).
        /// </remarks>
        PE = 171,

        /// <summary>Pension Number</summary>
        PEN = 172,

        /// <summary>Patient internal identifier</summary>
        /// <remarks>
        /// A number that is unique to a patient within an Assigning Authority.
        /// </remarks>
        PI = 173,

        /// <summary>Person number</summary>
        /// <remarks>
        /// A number that is unique to a living subject within an Assigning Authority.
        /// </remarks>
        PN = 174,

        /// <summary>Temporary Living Subject Number</summary>
        /// <remarks>
        /// Temporary version of a Lining Subject Number.
        /// </remarks>
        PNT = 175,

        /// <summary>Medicare/CMS Performing Provider Identification Number</summary>
        /// <remarks>
        /// Class:  Insurance
        /// </remarks>
        PPIN = 176,

        /// <summary>Passport number</summary>
        /// <remarks>
        /// A unique number assigned to the document affirming that a person is a citizen of the country. In the US this number is issued only by the State Department.
        /// </remarks>
        PPN = 177,

        /// <summary>Permanent Resident Card Number</summary>
        PRC = 178,

        /// <summary>Provider number</summary>
        /// <remarks>
        /// A number that is unique to an individual provider, a provider group or an organization within an Assigning Authority.&lt;p&gt;Use case: This allows PRN to represent either an individual (a nurse) or a group/organization (orthopedic surgery team).
        /// </remarks>
        PRN = 179,

        /// <summary>Patient external identifier</summary>
        PT = 180,

        /// <summary>QA number</summary>
        QA = 181,

        /// <summary>Resource identifier</summary>
        /// <remarks>
        /// A generalized resource identifier.&lt;p&gt;Use Case: An identifier type is needed to accommodate what are commonly known as resources. The resources can include human (e.g. a respiratory therapist), non-human (e.g. a companion animal), inanimate object (e.g. 
        /// </remarks>
        RI = 182,

        /// <summary>Registered Nurse Number</summary>
        /// <remarks>
        /// An identifier that is unique to a registered nurse within the jurisdiction of the licensing board.
        /// </remarks>
        RN = 183,

        /// <summary>Pharmacist license number</summary>
        /// <remarks>
        /// An identifier that is unique to a pharmacist within the jurisdiction of the licensing board.
        /// </remarks>
        RPH = 184,

        /// <summary>Railroad Retirement number</summary>
        /// <remarks>
        /// An identifier for an individual enrolled with the Railroad Retirement Administration.  Analogous to, but distinct from, a Social Security Number
        /// </remarks>
        RR = 185,

        /// <summary>Regional registry ID</summary>
        RRI = 186,

        /// <summary>Railroad Retirement Provider</summary>
        /// <remarks>
        /// Class:  Insurance
        /// </remarks>
        RRP = 187,

        /// <summary>Specimen ID</summary>
        /// <remarks>
        /// Identifier for a specimen. Used when it is not known if the specimen ID is a unique specimen ID (USID) or an ancestor ID (ASID).
        /// </remarks>
        SID = 188,

        /// <summary>State license</summary>
        SL = 189,

        /// <summary>Subscriber Number</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;An identifier for a subscriber of an insurance policy which is unique for, and usually assigned by, the insurance carrier.&lt;p&gt;Use Case: A person is the subscriber of an insurance policy. The person's family may be plan members, but are n
        /// </remarks>
        SN = 190,

        /// <summary>Study Permit</summary>
        /// <remarks>
        /// A number associated with a permit identifying a person who is a resident of a jurisdiction for the purpose of education.
        /// </remarks>
        SP = 191,

        /// <summary>State registry ID</summary>
        SR = 192,

        /// <summary>Social Security number</summary>
        SS = 193,

        /// <summary>Tax ID number</summary>
        TAX = 194,

        /// <summary>Treaty Number/ (Canada)</summary>
        /// <remarks>
        /// A number assigned to a member of an indigenous group in Canada.&lt;p&gt;Use Case: First Nation.
        /// </remarks>
        TN = 195,

        /// <summary>Temporary Permanent Resident (Canada)</summary>
        /// <remarks>
        /// A number associated with a document identifying a person's temporary permanent resident status.
        /// </remarks>
        TPR = 196,

        /// <summary>Unspecified identifier</summary>
        U = 197,

        /// <summary>Medicare/CMS (formerly HCFA)'s Universal Physician Identification numbers</summary>
        /// <remarks>
        /// Class: Insurance&lt;p&gt;An identifier for a provider within the CMS/Medicare program.  A globally unique identifier for the provider in the Medicare program.
        /// </remarks>
        UPIN = 198,

        /// <summary>Unique Specimen ID</summary>
        /// <remarks>
        /// A unique identifier for a specimen.
        /// </remarks>
        USID = 199,

        /// <summary>Visit number</summary>
        VN = 200,

        /// <summary>Visitor Permit</summary>
        /// <remarks>
        /// A number associated with a document identifying a person as a visitor of a jurisdiction or country.
        /// </remarks>
        VP = 201,

        /// <summary>VISA</summary>
        /// <remarks>
        /// Deprecated and replaced by BC in v 2.5.
        /// </remarks>
        VS = 202,

        /// <summary>WIC identifier</summary>
        WC = 203,

        /// <summary>Workers' Comp Number</summary>
        WCN = 204,

        /// <summary>Work Permit</summary>
        /// <remarks>
        /// A number associated with a permit for a person who is granted permission to work in a country for a specified time period.
        /// </remarks>
        WP = 205,

        /// <summary>
        /// Hint external id for Insurance
        /// </summary>
        HII = 206,
        /// <summary>
        /// Hint external id for EHR and Payments
        /// </summary>
        HEI = 207,
        /// <summary>
        /// Hint external id for Payments
        /// </summary>
        HPI = 208
    };
}
