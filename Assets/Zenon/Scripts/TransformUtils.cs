using UnityEngine;

public partial class Zenon
{
	// Position

	static public void SetPosition(Transform transform, float x, float y, float z)
	{
		transform.position = new Vector3(x, y, z);
	}

	static public void SetPositionX(Transform transform, float x)
	{
		Vector3 temp = transform.position;
		temp.x = x;
		transform.position = temp;
	}

	static public void SetPositionY(Transform transform, float y)
	{
		Vector3 temp = transform.position;
		temp.y = y;
		transform.position = temp;
	}

	static public void SetPositionZ(Transform transform, float z)
	{
		Vector3 temp = transform.position;
		temp.z = z;
		transform.position = temp;
	}

	static public void AddToPosition(Transform transform, float x, float y, float z)
	{
		Vector3 temp = transform.position;
		temp.x += x;
		temp.y += y;
		temp.z += z;
		transform.position = temp;
	}

	static public void AddToPositionX(Transform transform, float x)
	{
		Vector3 temp = transform.position;
		temp.x += x;
		transform.position = temp;
	}

	static public void AddToPositionY(Transform transform, float y)
	{
		Vector3 temp = transform.position;
		temp.y += y;
		transform.position = temp;
	}

	static public void AddToPositionZ(Transform transform, float z)
	{
		Vector3 temp = transform.position;
		temp.z += z;
		transform.position = temp;
	}

	static public Vector3 GetPosition(Transform transform)
	{
		return transform.position;
	}

	static public float GetPositionX(Transform transform)
	{
		return transform.position.x;
	}

	static public float GetPositionY(Transform transform)
	{
		return transform.position.y;
	}

	static public float GetPositionZ(Transform transform)
	{
		return transform.position.z;
	}

	static public void SetLocalPosition(Transform transform, float x, float y, float z)
	{
		transform.localPosition = new Vector3(x, y, z);
	}

	static public void SetLocalPositionX(Transform transform, float x)
	{
		Vector3 temp = transform.localPosition;
		temp.x = x;
		transform.localPosition = temp;
	}

	static public void SetLocalPositionY(Transform transform, float y)
	{
		Vector3 temp = transform.localPosition;
		temp.y = y;
		transform.localPosition = temp;
	}

	static public void SetLocalPositionZ(Transform transform, float z)
	{
		Vector3 temp = transform.localPosition;
		temp.z = z;
		transform.localPosition = temp;
	}

	static public void AddToLocalPosition(Transform transform, float x, float y, float z)
	{
		Vector3 temp = transform.localPosition;
		temp.x += x;
		temp.y += y;
		temp.z += z;
		transform.localPosition = temp;
	}

	static public void AddToLocalPositionX(Transform transform, float x)
	{
		Vector3 temp = transform.localPosition;
		temp.x += x;
		transform.localPosition = temp;
	}

	static public void AddToLocalPositionY(Transform transform, float y)
	{
		Vector3 temp = transform.localPosition;
		temp.y += y;
		transform.localPosition = temp;
	}

	static public void AddToLocalPositionZ(Transform transform, float z)
	{
		Vector3 temp = transform.localPosition;
		temp.z += z;
		transform.localPosition = temp;
	}

	static public Vector3 GetLocalPosition(Transform transform)
	{
		return transform.localPosition;
	}

	static public float GetLocalPositionX(Transform transform)
	{
		return transform.localPosition.x;
	}

	static public float GetLocalPositionY(Transform transform)
	{
		return transform.localPosition.y;
	}

	static public float GetLocalPositionZ(Transform transform)
	{
		return transform.localPosition.z;
	}

	// Rotation

	static public void SetRotation(Transform transform, float x, float y, float z)
	{
		transform.eulerAngles = new Vector3(x, y, z);
	}

