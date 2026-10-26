'DOC
IPS7Lnk.Advanced.Licenser.LicenseKey = "<insert your license code here>"

'DOC
Dim license As IPS7Lnk.ILicenseInfo = IPS7Lnk.Advanced.Licenser.LicenseInfo

If license.IsExpired Then _
    Console.WriteLine("The IP S7 LINK SDK license is expired!")


'DOC
#If DEBUG Then
    IPS7Lnk.Advanced.Licenser.FailIfUnlicensed()
#Else
    IPS7Lnk.Advanced.Licenser.ThrowIfUnlicensed()
#End If

'DOC
IPS7Lnk.Advanced.Licenser.LicenseKey = "<insert your license code here>"

'DOC
Dim license As IPS7Lnk.ILicenseInfo = IPS7Lnk.Advanced.Licenser.LicenseInfo

If license.IsExpired Then _
    Console.WriteLine("The license has expired.")

'DOC
#If DEBUG Then
    IPS7Lnk.Advanced.Licenser.FailIfUnlicensed()
#Else
    IPS7Lnk.Advanced.Licenser.ThrowIfUnlicensed()
#End If
