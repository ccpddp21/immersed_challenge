using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private float _yawAngle;
    [SerializeField] private float _pitchAngle;
    [SerializeField] private float _sensitivity = 3;
    private float _yawValue, _pitchValue;

    void Awake()
    {
        if (_playerCamera == null)
        {
            _playerCamera = this.GetComponentInChildren<Camera>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _yawAngle = _pitchAngle = 30;
    }

    // Update is called once per frame
    void Update()
    {
        _yawValue = Input.GetAxis("Yaw");
        _pitchValue = Input.GetAxis("Pitch");

        if (_yawValue != 0)
        {
            this.transform.Rotate(new Vector3(0, 1, 0) * _yawAngle * _yawValue * Time.deltaTime * _sensitivity);
        }

        if (_pitchValue != 0)
        {
            _playerCamera.transform.Rotate(new Vector3(1, 0, 0) * _pitchAngle * _pitchValue * Time.deltaTime * _sensitivity);
        }
    }
}
