﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew
{
    public class SpawnComponent : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private bool _invertXScale;

        [ContextMenu("Spawn")]
        public void Spawn()
        {
           
            var instance = Instantiate(_prefab, _target.position, Quaternion.identity);
            
            var scale = _target.lossyScale;
            scale.x *= _invertXScale ? -1 : 1;
            instance.transform.localScale = scale;
            instance.SetActive(true);
        }

        
    }

}
