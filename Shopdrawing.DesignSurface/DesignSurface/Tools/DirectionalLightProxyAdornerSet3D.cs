﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Tools.DirectionalLightProxyAdornerSet3D
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface.UserInterface;
using Microsoft.Expression.DesignSurface.ViewModel;

namespace Microsoft.Expression.DesignSurface.Tools
{
  internal class DirectionalLightProxyAdornerSet3D : AdornerSet3D
  {
    private Adorner3D adorner;

    public DirectionalLightProxyAdornerSet3D(ToolBehaviorContext toolContext, Base3DElement adornedElement)
      : base(toolContext, adornedElement)
    {
      this.CreateAdorners();
    }

    protected override void CreateAdorners()
    {
      this.adorner = (Adorner3D) new DirectionalLightProxy3D((AdornerSet3D) this);
      this.AddAdorner(this.adorner);
    }
  }
}
