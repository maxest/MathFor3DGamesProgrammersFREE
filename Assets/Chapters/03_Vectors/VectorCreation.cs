using UnityEngine;

public class VectorCreation : MonoBehaviour
{
	public float x1 = 1.0f;
	public float y1 = 2.0f;
	public float x2 = 4.0f;
	public float y2 = -3.0f;

	void Update()
	{
		Vector2 v;
		v.x = x2 - x1;
		v.y = y2 - y1;

		//

		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);	

		Zenon.DrawCircle(x1, y1, 0.2f, 10002, Color.red);
		Zenon.DrawCircle(x2, y2, 0.2f, 10002, Color.red);
		Zenon.DrawAxis(x1, y1, x2, y2, 0.1f, 10003, Color.blue);

		Zenon.DrawTextWithBackground("v = [" + v.x + ", " + v.y + "]", -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 0.1f, 0.007f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10003, Color.black, Color.white);
	}
}
