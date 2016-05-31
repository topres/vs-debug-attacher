// Guids.cs
// MUST match guids.h
using System;

namespace Topres.VSDebugAttacher
{
    public static class GuidList
    {
        public const string guidAttachToPkgString = "7C740628-D130-4EBB-BB77-3780A23AE520";

        public const string guidAttachToCmdSetString = "16e2ac5c-ec3d-4ff1-a237-11ccef54fe0f";

        public static readonly Guid guidAttachToCmdSet = new Guid(guidAttachToCmdSetString);
    }
}