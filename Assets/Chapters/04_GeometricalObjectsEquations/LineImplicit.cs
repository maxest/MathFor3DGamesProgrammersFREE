using UnityEngine;

public class LineImplicit : MonoBehaviour
{
	public Vector2 line1_p1 = new Vector2(-3.0f, 3.0f);
	public Vector2 line1_p2 = new Vector2(3.0f, -3.0f);
	public Vector2 line2_p1 = new Vector2(-3.0f, -3.0f);
	public Vector2 line2_p2 = new Vector2(3.0f, 3.0f);

	public float px = 3.0f;
	public float py = -1.0f;

	void Update()
	{
		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);
		
		//

		Vector2 line1_v = line1_p2 - line1_p1;
		line1_v.Normalize();

		float a1 = -line1_v.y;
		float b1 = line1_v.x;
		float c1 = -(a1 * line1_p1.x + b1 * line1_p1.y);

		//

		Vector2 line2_v = line2_p2 - line2_p1;
		line2_v.Normalize();

		float a2 = -line2_v.y;
		float b2 = line2_v.x;
		float c2 = -(a2 * line2_p1.x + b2 * line2_p1.y);

		//

		float d1 = a1*px + b1*py + c1;
		float d2 = a2*px + b2*py + c2;

		//

		// https://www.wolframalpha.com/input?i=a_1*x+%2B+b_1*y+%2B+c_1+%3D+0%2C+a_2*x+%2B+b_2*y+%2B+c_2+%3D+0%2C+find+x+and+y
		float ix = (b2*c1 - b1*c2) / (a2*b1 - a1*b2);
		float iy = (a2*c1 - a1*c2) / (a1*b2 - a2*b1);

		//

		Zenon.DrawSegment(line1_p1.x, line1_p1.y, line1_p2.x, line1_p2.y, 0.05f, 10002, Color.red);
		Zenon.DrawSegment(line2_p1.x, line2_p1.y, line2_p2.x, line2_p2.y, 0.05f, 10003, Color.blue);

		Zenon.DrawCircle(px, py, 0.1f, 10004, Color.black);
		Zenon.DrawCircle(ix, iy, 0.1f, 10004, Color.black);

		Zenon.DrawTextWithBackground("red: " + d1 + ",    blue: " + d2, -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 0.1f, 0.01f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10005, Color.black, Color.white);
	}
}
