using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetSocketInteractor : XRSocketInteractor
{
    [SerializeField]
    private GameObject highlightObject;

    private GameObject highlightedInstance;
    
    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        highlightedInstance ??= Instantiate(highlightObject);
        highlightedInstance.SetActive(true);
        highlightedInstance.transform.position = transform.position;
        highlightedInstance.transform.rotation = transform.rotation;
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        highlightedInstance?.SetActive(false);
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        var angle = args.interactableObject.transform.rotation.eulerAngles;
        angle.y = Mathf.RoundToInt(angle.y / 90f) * 90f;
        attachTransform.localRotation = Quaternion.Euler(0,angle.y,0);
        base.OnSelectEntered(args);
    }
}
