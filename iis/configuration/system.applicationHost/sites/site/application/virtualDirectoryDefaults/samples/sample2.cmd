appcmd.exe set config -section:system.applicationHost/sites "/[name='Default Web Site'].[path='/MyApp'].virtualDirectoryDefaults.logonMethod:Network" /commit:apphost