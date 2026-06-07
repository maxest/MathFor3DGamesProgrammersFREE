using UnityEngine;

public class VectorsDot : MonoBehaviour
{
	public Vector2 v1 = new Vector2(3.0f, 0.0f);
	public Vector2 v2 = new Vector2(0.0f, 2.0f);

	public bool normalized = false;

	void Update()
	{
		float vDot = Dot(v1, v2);

		Vector2 u1 = v1.normalized;
		Vector2 u2 = v2.normalized;
		float uDot = Vector2.Dot(u1, u2);
		float theta = Mathf.Acos(uDot);

		//

		Zenon.CanvasWidth = 16.0f;
		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);

		if (!normalized)
		{
			Zenon.DrawAxis(0.0f, 0.0f, v1.x, v1.y, 0.1f, 10002, Color.red);
			Zenon.DrawAxis(0.0f, 0.0f, v2.x, v2.y, 0.1f, 10002, Zenon.ColorGreen075);
			Zenon.DrawTextWithBackground("dot product: " + vDot, -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 0.1f, 0.007f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10003, Color.black, Color.white);
		}
		else
		{
			Zenon.DrawAxis(0.0f, 0.0f, u1.x, u1.y, 0.1f, 10002, Color.red);
			Zenon.DrawAxis(0.0f, 0.0f, u2.x, u2.y, 0.1f, 10002, Zenon.ColorGreen075);
			Zenon.DrawTextWithBackground("dot product: " + uDot, -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 0.1f, 0.007f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10003, Color.black, Color.white);
		}
		Zenon.DrawTextWithBackground("theta: " + (theta * Mathf.Rad2Deg), -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 1.0f, 0.007f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10003, Color.black, Color.white);
	}

	public float Dot(Vector2 v1, Vector2 v2)
	{
		return v1.x*v2.x + v1.y*v2.y;
	}
}
