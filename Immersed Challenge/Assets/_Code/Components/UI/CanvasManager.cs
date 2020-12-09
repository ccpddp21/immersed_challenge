using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public enum OwnerCamera
    {
        Active,
        Professor
    }

    [SerializeField] private OwnerCamera _ownerCamera;

    private Canvas _thisCanvas;
    private GameObject _cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        if (_thisCanvas == null)
        {
            _thisCanvas = this.GetComponent<Canvas>();
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_thisCanvas.worldCamera == null)
        {
            if (_ownerCamera == OwnerCamera.Professor)
            {
                _cameraObject = GameObject.FindGameObjectWithTag("Professor Avatar");
                if (_cameraObject != null)
                {
                    _thisCanvas.worldCamera = _cameraObject.GetComponentInChildren<Camera>();
                }
            }
            else if (_ownerCamera == OwnerCamera.Active)
            {
                _cameraObject = GameObject.FindGameObjectWithTag("Player Camera");
                if (_cameraObject != null)
                {
                    _thisCanvas.worldCamera = _cameraObject.GetComponent<Camera>();
                }
            }
        }
    }
}
