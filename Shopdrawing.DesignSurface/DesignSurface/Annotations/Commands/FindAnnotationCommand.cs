﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Annotations.Commands.FindAnnotationCommand
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface.View;

namespace Microsoft.Expression.DesignSurface.Annotations.Commands
{
  internal class FindAnnotationCommand : AnnotationsManipulationCommand
  {
    public FindAnnotationCommand(SceneView view)
      : base(view)
    {
    }

    public override void Execute()
    {
      FindAnnotationDialog.ShowAndActivate(this.SceneView.DesignerContext);
    }
  }
}
