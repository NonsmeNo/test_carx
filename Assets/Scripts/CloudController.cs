using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [SerializeField] private Transform _cloud;
    [SerializeField] private Transform[] _points;

    [SerializeField] float _speed = 10f;
    private Vector3 _curPoint;
    private bool _isMove = false;


    public void MoveNext()
    {
        Debug.Log("Try move");
        int index = System.Array.IndexOf(_points, _curPoint);
        if (index >= 0)
        {
            index++;
            _curPoint = _points[index].position;
        }
        else
        {

        }

        _isMove = true;
    }

    // private Vector3 GetPoint(int index)
    // {
    //     var point = _points[index].
    //     return point;
    // }

    private void Update()
    {
        if (!_isMove)
        {
            return;
        }

        _cloud.position = Vector3.Lerp(_cloud.position, _curPoint, Time.deltaTime * _speed);
        //if (Vector3.Distance(_cloud.position))
    }
}

