﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.VisualStudio.PlatformUI.Shell.Controls.AutoHideHwndContentControl
// Assembly: Microsoft.Expression.Framework, Version=4.0.1000.1000, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 1CFB9CAE-EE8F-44DB-B6AB-EAABBC8A4B40
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Framework.dll

using System.Windows.Automation.Peers;
using System.Windows.Media;

namespace Microsoft.VisualStudio.PlatformUI.Shell.Controls
{
  public class AutoHideHwndContentControl : HwndContentControl
  {
    protected override AutomationPeer OnCreateAutomationPeer()
    {
      return (AutomationPeer) new AutoHideHwndContentControlAutomationPeer((HwndContentControl) this, (Visual) this.HwndSourcePresenter);
    }
  }
}
