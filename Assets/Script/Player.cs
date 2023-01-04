using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 _target;
    private NavMeshAgent _agent;
    private Animator _animator;
    private Vector2 _stuckDistanceCheck;
    

    private void Start()
    {
        _target = transform.position;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            
        }

        _agent.SetDestination(new Vector3(_target.x, _target.y, transform.position.z));

        UpdateAnimation();

    }
    
    

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;

        _animator = GetComponent<Animator>();
    }
    
    private void UpdateAnimation()
    {
        float distance = Vector2.Distance(transform.position, _target);
        if (Vector2.Distance(_stuckDistanceCheck,transform.position) == 0) {_animator.SetFloat("Distance",0f); return;} 
        {
            
        }
        _animator.SetFloat("Distance",distance);
        if (distance > 0.01f)
        {
            Vector3 direction = transform.position - new Vector3(_target.x,_target.y,transform.position.z);
            float angle = Mathf.Atan2(direction.x,direction.y) * Mathf.Rad2Deg;
            _animator.SetFloat("Angle",angle);
            _stuckDistanceCheck = transform.position;
        }
        
    }
}
