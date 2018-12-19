﻿---
title: JobDetails.TaskCount Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskCount Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.TaskCount
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.taskcount(v=VS.90)
ms:contentKeyID: 35521181
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_TaskCount
- Microsoft.Web.Media.TransformManager.JobDetails.TaskCount
- Microsoft.Web.Media.TransformManager.JobDetails.get_TaskCount
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_TaskCount
- Microsoft.Web.Media.TransformManager.JobDetails.set_TaskCount
- Microsoft.Web.Media.TransformManager.JobDetails.TaskCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskCount Property

Gets or sets the number of tasks that are in this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyTaskCountAsIntegerGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsIntegervalue = instance.TaskCount

instance.TaskCount = value
```

``` csharp
[DataMemberAttribute]
publicintTaskCount { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintTaskCount {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberTaskCount : intwithget, set
```

``` jscript
function getTaskCount () : intfunction setTaskCount (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The number of tasks that are in this job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
