﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector.LightCategoryEditorFactory
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignModel.Metadata;
using Microsoft.Windows.Design.PropertyEditing;
using System.Collections.Generic;

namespace Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector
{
  public sealed class LightCategoryEditorFactory : BuiltInCategoryEditorFactory
  {
    protected override ITypeId EditableType
    {
      get
      {
        return PlatformTypes.Light;
      }
    }

    protected override IEnumerable<CategoryEditor> GetCategoryEditors()
    {
      return (IEnumerable<CategoryEditor>) new CategoryEditor[1]
      {
        (CategoryEditor) new LightCategoryEditor()
      };
    }
  }
}
