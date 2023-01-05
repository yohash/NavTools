using System.Collections.Generic;

namespace Yohash.Tools
{
  public static class DictionaryExtensions
  {
    public static V TryGetOrDefault<K, V>(this Dictionary<K, V> d, K key, V defaultValue = default(V))
    {
      return d.ContainsKey(key) ? d[key] : defaultValue;
    }

    public static string Serialize<K, V>(this Dictionary<K, V> d)
    {
      string s = d.GetType().ToString() + "\n";
      foreach (var kvp in d) {
        s += "\t" + kvp.Key.ToString() + " : " + kvp.Value.ToString() + "\n";
      }
      return s;
    }
  }
}
