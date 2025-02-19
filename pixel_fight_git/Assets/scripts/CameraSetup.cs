using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetup : MonoBehaviour
{
	Animator CameraObject;

    private void Start()
    {
		CameraObject = transform.GetComponent<Animator>();
	}


    public void Position2()
    {
        CameraObject.SetFloat("CamPos1", 1);
    }

    public void Position1()
    {
        CameraObject.SetFloat("CamPos1", 0);
    }

    public void Position4()
    {
        CameraObject.SetFloat("CamPos2", 1);
    }

    public void Position3()
    {
        CameraObject.SetFloat("CamPos2", 0);
    }

}
