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
