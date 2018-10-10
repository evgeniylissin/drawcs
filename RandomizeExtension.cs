// Decompiled with JetBrains decompiler
// Type: Draw.RandomizeExtension
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.Collections.Generic;

namespace Draw
{
  internal static class RandomizeExtension
  {
    private static readonly Random Random = new Random();

    public static void Shuffle<T>(this IList<T> list)
    {
      int count = list.Count;
      while (count > 1)
      {
        --count;
        int index = RandomizeExtension.Random.Next(count + 1);
        T obj = list[index];
        list[index] = list[count];
        list[count] = obj;
      }
    }
  }
}
