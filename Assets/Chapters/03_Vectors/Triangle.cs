using UnityEngine;

public class Triangle : MonoBehaviour
{
	public Vector3 p0 = new Vector2(0.0f, 0.0f);
	public Vector3 p1 = new Vector2(2.5f, 5.0f);
	public Vector3 p2 = new Vector2(5.0f, 0.0f);

	public bool normalizeNormal = true;

	void Update()
	{
		Vector3 e1 = p1 - p0;
		Vector3 e2 = p2 - p0;

		Vector3 normal = Vector3.Cross(p1 - p0, p2 - p0);

		if (normalizeNormal)
			normal.Normalize();

		//

		Zenon.DrawGridXY(20.0f, 20.0f, 1.0f, 0.05f, 10000);

		Zenon.DrawAxis3D(p0, p0 + e1, 0.5f * 0.125f, 1.0f, 0.5f * 0.5f, 10001, Color.red);
		Zenon.DrawAxis3D(p0, p0 + e2, 0.5f * 0.125f, 1.0f, 0.5f * 0.5f, 10001, Zenon.ColorGreen075);
		Zenon.DrawCylinder(p1.x, p1.y, p1.z, p2.x, p2.y, p2.z, 0.5f * 0.125f, 10001, Color.white);

		Zenon.DrawAxis3D(p0, p0 + normal, 0.5f * 0.125f, 0.5f * 0.5f, 0.5f * 0.25f, 10001, Color.blue);
	}
}
