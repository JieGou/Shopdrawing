﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector.MaterialsCategoryEditor
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface;
using Microsoft.Expression.DesignSurface.Properties;
using Microsoft.Windows.Design.PropertyEditing;
using System.Windows;

namespace Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector
{
  internal class MaterialsCategoryEditor : SceneNodeCategoryEditor
  {
    public override string TargetCategory
    {
      get
      {
        return CategoryLocalizationHelper.GetLocalizedCategoryName(CategoryLocalizationHelper.CategoryName.Materials);
      }
    }

    public override DataTemplate EditorTemplate
    {
      get
      {
        return new DataTemplate();
      }
    }

    public override bool ConsumesProperty(PropertyEntry property)
    {
      return false;
    }

    public override object GetImage(Size desiredSize)
    {
      return (object) FileTable.GetImageSource("Resources\\Icons\\Categories\\pane_materials_24x24_off.png");
    }

    public override object GetHighlightedImage(Size size)
    {
      return (object) FileTable.GetImageSource("Resources\\Icons\\Categories\\pane_materials_24x24_on.png");
    }
  }
}
