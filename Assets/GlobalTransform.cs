using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[DisallowMultipleComponent]
public class GlobalTransform : MonoBehaviour
{
	public Vector4 showRotation=new Vector4();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showRotation.x=transform.rotation.x;
		showRotation.y = transform.rotation.y;
		showRotation.z = transform.rotation.z;
		showRotation.w = transform.rotation.w;
	}
}
