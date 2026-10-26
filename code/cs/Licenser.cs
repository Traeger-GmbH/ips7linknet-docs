// DOC
IPS7LnkNet.Advanced.Licenser.LicenseKey = "<insert your license code here>";

// DOC
ILicenseInfo license = IPS7LnkNet.Advanced.Licenser.LicenseInfo;
 
if (license.IsExpired)
    Console.WriteLine("The IP S7 LINK SDK license is expired!");


// DOC
#if DEBUG
    IPS7LnkNet.Advanced.Licenser.FailIfUnlicensed();
#else
    IPS7LnkNet.Advanced.Licenser.ThrowIfUnlicensed();
#endif

// DOC
IPS7Lnk.Advanced.Licenser.LicenseKey = "<insert your license code here>";

// DOC
IPS7Lnk.ILicenseInfo license = IPS7Lnk.Advanced.Licenser.LicenseInfo;
 
if (license.IsExpired)
    Console.WriteLine("The license has expired.");

// DOC
#if DEBUG
    IPS7Lnk.Advanced.Licenser.FailIfUnlicensed();
#else
    IPS7Lnk.Advanced.Licenser.ThrowIfUnlicensed();
#endif
