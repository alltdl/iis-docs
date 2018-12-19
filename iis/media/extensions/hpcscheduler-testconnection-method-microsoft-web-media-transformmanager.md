﻿---
title: HpcScheduler.TestConnection Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnection Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.testconnection(v=VS.90)
ms:contentKeyID: 35521110
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TestConnection Method

Tests connectivity of the IIS Transform Manager service to the [HpcScheduler](hpcscheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubTestConnection ( _
    connectionObjectAsObject _
)
'Usage
DiminstanceAsHpcSchedulerDimconnectionObjectAsObject

instance.TestConnection(connectionObject)
```

``` csharp
publicvoidTestConnection(
    ObjectconnectionObject
)
```

``` c++
public:
voidTestConnection(
    Object^ connectionObject
)
```

``` fsharp
memberTestConnection : 
        connectionObject:Object->unit
```

``` jscript
publicfunctionTestConnection(
    connectionObject : Object
)
```

#### Parameters

  - connectionObject  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    An object that contains connection details.  

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
