﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Framework.Controls.ExpressionPopup
// Assembly: Microsoft.Expression.Framework, Version=4.0.1000.1000, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 1CFB9CAE-EE8F-44DB-B6AB-EAABBC8A4B40
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Framework.dll

using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Microsoft.Expression.Framework.Controls
{
  public class ExpressionPopup : Popup
  {
    public static readonly RoutedEvent PopupOpenedEvent = EventManager.RegisterRoutedEvent("PopupOpened", RoutingStrategy.Bubble, typeof (RoutedEventHandler), typeof (ExpressionPopup));
    public static readonly RoutedEvent PopupClosedEvent = EventManager.RegisterRoutedEvent("PopupClosed", RoutingStrategy.Bubble, typeof (RoutedEventHandler), typeof (ExpressionPopup));

    protected override void OnOpened(EventArgs e)
    {
      this.RaiseEvent(new RoutedEventArgs(ExpressionPopup.PopupOpenedEvent, (object) this));
      base.OnOpened(e);
    }

    protected override void OnClosed(EventArgs e)
    {
      this.RaiseEvent(new RoutedEventArgs(ExpressionPopup.PopupClosedEvent, (object) this));
      base.OnClosed(e);
    }
  }
}
