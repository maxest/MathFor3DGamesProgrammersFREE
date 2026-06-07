using UnityEngine;

public class Functions2 : MonoBehaviour
{
	public float x = 4.0f;
	public float y = 3.0f;

	void Update()
	{
		Vector2 p1 = new Vector2(0.0f, 0.0f);
		Vector2 p2 = new Vector2(x, y);
		Vector2 p3 = new Vector2(x, 0.0f);

		Vector2 e1 = p2 - p1;
		Vector2 e2 = p3 - p2;
		Vector2 e3 = p1 - p3;
		Vector2 e1_normal = new Vector2(-e1.y, e1.x).normalized;
		Vector2 e2_normal = new Vector2(-e2.y, e2.x).normalized;
		Vector2 e3_normal = new Vector2(-e3.y, e3.x).normalized;

		Vector2 labelAPosition = p3 + 0.5f*e3 + 0.25f*e3_normal;
		Vector2 labelBPosition = p2 + 0.5f*e2 + 0.25f*e2_normal;
		Vector2 labelCPosition = p1 + 0.5f*e1 + 0.25f*e1_normal;

		//

		float a = Vector2.Distance(p1, p3);
		float b = Vector2.Distance(p3, p2);
		float c = Vector2.Distance(p2, p1);

		float tangent = b / a;
		float angle = Mathf.Atan(tangent);

		float newAngle = angle;
		if (x < 0.0f && y > 0.0f)
		{
			newAngle = (Mathf.PI/2.0f) + (Mathf.PI/2.0f - angle);
		}
		else if (x < 0.0f && y < 0.0f)
		{
			newAngle = (Mathf.PI) + (angle);
		}
		else if (x > 0.0f && y < 0.0f)
		{
			newAngle = (1.5f*Mathf.PI) + (Mathf.PI/2.0f - angle);
		}
		else if (x < 0.0f && y == 0.0f)
		{
			newAngle = Mathf.PI;
		}
		else if (x == 0.0f && y < 0.0f)
		{
			newAngle = 1.5f*Mathf.PI;
		}

		Debug.Log("a = " + a + "    b = " + b + "    c = " + c);
		Debug.Log(angle * Mathf.Rad2Deg + "    " + newAngle * Mathf.Rad2Deg);

		//

		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, Color.white);

		float startAngle = 0.0f;
		float stopAngle = newAngle * Mathf.Rad2Deg;

		Zenon.DrawCircleArc(p1.x, p1.y, 2.0f, startAngle, stopAngle, 10001, Zenon.ColorRGB(0.0f, 1.0f, 0.0f));
		Zenon.DrawAngle(p1.x, p1.y, 2.0f, 1.5f, "α", 0.007f, startAngle, stopAngle, 0.05f, 10002, Color.black);
		Zenon.DrawSegment(p1.x, p1.y, p2.x, p2.y, 0.05f, 10003, Color.black);
		Zenon.DrawSegmentDashed(p2.x, p2.y, p3.x, p3.y, 0.05f, 0.1f, 10003, Color.black);
		Zenon.DrawSegmentDashed(p3.x, p3.y, p1.x, p1.y, 0.05f, 0.1f, 10003, Color.black);

		Zenon.DrawText("a", labelAPosition.x, labelAPosition.y, 0.007f, Zenon.HoriAlignment.Center, Zenon.VertAlignment.Center, 10004, Color.black);
		Zenon.DrawText("b", labelBPosition.x, labelBPosition.y, 0.007f, Zenon.HoriAlignment.Center, Zenon.VertAlignment.Center, 10004, Color.black);
		Zenon.DrawText("c", labelCPosition.x, labelCPosition.y, 0.007f, Zenon.HoriAlignment.Center, Zenon.VertAlignment.Center, 10004, Color.black);
	}
}
