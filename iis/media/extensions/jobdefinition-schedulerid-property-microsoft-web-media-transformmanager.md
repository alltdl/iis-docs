﻿---
title: JobDefinition.SchedulerId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulerid(v=VS.90)
ms:contentKeyID: 35520981
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerId Property

Gets or sets the ID of the scheduler that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertySchedulerIdAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.SchedulerId

instance.SchedulerId = value
```

``` csharp
[DataMemberAttribute]
publicstringSchedulerId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ SchedulerId {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberSchedulerId : stringwithget, set
```

``` jscript
function getSchedulerId () : Stringfunction setSchedulerId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The ID of the scheduler.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
