using System.Collections.Generic;

namespace Yohash.Tools
{
  public static class CollectionExtensions
  {
    public static List<T> TryAdd<T>(this List<T> list, T add)
    {
      if (list.Contains(add)) return list;
      list.Add(add);
      return list;
    }
  }
}
