using UnityEngine;

public class LinearMapping : MonoBehaviour
{
	public float interval1_begin = 0.0f, interval1_end = 1.0f;
	public float interval2_begin = -2.0f, interval2_end = 6.0f;

	public float x = 0.0f;

	void Update()
	{
		float x1 = interval1_begin;
		float x2 = interval1_end;
		float y1 = interval2_begin;
		float y2 = interval2_end;

		float a = (y2 - y1) / (x2 - x1);
		float b = y1 - a*x1;

		float y = a*x + b;

		//

		Debug.Log(x + " in [" + interval1_begin + ", " + interval1_end + "]        " + y + " in [" + interval2_begin + ", " + interval2_end + "]");

		//

		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);

		Zenon.DrawSegment(interval1_begin, 1.0f, interval1_end, 1.0f, 0.1f, 10001, Color.red);
		Zenon.DrawSegment(interval2_begin, -1.0f, interval2_end, -1.0f, 0.1f, 10001, Color.blue);

		Zenon.DrawCircle(x, 1.0f, 0.1f, 10002, Color.black);
		Zenon.DrawCircle(y, -1.0f, 0.1f, 10002, Color.black);
	}
}
