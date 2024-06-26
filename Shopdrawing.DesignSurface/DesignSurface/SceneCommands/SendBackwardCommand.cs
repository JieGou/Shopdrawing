﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.SceneCommands.SendBackwardCommand
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface;
using Microsoft.Expression.DesignSurface.ViewModel;

namespace Microsoft.Expression.DesignSurface.SceneCommands
{
  internal sealed class SendBackwardCommand : BaseZOrderCommand
  {
    protected override string UndoDescription
    {
      get
      {
        return StringTable.UndoUnitSendBackward;
      }
    }

    public SendBackwardCommand(SceneViewModel viewModel)
      : base(viewModel, true)
    {
    }

    protected override void ReorderElements(ISceneNodeCollection<SceneNode> childCollection, SceneElementCollection selectedChildren)
    {
      if (childCollection.Count == selectedChildren.Count)
        return;
      for (int index = 0; index < selectedChildren.Count; ++index)
      {
        SceneElement sceneElement = selectedChildren[index];
        int num = childCollection.IndexOf((SceneNode) sceneElement);
        if (num > 0 && !selectedChildren.Contains(childCollection[num - 1] as SceneElement))
        {
          sceneElement.Remove();
          childCollection.Insert(num - 1, (SceneNode) sceneElement);
        }
      }
    }
  }
}
