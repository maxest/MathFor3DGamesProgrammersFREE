using UnityEngine;

public class VectorNormalize : MonoBehaviour
{
	public Vector2 v = new Vector2(3.0f, 2.0f);

	void Update()
	{
		Vector2 u = v / v.magnitude;

	//	u = v.normalized;

	//	u = v;
	//	u.Normalize();

	//	u = v / GetLength(v);

		//

		Zenon.CanvasWidth = 16.0f;
		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);

		Zenon.DrawAxis(0.0f, 0.0f, v.x, v.y, 0.1f, 10002, Color.red);
		Zenon.DrawAxis(0.0f, 0.0f, u.x, u.y, 0.1f, 10003, Zenon.ColorGreen075);
	}

	private float GetLength(Vector2 v)
	{
		return Mathf.Sqrt(v.x*v.x + v.y*v.y);
	}
}
