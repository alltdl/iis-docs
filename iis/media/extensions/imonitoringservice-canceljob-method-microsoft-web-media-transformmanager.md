﻿---
title: IMonitoringService.CancelJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.canceljob(v=VS.90)
ms:contentKeyID: 35520775
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CancelJob Method

Cancels a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
FunctionCancelJob ( _
    jobDetailsAsJobDetails _
) AsJobStatus
'Usage
DiminstanceAsIMonitoringServiceDimjobDetailsAsJobDetailsDimreturnValueAsJobStatusreturnValue = instance.CancelJob(jobDetails)
```

``` csharp
[OperationContractAttribute]
JobStatusCancelJob(
    JobDetailsjobDetails
)
```

``` c++
[OperationContractAttribute]
JobStatusCancelJob(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstractCancelJob : 
        jobDetails:JobDetails->JobStatus
```

``` jscript
functionCancelJob(
    jobDetails : JobDetails
) : JobStatus
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job to cancel and the work queue name that the job is in.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the action.  

## Remarks

The job can be canceled when it is either running or queued (submitted but not yet started). The method will usually return "Cancelled", but other possible values are "Finished" and "Failed". These other return values can occur if the job reaches these states before the cancel command reaches the scheduler.

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
