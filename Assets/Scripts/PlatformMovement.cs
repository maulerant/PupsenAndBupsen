using System;
using TMPro.EditorUtilities;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private AnimationCurve _Curve;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private float _deltaTime = 0f;

    // private Rigidbody2D _rb;

    private void Start()
    {
        // _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _deltaTime += Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(
            _startPoint.position.x + (_endPoint.position.x - _startPoint.position.x) * _Curve.Evaluate(_deltaTime),
            _startPoint.position.y + (_endPoint.position.y - _startPoint.position.y) * _Curve.Evaluate(_deltaTime)
        ), 1); 
        // _rb.MovePosition(new Vector2(
        //         _startPoint.position.x  + (_endPoint.position.x - _startPoint.position.x)  * _xCurve.Evaluate(_deltaTime),
        //         _startPoint.position.y + (_endPoint.position.y - _startPoint.position.y)  * _yCurve.Evaluate(_deltaTime)  
        //     )
        // );
    }
}