using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    public Transform target;
    //How fast camera looks at target and follows player.
    public float lookSmooth = 0.09f;
    public Vector3 offsetFromTarget = new Vector3(0, 6, -8);

    Vector3 destination = Vector3.zero;
    characterController charController;
    float rotateVel = 0;

     void Start()
    {
        SetCameraTarget(target);
    }

    void SetCameraTarget(Transform t)
    {
        target = t;
        if(target != null)
        {
            if (target.GetComponent<CharacterController>())
            {
                charController = target.GetComponent<characterController>();
            }
        }
    }

    void LateUpdate()
    {
        MoveToTarget();
        LookAtTarget();
    }

    void MoveToTarget()
    {
        destination = charController.TargetRotation * offsetFromTarget;
        destination += target.position;
        transform.position = destination;
    }
    void LookAtTarget()
    {
        float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y, ref rotateVel, lookSmooth);
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle, 0);
    }
}
