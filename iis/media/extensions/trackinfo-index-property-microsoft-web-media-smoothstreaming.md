﻿---
title: TrackInfo.Index Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Index Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.index(v=VS.90)
ms:contentKeyID: 23961028
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Index
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Index
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Index Property

Gets or sets the Index property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIndexAsUInteger
'Usage
DiminstanceAsTrackInfoDimvalueAsUIntegervalue = instance.Index

instance.Index = value
```

``` csharp
publicuintIndex { get; protectedset; }
```

``` c++
public:
propertyunsigned intIndex {
    unsigned intget ();
    protected: voidset (unsigned intvalue);
}
```

``` jscript
function getIndex () : uintprotectedfunction setIndex (value : uint)
```

#### Property Value

Type: [System. . :: . .UInt32](https://msdn.microsoft.com/en-us/library/ctys3981\(v=vs.90\))  
An unsigned integer value that specifies the track index.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
