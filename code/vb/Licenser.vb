'DOC
IPS7LnkNet.Advanced.Licenser.LicenseKey = "<insert your license code here>"

'DOC
Dim license As ILicenseInfo = IPS7LnkNet.Advanced.Licenser.LicenseInfo

If license.IsExpired Then _
    Console.WriteLine("The IP S7 LINK SDK license is expired!")


'DOC
#if DEBUG
    IPS7LnkNet.Advanced.Licenser.FailIfUnlicensed()
#else
    IPS7LnkNet.Advanced.Licenser.ThrowIfUnlicensed()
#endif
