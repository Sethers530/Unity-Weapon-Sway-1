using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{

    [Header("Sway Settings")]
    [SerializeField] private float smooth;
    [SerializeField] private float swayMultiplayer;

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * swayMultiplayer;
        float mouseY = Input.GetAxisRaw("Mouse Y") * swayMultiplayer;

        // calculate target rotation
        Quaternion roationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion roationY = Quaternion.AngleAxis(-mouseX, Vector3.up);

        Quaternion targetRotation = roationX * roationY;

        //rotate
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);

    }

}
