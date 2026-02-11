using System.Numerics;

namespace SpawnZones
{
	public class SpatialHeightMap
	{
		private readonly float cellSize;
		private readonly float minX, minZ;
		private readonly int gridWidth, gridHeight;

		private readonly List<Triangle>[,] grid;

		private struct Triangle
		{
			public Vector3 v0, v1, v2;

			public float minX, maxX;
			public float minZ, maxZ;
		}

		public SpatialHeightMap(List<(Vector3 v0, Vector3 v1, Vector3 v2)> tris, float cellSize = 1f, SpawnZone[]? zones = null)
		{
			this.cellSize = cellSize;

			float globalMinX = float.MaxValue;
			float globalMaxX = float.MinValue;
			float globalMinZ = float.MaxValue;
			float globalMaxZ = float.MinValue;

			if (zones is not null && zones.Length > 0)
			{
				globalMinX = float.MaxValue;
				globalMaxX = float.MinValue;
				globalMinZ = float.MaxValue;
				globalMaxZ = float.MinValue;

				foreach (var zone in zones)
				{
					float halfX = zone.Size.X * 0.5f;
					float halfZ = zone.Size.Y * 0.5f;

					float minX = zone.Center.X - halfX;
					float maxX = zone.Center.X + halfX;
					float minZ = zone.Center.Y - halfZ;
					float maxZ = zone.Center.Y + halfZ;

					globalMinX = Math.Min(globalMinX, minX);
					globalMaxX = Math.Max(globalMaxX, maxX);
					globalMinZ = Math.Min(globalMinZ, minZ);
					globalMaxZ = Math.Max(globalMaxZ, maxZ);
				}
			}
			else
				foreach (var (v0, v1, v2) in tris)
				{
					globalMinX = Math.Min(globalMinX, Math.Min(v0.X, Math.Min(v1.X, v2.X)));
					globalMaxX = Math.Max(globalMaxX, Math.Max(v0.X, Math.Max(v1.X, v2.X)));

					globalMinZ = Math.Min(globalMinZ, Math.Min(v0.Z, Math.Min(v1.Z, v2.Z)));
					globalMaxZ = Math.Max(globalMaxZ, Math.Max(v0.Z, Math.Max(v1.Z, v2.Z)));
				}

			minX = globalMinX;
			minZ = globalMinZ;

			gridWidth = (int)Math.Ceiling((globalMaxX - globalMinX) / cellSize) + 1;
			gridHeight = (int)Math.Ceiling((globalMaxZ - globalMinZ) / cellSize) + 1;

			grid = new List<Triangle>[gridWidth, gridHeight];

			foreach (var (v0, v1, v2) in tris)
			{
				Triangle t = new()
				{
					v0 = v0,
					v1 = v1,
					v2 = v2,
					minX = Math.Min(v0.X, Math.Min(v1.X, v2.X)),
					maxX = Math.Max(v0.X, Math.Max(v1.X, v2.X)),
					minZ = Math.Min(v0.Z, Math.Min(v1.Z, v2.Z)),
					maxZ = Math.Max(v0.Z, Math.Max(v1.Z, v2.Z))
				};

				if (t.maxX < globalMinX || t.minX > globalMaxX || t.maxZ < globalMinZ || t.minZ > globalMaxZ)
					continue;

				int startX = ToCellX(t.minX);
				int endX = ToCellX(t.maxX);
				int startZ = ToCellZ(t.minZ);
				int endZ = ToCellZ(t.maxZ);

				for (int gx = startX; gx <= endX; gx++)
				{
					for (int gz = startZ; gz <= endZ; gz++)
					{
						if (grid[gx, gz] is null)
							grid[gx, gz] = [];

						grid[gx, gz].Add(t);
					}
				}
			}
		}

		private int ToCellX(float x) => Clamp((int)((x - minX) / cellSize), 0, gridWidth - 1);
		private int ToCellZ(float z) => Clamp((int)((z - minZ) / cellSize), 0, gridHeight - 1);

		private static int Clamp(int v, int min, int max)
				=> v < min ? min : (v > max ? max : v);

		public float? GetHeight(float x, float z, float maxHeight = float.MaxValue)
		{
			int gx = ToCellX(x);
			int gz = ToCellZ(z);

			var list = grid[gx, gz];
			if (list is null)
				return null;

			float? highest = null;

			foreach (var t in list)
			{
				if (x < t.minX || x > t.maxX || z < t.minZ || z > t.maxZ)
					continue;

				if (!PointInTriXZ(x, z, t))
					continue;

				float y = InterpolateY(x, z, t);

				if (highest is null || y > highest.Value)
				{
					if (y - 0.0001f > maxHeight)
						return null;

					highest = y;
				}
			}

			return highest;
		}

		private static bool PointInTriXZ(float px, float pz, Triangle t)
		{
			float ax = t.v0.X, az = t.v0.Z;
			float bx = t.v1.X, bz = t.v1.Z;
			float cx = t.v2.X, cz = t.v2.Z;

			float v0x = bx - ax;
			float v0z = bz - az;
			float v1x = cx - ax;
			float v1z = cz - az;
			float v2x = px - ax;
			float v2z = pz - az;

			float dot00 = v0x * v0x + v0z * v0z;
			float dot01 = v0x * v1x + v0z * v1z;
			float dot11 = v1x * v1x + v1z * v1z;
			float dot20 = v2x * v0x + v2z * v0z;
			float dot21 = v2x * v1x + v2z * v1z;

			float denom = dot00 * dot11 - dot01 * dot01;
			if (Math.Abs(denom) < 1e-6f)
				return false;

			float invDenom = 1f / denom;
			float v = (dot11 * dot20 - dot01 * dot21) * invDenom;
			float w = (dot00 * dot21 - dot01 * dot20) * invDenom;
			float u = 1f - v - w;

			return u >= 0f && v >= 0f && w >= 0f;
		}

		private static float InterpolateY(float px, float pz, Triangle t)
		{
			Vector3 normal = Vector3.Cross(t.v1 - t.v0, t.v2 - t.v0);

			float d = -Vector3.Dot(normal, t.v0);

			return -(normal.X * px + normal.Z * pz + d) / normal.Y;
		}
	}
}
