﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Framework.PropertyInspector.IPropertyInspector
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

namespace Microsoft.Expression.Framework.PropertyInspector
{
  public interface IPropertyInspector
  {
    bool IsCategoryExpanded(string categoryName);

    void UpdateTransaction();
  }
}