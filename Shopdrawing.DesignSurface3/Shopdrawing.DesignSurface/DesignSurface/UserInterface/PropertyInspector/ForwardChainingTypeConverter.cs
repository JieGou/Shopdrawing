﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector.ForwardChainingTypeConverter
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using System;
using System.Globalization;
using System.Windows.Data;

namespace Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector
{
  public class ForwardChainingTypeConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (object) (ForwardChainingType) ((bool) value ? 1 : 0);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (object) (bool) ((ForwardChainingType) value == ForwardChainingType.Or ? 1 : 0);
    }
  }
}
