using UnityEngine;

public class ImplicitGeometry : MonoBehaviour
{
	public float gridStep = 0.1f;
	public float gridTolerance = 0.5f;

	public float implicitC = 0.0f;

	public float x = 0.0f;
	public float y = 0.0f;

	void Update()
	{
		float ImplicitFunction(float x, float y)
		{
			return x*x + y*y - 9.0f;
		//	return y*y*y - y - x;
		}

		float gridRadius = 5.0f;
		gridStep = Mathf.Max(gridStep, 0.1f);

		Zenon.DrawRect(Zenon.GetCanvasWidth(), Zenon.GetCanvasHeight(), 10000, new Color(0.7f, 0.8f, 0.9f));
		Zenon.DrawCoordSystem(true, 15.0f, 10.0f, 1.0f, 0.05f, 10001);

		for (float gridY = -gridRadius; gridY <= gridRadius; gridY += gridStep)
		{
			for (float gridX = -gridRadius; gridX <= gridRadius; gridX += gridStep)
			{
				float implicitFunction = ImplicitFunction(gridX, gridY);

				if (FloatsEqual(implicitFunction, implicitC, gridTolerance))
				{
					Zenon.DrawRect(
						gridX - 0.25f*gridStep,
						gridY - 0.25f*gridStep,
						gridX + 0.25f*gridStep,
						gridY + 0.25f*gridStep,
						10002, new Color(Mathf.Clamp01(implicitFunction), Mathf.Clamp01(implicitFunction), Mathf.Clamp01(implicitFunction)));
				}
			}
		}

		Zenon.DrawCircle(x, y, 0.15f, 10003, Color.red);
		Zenon.DrawTextWithBackground("f = " + ImplicitFunction(x, y), -Zenon.GetCanvasWidth() * 0.5f + 0.1f, Zenon.GetCanvasHeight() * 0.5f - 0.1f, 0.007f, Zenon.HoriAlignment.Left, Zenon.VertAlignment.Top, 10004, Color.black, Color.white);
	}

	private bool FloatsEqual(float a, float b, float eps)
	{
		return Mathf.Abs(a - b) < eps;
	}
}
