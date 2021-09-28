﻿using System.Collections;
using UnityEngine;

namespace PixelCrew.Utils
{
    public static class GameObjectExtension
    {

        public static bool IsInLayer(this GameObject go, LayerMask layer)
        {
            return layer == (layer | 1 << go.layer);
        }

        public static TInterfaceType GetInterface<TInterfaceType>(this GameObject go)
        {
            var components = go.GetComponents<Component>();
            foreach (var component in components)
            {
                if (components is TInterfaceType type)
                {
                    return type;
                }
            }

            return default;
        }
    }
}