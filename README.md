# Unity_IOUtility

``IOUtility.cs`` provides some functions to iterate files.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_IOUtility.git?path=Assets/Packages/IOUtility
```

## Functions

```csharp
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
```