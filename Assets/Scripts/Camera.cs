using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private PlayerController _camera;

    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {
        transform.position = _camera.transform.position + _offset;
    }
}
