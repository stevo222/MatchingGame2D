
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableBehavior : MonoBehaviour
{

    private Camera _cameraObj;

    public bool draggable;
    public Vector3 position;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = _cameraObj.ScreenToWorldPoint(Input.mousePosition);
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
