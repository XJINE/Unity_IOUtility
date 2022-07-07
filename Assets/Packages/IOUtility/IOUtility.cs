using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class IOUtility
{
    public static IEnumerable<FileInfo> GetFilesFromAssets(string dir = "", SearchOption option = SearchOption.AllDirectories)
    {
        return GetFiles((Path.Combine(Application.dataPath, dir)));
    }

    public static IEnumerable<FileInfo> GetFilesFromStreamingAssets(string dir = "", SearchOption option = SearchOption.AllDirectories)
    {
        return GetFiles((Path.Combine(Application.streamingAssetsPath, dir)));
    }

    public static IEnumerable<FileInfo> GetFiles(string dir, SearchOption option = SearchOption.AllDirectories)
    {
        return new DirectoryInfo(dir).EnumerateFiles("*", option);
    }
}