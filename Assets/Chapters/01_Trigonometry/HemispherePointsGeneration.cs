using UnityEngine;

public class HemispherePointsGeneration : MonoBehaviour
{
	public enum GenerationType
	{
		Standard,
		GoldenSpiral,
		CosineDistribution
	}

	public Mesh mesh;
	public Material whiteMaterial;
	public Material redMaterial;

	public GenerationType generationType = GenerationType.Standard;
	public float cosineDistributionExponent = 0.0f;
	public float radius = 3.0f;

	void Update()
	{
		if (generationType == GenerationType.Standard)
		{
			for (float r1 = 0.0f; r1 < 1.0f; r1 += 0.05f)
			{
				for (float r2 = 0.0f; r2 < 1.0f; r2 += 0.05f)
				{
					float theta = r1 * Mathf.PI / 2.0f;
					float phi = r2 * 2.0f * Mathf.PI;

					SphericalToCartesian(out float x, out float y, out float z, radius, theta, phi);
					DrawMesh(whiteMaterial, x, y, z);
				}
			}
		}
		else if (generationType == GenerationType.GoldenSpiral)
		{
			int n = 400;

			for (int i = 0; i < n; i++)
			{
				float i_float = (float)i + 0.5f;

				float theta = Mathf.Acos(1.0f - 2.0f * (0.5f*i_float) / n);
				float phi = Mathf.PI * (1.0f + Mathf.Sqrt(5.0f)) * i_float;

				SphericalToCartesian(out float x, out float y, out float z, radius, theta, phi);
				DrawMesh(whiteMaterial, x, y, z);
			}
		}
		else if (generationType == GenerationType.CosineDistribution)
		{
			for (float r1 = 0.0f; r1 < 1.0f; r1 += 0.05f)
			{
				for (float r2 = 0.0f; r2 < 1.0f; r2 += 0.05f)
				{
					float e = cosineDistributionExponent;

					float theta = Mathf.Acos(Mathf.Pow(1.0f - r1, 1.0f / (e + 1.0f)));
					float phi = r2 * 2.0f * Mathf.PI;

					SphericalToCartesian(out float x, out float y, out float z, radius, theta, phi);
					DrawMesh(whiteMaterial, x, y, z);
				}
			}
		}
	}

	private void SphericalToCartesian(out float x, out float y, out float z, float radius, float theta, float phi)
	{
		x = radius * Mathf.Sin(theta) * Mathf.Cos(phi);
		y = radius * Mathf.Sin(theta) * Mathf.Sin(phi);
		z = radius * Mathf.Cos(theta);
	}

	private void DrawMesh(Material material, float x, float y, float z, float scale = 0.1f)
	{
		Matrix4x4 transform = Matrix4x4.TRS(new Vector3(x, y, z), Quaternion.identity, new Vector3(scale, scale, scale));
		Graphics.DrawMesh(mesh, transform, material, 0);
	}
}
