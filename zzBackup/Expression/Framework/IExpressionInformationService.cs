﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Framework.IExpressionInformationService
// Assembly: Microsoft.Expression.Framework, Version=4.0.1000.1000, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 1CFB9CAE-EE8F-44DB-B6AB-EAABBC8A4B40
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Framework.dll

using System;
using System.Windows;

namespace Microsoft.Expression.Framework
{
  public interface IExpressionInformationService
  {
    Version Version { get; }

    string LongApplicationName { get; }

    string ShortApplicationName { get; }

    FrameworkElement MainWindowRootElement { get; set; }

    string DefaultDialogTitle { get; }

    string PoliciesRegistryPath { get; }

    string VersionedPoliciesRegistryPath { get; }

    string RegistryPath { get; }

    string VersionedRegistryPath { get; }

    bool IsReleaseVersion { get; }

    bool DiagnosticMode { get; }
  }
}
