# Kogane Default Asset Inspector

DefaultAsset の Inspector を拡張するためのパッケージ

# 使用例

```csharp
using Kogane;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
internal sealed class Example : IDefaultAssetInspector
{
    static Example()
    {
        DefaultAssetInspector.Add( new Example() );
    }

    void IDefaultAssetInspector.OnInspectorGUI( Object target )
    {
        var path     = AssetDatabase.GetAssetPath( target );
        var isFolder = AssetDatabase.IsValidFolder( path );

        if ( !isFolder ) return;

        GUILayout.Label( "フォルダです" );
    }
}
```