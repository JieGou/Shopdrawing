﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Utility.IO.StaAccessService
// Assembly: Microsoft.Expression.Utility, Version=5.0.30709.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: B77F0E80-A3D7-4861-BF76-6A6A586443F3
// Assembly location: C:\Users\M4600\Documents\Project\4.5\Microsoft.Expression.ProjectReferences\Microsoft.Expression.Utility.dll

using Microsoft.Expression.Utility.Interop;
using System.Windows.Input;

namespace Microsoft.Expression.Utility.IO
{
  internal sealed class StaAccessService : IStaAccessService
  {
    public bool IsKeyDown(Key key)
    {
      return ((int) UnsafeNativeMethods.GetKeyState(KeyInterop.VirtualKeyFromKey(key)) & 32768) == 32768;
    }
  }
}
