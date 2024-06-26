﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Framework.Configuration.IConfigurationObjectCollection
// Assembly: Microsoft.Expression.Framework, Version=4.0.1000.1000, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 1CFB9CAE-EE8F-44DB-B6AB-EAABBC8A4B40
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Framework.dll

using System.Collections;

namespace Microsoft.Expression.Framework.Configuration
{
  public interface IConfigurationObjectCollection : ICollection, IEnumerable
  {
    IConfigurationObject this[int index] { get; set; }

    void Clear();

    void Add(IConfigurationObject value);

    void Insert(int index, IConfigurationObject value);

    void Remove(IConfigurationObject value);

    void RemoveAt(int index);
  }
}