	static public void SetRotationX(Transform transform, float x)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.x = x;
		transform.eulerAngles = eulerAngles;
	}

	static public void SetRotationY(Transform transform, float y)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.y = y;
		transform.eulerAngles = eulerAngles;
	}

	static public void SetRotationZ(Transform transform, float z)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.z = z;
		transform.eulerAngles = eulerAngles;
	}

	static public void AddToRotation(Transform transform, float x, float y, float z)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.x += x;
		eulerAngles.y += y;
		eulerAngles.z += z;
		transform.eulerAngles = eulerAngles;
	}

	static public void AddToRotationX(Transform transform, float x)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.x += x;
		transform.eulerAngles = eulerAngles;
	}

	static public void AddToRotationY(Transform transform, float y)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.y += y;
		transform.eulerAngles = eulerAngles;
	}

	static public void AddToRotationZ(Transform transform, float z)
	{
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.z += z;
		transform.eulerAngles = eulerAngles;
	}

	static public Vector3 GetRotation(Transform transform)
	{
		return transform.eulerAngles;
	}

	static public float GetRotationX(Transform transform)
	{
		return transform.eulerAngles.x;
	}

	static public float GetRotationY(Transform transform)
	{
		return transform.eulerAngles.y;
	}

	static public float GetRotationZ(Transform transform)
	{
		return transform.eulerAngles.z;
	}

	static public void SetLocalRotation(Transform transform, float x, float y, float z)
	{
		transform.localEulerAngles = new Vector3(x, y, z);
	}

	static public void SetLocalRotationX(Transform transform, float x)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.x = x;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void SetLocalRotationY(Transform transform, float y)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.y = y;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void SetLocalRotationZ(Transform transform, float z)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.z = z;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void AddToLocalRotation(Transform transform, float x, float y, float z)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.x += x;
		localEulerAngles.y += y;
		localEulerAngles.z += z;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void AddToLocalRotationX(Transform transform, float x)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.x += x;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void AddToLocalRotationY(Transform transform, float y)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.y += y;
		transform.localEulerAngles = localEulerAngles;
	}

	static public void AddToLocalRotationZ(Transform transform, float z)
	{
		Vector3 localEulerAngles = transform.localEulerAngles;
		localEulerAngles.z += z;
		transform.localEulerAngles = localEulerAngles;
	}

	static public Vector3 GetLocalRotation(Transform transform)
	{
		return transform.localEulerAngles;
	}

	static public float GetLocalRotationX(Transform transform)
	{
		return transform.localEulerAngles.x;
	}

	static public float GetLocalRotationY(Transform transform)
	{
		return transform.localEulerAngles.y;
	}

	static public float GetLocalRotationZ(Transform transform)
	{
		return transform.localEulerAngles.z;
	}

	// Scale

	static public void SetScale(Transform transform, float x, float y, float z)
	{
		SetLocalScale(transform, x, y, z);
	}

	static public void SetScaleX(Transform transform, float x)
	{
		SetLocalScaleX(transform, x);
	}

	static public void SetScaleY(Transform transform, float y)
	{
		SetLocalScaleY(transform, y);
	}

	static public void SetScaleZ(Transform transform, float z)
	{
		SetLocalScaleZ(transform, z);
	}

	static public void AddToScale(Transform transform, float x, float y, float z)
	{
		AddToLocalScale(transform, x, y, z);
	}

	static public void AddToScaleX(Transform transform, float x)
	{
		AddToLocalScaleX(transform, x);
	}

	static public void AddToScaleY(Transform transform, float y)
	{
		AddToLocalScaleY(transform, y);
	}

	static public void AddToScaleZ(Transform transform, float z)
	{
		AddToLocalScaleZ(transform, z);
	}

	static public Vector3 GetScale(Transform transform)
	{
		return GetLocalScale(transform);
	}

	static public float GetScaleX(Transform transform)
	{
		return GetLocalScaleX(transform);
	}

	static public float GetScaleY(Transform transform)
	{
		return GetLocalScaleY(transform);
	}

	static public float GetScaleZ(Transform transform)
	{
		return GetLocalScaleZ(transform);
	}

	static public void SetLocalScale(Transform transform, float x, float y, float z)
	{
		transform.localScale = new Vector3(x, y, z);
	}

	static public void SetLocalScaleX(Transform transform, float x)
	{
		Vector3 temp = transform.localScale;
		temp.x = x;
		transform.localScale = temp;
	}

	static public void SetLocalScaleY(Transform transform, float y)
	{
		Vector3 temp = transform.localScale;
		temp.y = y;
		transform.localScale = temp;
	}

	static public void SetLocalScaleZ(Transform transform, float z)
	{
		Vector3 temp = transform.localScale;
		temp.z = z;
		transform.localScale = temp;
	}

	static public void AddToLocalScale(Transform transform, float x, float y, float z)
	{
		Vector3 temp = transform.position;
		temp.x += x;
		temp.y += y;
		temp.z += z;
		transform.localScale = temp;
	}

	static public void AddToLocalScaleX(Transform transform, float x)
	{
		Vector3 temp = transform.localScale;
		temp.x += x;
		transform.localScale = temp;
	}

	static public void AddToLocalScaleY(Transform transform, float y)
	{
		Vector3 temp = transform.localScale;
		temp.y += y;
		transform.localScale = temp;
	}

	static public void AddToLocalScaleZ(Transform transform, float z)
	{
		Vector3 temp = transform.localScale;
		temp.z += z;
		transform.localScale = temp;
	}

	static public Vector3 GetLocalScale(Transform transform)
	{
		return transform.localScale;
	}

	static public float GetLocalScaleX(Transform transform)
	{
		return transform.localScale.x;
	}

	static public float GetLocalScaleY(Transform transform)
	{
		return transform.localScale.y;
	}

	static public float GetLocalScaleZ(Transform transform)
	{
		return transform.localScale.z;
	}
}
