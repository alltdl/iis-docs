Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim directoryBrowseSection As ConfigurationSection = config.GetSection("system.webServer/directoryBrowse")
      directoryBrowseSection("enabled") = True
      directoryBrowseSection("showFlags") = "Date, Time, Size, Extension"
      serverManager.CommitChanges()
   End Sub
End Module