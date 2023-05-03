using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimAt : MonoBehaviour
{
    Transform aimTransform;

    [SerializeField] 
    private Camera maincamera;
    
    // Start is called before the first frame update
    //void Awake()
    //{
    //    aimTransform = transform.Find("Aim");
    //}

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = GetMouseWorldPosition();
        Debug.Log(mousePosition.x+":" + mousePosition.y);
        
        

        //animator.SetFloat("Horizontal", aim.x);
        //animator.SetFloat("Vertical", aim.y);
        //animator.SetFloat("Speed", aim.sqrMagnitude);

    }
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 pos, Camera maincamera)
    {
        Vector3 worldPosition = maincamera.ScreenToWorldPoint(pos);
        return worldPosition;
    }
}
