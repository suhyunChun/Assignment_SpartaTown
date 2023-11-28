using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookController : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Start(){
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection){
        FlipCharacter(newAimDirection);
    }

    private void FlipCharacter(Vector2 direction){
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
