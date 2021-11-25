using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float speed = 20f;

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			if (Input.GetAxis("Mouse X") != 0)
				transform.RotateAround(transform.position, -Vector3.up, Input.GetAxis("Mouse X") * speed);
			else
				transform.RotateAround(transform.position, Vector3.right, Input.GetAxis("Mouse Y") * speed / 2);
		}
	}
}