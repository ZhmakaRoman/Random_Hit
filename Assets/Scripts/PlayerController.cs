using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private float _speed;
  [SerializeField] private float _speedChangeValue = 0.1f;
  private Animator _animator;
  private static readonly int Speed = Animator.StringToHash("speed");
  private static readonly int Vertical = Animator.StringToHash("vertical");

  private void Awake()
  {
    _animator = GetComponent<Animator>();
  }

  private void Update()
  {
  
    var vertical = Input.GetAxis("Vertical");

    if (Input.GetMouseButtonDown(0))
    {
      _animator.SetTrigger("attack");
   }
    _animator.SetFloat(Speed,vertical);
   
  
  }
}
