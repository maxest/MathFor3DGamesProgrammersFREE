using UnityEngine;

public class LineLinear : MonoBehaviour
{
	public Vector2 line1_p1 = new Vector2(-3.0f, 3.0f);
	public Vector2 line1_p2 = new Vector2(3.0f, -3.0f);
	public Vector2 line2_p1 = new Vector2(-3.0f, -3.0f);
	public Vector2 line2_p2 = new Vector2(3.0f, 3.0f);

	public float a1, b1, a2, b2;

	void Update()
	{
		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);

		//

		a1 = (line1_p2.y - line1_p1.y) / (line1_p2.x - line1_p1.x);
		b1 = line1_p1.y - a1*line1_p1.x;

		a2 = (line2_p2.y - line2_p1.y) / (line2_p2.x - line2_p1.x);
		b2 = line2_p1.y - a2*line2_p1.x;

		//

		float ix = (b2 - b1) / (a1 - a2);
		float iy = a1*ix + b1;

		//

		{
			Zenon.DrawSegment(line1_p1.x, line1_p1.y, line1_p2.x, line1_p2.y, 0.05f, 10002, Color.red);
			Zenon.DrawSegment(line2_p1.x, line2_p1.y, line2_p2.x, line2_p2.y, 0.05f, 10003, Color.blue);
		}

	/*	{
			float Line1(float x)
			{
				return a1*x + b1;
			}

			float Line2(float x)
			{
				return a2*x + b2;
			}

			Zenon.DrawFunction(Line1, line1_p1.x, line1_p2.x, 0.05f, 10002, Color.red);
			Zenon.DrawFunction(Line2, line2_p1.x, line2_p2.x, 0.05f, 10003, Color.blue);
		}*/

		Zenon.DrawCircle(ix, iy, 0.1f, 10004, Color.black);
	}
}
