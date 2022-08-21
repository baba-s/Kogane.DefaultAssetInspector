using System.Collections.Generic;
using UnityEditor;

namespace Kogane
{
    [CustomEditor( typeof( DefaultAsset ) )]
    public sealed class DefaultAssetInspector : Editor
    {
        private static readonly List<IDefaultAssetInspector> m_list = new();

        private void OnEnable()
        {
            foreach ( var inspector in m_list )
            {
                inspector.OnEnable();
            }
        }

        private void OnDisable()
        {
            foreach ( var inspector in m_list )
            {
                inspector.OnDisable();
            }
        }

        public override void OnInspectorGUI()
        {
            foreach ( var inspector in m_list )
            {
                inspector.OnInspectorGUI( target );
            }
        }

        public static void Add( IDefaultAssetInspector inspector )
        {
            m_list.Add( inspector );
        }
    }
}