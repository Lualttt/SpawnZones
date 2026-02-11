using System.Numerics;

namespace SpawnZones
{
	public record struct SpawnZone(Vector2 Center, Vector2 Size, float MaxHeight, float MinHeight = float.MinValue)
	{
		public static readonly Vector3 SpawnPointOffset = new(0f, 3.8f, 0f);

		public readonly Vector3 GetRandomSpawnPoint(SpatialHeightMap heightMap)
		{
			float x = ((Random.Shared.NextSingle() - 0.5f) * Size.X) + Center.X;
			float z = ((Random.Shared.NextSingle() - 0.5f) * Size.Y) + Center.Y;

			float? y = heightMap.GetHeight(x, z, MaxHeight);

			if (y is null || y.Value + 0.0001f < MinHeight)
				return new Vector3(x, MaxHeight, z);

			return new Vector3(x, y.Value, z);
		}
	}
}
