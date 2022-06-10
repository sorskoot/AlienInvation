using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARMeshManager))]
public class DisableARMeshOnPlaced : GameStateBase
{
    private    ARMeshManager MeshManager { get; set; }
    
    void Start()
    {
        this.MeshManager = GetComponent<ARMeshManager>();
        GameStateService.IsPlaced.Subscribe(OnIsPlacedChange).AddTo(this);
    }

    private void OnIsPlacedChange(bool isPlaced)
    {
        if (isPlaced)
        {
            MeshManager.DestroyAllMeshes();
            MeshManager.enabled = false;
        }
    }
}
