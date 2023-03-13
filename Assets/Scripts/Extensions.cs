using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    static void ElementList()
    {
        List<int> list = new List<int>() { 1, 2, 3, 2, 1, 2, 3, 2, 1, 1, 2 };

        foreach (var value in list)
        {
            Debug.Log(value + " ");
        }

        Dictionary<int, int> dic = new Dictionary<int, int>();
       
        dic = F(list);
        PrintDictionary(dic);

        dic = F(list);
        PrintDictionary(dic);
    }

    static Dictionary<int, int> F(List<int> list)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (var key in list)
        {
            int value;
            if (dic.TryGetValue(key, out value))
            {                
                dic[key]++;
            }
            else
            {
                dic.Add(key, 1);
            }
        }

        return dic;
    }

    static Dictionary<object, int> F(List<object> list)
    {
        Dictionary<object, int> dic = new Dictionary<object, int>();

        foreach (var key in list)
        {
            int value;
            if (dic.TryGetValue(key, out value))
            {
                dic.Remove(key);
                dic.Add(key, ++value);
            }
            else
            {
                dic.Add(key, 1);
            }
        }

        return dic;
    }

    static void PrintDictionary(Dictionary<int, int> dic)
    {
        string result = "";
        foreach (var pair in dic)
        {
            result += ("{0} - {1}", pair.Key, pair.Value);
        }
        Debug.Log(result);
    }

    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }
}
