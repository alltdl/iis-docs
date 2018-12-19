﻿---
title: Statistics Element
TOCTitle: Statistics Element
ms:assetid: f864df2f-3a35-4571-a312-0a716c092aaf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547075(v=VS.90)
ms:contentKeyID: 37836916
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Statistics Element

Represents the running statistics for an active Live Smooth Streaming publishing point instance.

    <Statistics>
      <InputStreams>
        <InputStream>
          <State />
          <ArchiveFileName />
          <Sources>
            <Source />
          </Sources>
          <Sinks>
            <Sink />
          </Sinks>
          <Tracks>
            <Track>
              <Name />
              <EncodedBitRate />
              <IncomingBitRate />
              <IncomingFragmentWaitTime />
              <IncomingFragmentTimeStamp />
              <IncomingFragmentDuration />
              <RequestRate />
            </Track>
          </Tracks>
        </InputStream>
      </InputStreams>
      <OutputStreams>
        <OutputStream>
          <LastOutputFragmentTimestamp />
        </OutputStream>
      </OutputStreams>
    </ Statistics>

### Child Elements

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="inputstreams-element.md">InputStreams Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="outputstreams-element.md">OutputStreams Element</a></p></td>
</tr>
</tbody>
</table>


### Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="smoothstreaming-element.md">SmoothStreaming Element</a></p></td>
</tr>
</tbody>
</table>
