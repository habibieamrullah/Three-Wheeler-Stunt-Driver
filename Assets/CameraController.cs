using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Transform lookatTarget;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void FixedUpdate(){
		Vector3 desPos = target.position + offset;
		Vector3 smoothPos = Vector3.Lerp (transform.position, desPos, smoothSpeed);
		transform.position = smoothPos;
		//transform.rotation = target.rotation;
		transform.LookAt (lookatTarget);
	}

}
