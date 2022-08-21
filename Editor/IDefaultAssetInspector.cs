using UnityEngine;

namespace Kogane
{
    public interface IDefaultAssetInspector
    {
        public void OnEnable() { }

        public void OnDisable() { }

        public void OnInspectorGUI( Object target ) { }
    }
}