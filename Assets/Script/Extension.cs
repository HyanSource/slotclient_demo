using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyanExtension
{
    public static class Extension
    {
        /// <summary>
        /// 組合為字串的方法
        /// </summary>
        public static string CollectionToString<T>(this IEnumerable<T> c, string s = ",")
        {
            return string.Join(s, c);
        }
    }
}

