using System.Globalization;
using System.Numerics;

namespace SpawnZones
{
	public static class SpawnZones
	{
		public static readonly SpawnZone[] BitterBeach = [
				new SpawnZone(
								Center: new(0.2f, 6f),
								Size: new(88.02f, 89.5f),
								MaxHeight: 28f,
								MinHeight: -6f
						)
		];

		public static readonly SpawnZone[] Blueline = [
				new SpawnZone(
								Center: new(5.5f, 0f),
								Size: new(108f, 105f),
								MaxHeight: 19.5f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] CockyContainers = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(80f, 80f),
								MaxHeight: 6f,
								MinHeight: -27f
						)
		];

		public static readonly SpawnZone[] ColorClimb = [
				new SpawnZone(
								Center: new(37f, 0f),
								Size: new(20f, 95f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(-38f, 0f),
								Size: new(12.1f, 95f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, 38f),
								Size: new(95f, 20f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, -38f),
								Size: new(95f, 20f),
								MaxHeight: -27f,
								MinHeight: -30f
						)
		];

		public static readonly SpawnZone[] CrustyRocks = [ // Uses custom spawning logic, SpawnZone is not normally used
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(0f, 0f),
								MaxHeight: 0f,
								MinHeight: 0f
						)
		];

		public static readonly SpawnZone[] Desert = [
				new SpawnZone(
								Center: new(-2.572611f, -53.8937f),
								Size: new(93.81f, 15.43f),
								MaxHeight: 6.875084f,
								MinHeight: 1f
						)
		];

		public static readonly SpawnZone[] Dorm = [
				new SpawnZone(
								Center: new(0f, -4.7f),
								Size: new(75.14f, 58.92f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] FunkyFields = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(95f, 95f),
								MaxHeight: 3f,
								MinHeight: -25f
						)
		];

		public static readonly SpawnZone[] GlassJump = [
				new SpawnZone(
								Center: new(-4.75f, -9.25f),
								Size: new(36f, 36.1f),
								MaxHeight: 14.5f,
								MinHeight: 11f
						)
		];

		public static readonly SpawnZone[] HastyHill = [
				new SpawnZone(
								Center: new(37f, 0f),
								Size: new(20f, 95f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(-38f, 0f),
								Size: new(12.1f, 95f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, 38f),
								Size: new(95f, 20f),
								MaxHeight: -27f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, -38f),
								Size: new(95f, 20f),
								MaxHeight: -27f,
								MinHeight: -30f
						)
		];

		public static readonly SpawnZone[] IcyCrack = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 3f,
								MinHeight: -23f
						)
		];

		public static readonly SpawnZone[] IcyIslands = [
				new SpawnZone(
								Center: new(-1.2f, -17f),
								Size: new(53.1f, 49.6f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] IcyRocks = [ // Uses custom spawning logic, SpawnZone is not normally used
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(0f, 0f),
								MaxHeight: 0f,
								MinHeight: 0f
						)
		];

		public static readonly SpawnZone[] Islands = [
				new SpawnZone(
								Center: new(1f, -9f),
								Size: new(58.5f, 37.9f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] Karlson = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 14f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] LankyLava = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(90f, 90f),
								MaxHeight: 25.1f,
								MinHeight: -7f
						)
		];

		public static readonly SpawnZone[] LavaLake = [ // Uses custom spawning logic, SpawnZone is not normally used
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(0f, 0f),
								MaxHeight: 0f,
								MinHeight: 0f
						)
		];

		public static readonly SpawnZone[] Plains = [
				new SpawnZone(
								Center: new(-2.572611f, -58.35f),
								Size: new(93.81f, 13.79f),
								MaxHeight: 20.6f,
								MinHeight: 2.5f
						)
		];

		public static readonly SpawnZone[] Playground = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] Playground2 = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] ReturnToMonke = [
				new SpawnZone(
								Center: new(0.2f, 3f),
								Size: new(93.8f, 99.8f),
								MaxHeight: 48f,
								MinHeight: -7f
						)
		];

		public static readonly SpawnZone[] Sandstorm = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(70f, 70f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] SlipperySlope = [
				new SpawnZone(
								Center: new(-2.572611f, -53.8937f),
								Size: new(93.81f, 16.6f),
								MaxHeight: 2f,
								MinHeight: 1f
						)
		];

		public static readonly SpawnZone[] SmallColorClimb = [
				new SpawnZone(
								Center: new(22f, 0f),
								Size: new(12f, 55f),
								MaxHeight: -13f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(-22f, 0f),
								Size: new(12f, 55f),
								MaxHeight: -13f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, 22f),
								Size: new(55f, 12f),
								MaxHeight: -13f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, -22f),
								Size: new(55f, 12f),
								MaxHeight: -13f,
								MinHeight: -30f
						)
		];

		public static readonly SpawnZone[] SmallGlassJump = [
				new SpawnZone(
								Center: new(-1.55f, -33.1f),
								Size: new(25f, 25f),
								MaxHeight: 14.5f,
								MinHeight: 11f
						)
		];

		public static readonly SpawnZone[] SmallHill = [
				new SpawnZone(
								Center: new(22f, 0f),
								Size: new(12f, 55f),
								MaxHeight: -18f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(-22f, 0f),
								Size: new(12f, 55f),
								MaxHeight: -18f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, 22f),
								Size: new(55f, 12f),
								MaxHeight: -18f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, -22f),
								Size: new(55f, 12f),
								MaxHeight: -18f,
								MinHeight: -30f
						)
		];

		public static readonly SpawnZone[] SmallIcyIslands = [
				new SpawnZone(
								Center: new(-0.04000008f, 5.53f),
								Size: new(20f, 20f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] SmallIslands = [
				new SpawnZone(
								Center: new(0.25f, 5.66f),
								Size: new(20.95f, 20.7f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] SmallPlayground = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(40f, 40f),
								MaxHeight: 0f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] Snowtop = [
				new SpawnZone(
								Center: new(-20.9f, -8.4f),
								Size: new(124.9f, 66.79f),
								MaxHeight: 91.1f,
								MinHeight: 43f
						)
		];

		public static readonly SpawnZone[] Splat = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(69f, 69f),
								MaxHeight: 3f,
								MinHeight: -25f
						)
		];

		public static readonly SpawnZone[] Splot = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(69f, 69f),
								MaxHeight: 3f,
								MinHeight: -25f
						)
		];

		public static readonly SpawnZone[] SunnySaloon = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] ToxicTrain = [
				new SpawnZone(
								Center: new(22.75f, 0f),
								Size: new(160f, 5f),
								MaxHeight: 3f,
								MinHeight: -22f
						),
						new SpawnZone(
								Center: new(24f, 16f),
								Size: new(150f, 5f),
								MaxHeight: 3f,
								MinHeight: -22f
						),
						new SpawnZone(
								Center: new(24f, -16f),
								Size: new(150f, 5f),
								MaxHeight: 3f,
								MinHeight: -22f
						)
		];

		public static readonly SpawnZone[] TwistedTowers = [
				new SpawnZone(
								Center: new(28f, 0f),
								Size: new(21f, 70f),
								MaxHeight: 11f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(-27f, 0f),
								Size: new(21f, 70f),
								MaxHeight: 11f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, 27f),
								Size: new(70f, 21f),
								MaxHeight: 11f,
								MinHeight: -30f
						),
						new SpawnZone(
								Center: new(0f, -27.5f),
								Size: new(70f, 21f),
								MaxHeight: 11f,
								MinHeight: -30f
						)
		];

		public static readonly SpawnZone[] MiniMonke = [
				new SpawnZone(
								Center: new(0.2f, 2f),
								Size: new(61f, 55.9f),
								MaxHeight: 44f,
								MinHeight: -7f
						)
		];

		public static readonly SpawnZone[] SmallBeach = [
				new SpawnZone(
								Center: new(-2f, 3f),
								Size: new(58f, 51.5f),
								MaxHeight: 26f,
								MinHeight: -6f
						)
		];

		public static readonly SpawnZone[] SmallSaloon = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(65f, 65f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] SmolContainers = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(50f, 50f),
								MaxHeight: 6f,
								MinHeight: -27f
						)
		];

		public static readonly SpawnZone[] TinyTown2 = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(40f, 40f),
								MaxHeight: 6.75f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] TinyTown = [
				new SpawnZone(
								Center: new(-0.8f, 1f),
								Size: new(70f, 70f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] DodgyFields = [
				new SpawnZone(
								Center: new(-0.8000002f, -18.44124f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						),
						new SpawnZone(
								Center: new(-0.8000002f, 17.95876f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] DodgyIce = [
				new SpawnZone(
								Center: new(-0.8000002f, -18.44124f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						),
						new SpawnZone(
								Center: new(-0.8000002f, 17.95876f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] DodgySnow = [
				new SpawnZone(
								Center: new(-0.8000002f, -18.44124f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						),
						new SpawnZone(
								Center: new(-0.8000002f, 17.95876f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] DodgyStreets = [
				new SpawnZone(
								Center: new(-0.8000002f, -18.44124f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						),
						new SpawnZone(
								Center: new(-0.8000002f, 17.95876f),
								Size: new(65f, 32.5f),
								MaxHeight: 3f,
								MinHeight: -20f
						)
		];

		public static readonly SpawnZone[] SandyIslands = [
				new SpawnZone(
								Center: new(1f, -9f),
								Size: new(58.5f, 37.9f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] SmallSandyIslands = [
				new SpawnZone(
								Center: new(0.25f, 5.66f),
								Size: new(20.95f, 20.7f),
								MaxHeight: 0f,
								MinHeight: -11f
						)
		];

		public static readonly SpawnZone[] CheekyChamber = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(50f, 50f),
								MaxHeight: 6f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] LavaDrop = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(50f, 50f),
								MaxHeight: 6f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] LavaDump = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(80f, 80f),
								MaxHeight: 6f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] PeacefulPlatform = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(50f, 50f),
								MaxHeight: 6f,
								MinHeight: -21.5f
						)
		];

		public static readonly SpawnZone[] SaltyIsland = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(80f, 80f),
								MaxHeight: 6f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] Skybox = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(80f, 80f),
								MaxHeight: 6f,
								MinHeight: -21f
						)
		];

		public static readonly SpawnZone[] SaucyStage = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(73.39f, 17f),
								MaxHeight: 12.4f,
								MinHeight: 2f
						)
		];

		public static readonly SpawnZone[] LavaClimb = [
				new SpawnZone(
								Center: new(-41f, -152.46f),
								Size: new(68.91f, 17.6f),
								MaxHeight: 25.1f,
								MinHeight: -8f
						)
		];

		public static readonly SpawnZone[] MacaroniMountain = [
				new SpawnZone(
								Center: new(0f, -46f),
								Size: new(87.25f, 20.1f),
								MaxHeight: 17f,
								MinHeight: -1f
						)
		];

		public static readonly SpawnZone[] SussySandcastle = [
				new SpawnZone(
								Center: new(0f, -114.94f),
								Size: new(57.6f, 13.7f),
								MaxHeight: 25.54f,
								MinHeight: 19f
						)
		];

		public static readonly SpawnZone[] SussySlope = [
				new SpawnZone(
								Center: new(-19.85f, -39.94f),
								Size: new(67.52f, 24.6f),
								MaxHeight: 135f,
								MinHeight: 121f
						)
		];

		public static readonly SpawnZone[] SandyStones = [ // Uses custom spawning logic, SpawnZone is not normally used
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(0f, 0f),
								MaxHeight: 0f,
								MinHeight: 0f
						)
		];

		public static readonly SpawnZone[] Crabfields = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(53f, 53f),
								MaxHeight: 6f,
								MinHeight: -19.4f
						)
		];

		public static readonly SpawnZone[] Crabheat = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(53f, 53f),
								MaxHeight: 6f,
								MinHeight: -19.4f
						)
		];

		public static readonly SpawnZone[] Crabland = [
				new SpawnZone(
								Center: new(0f, 0f),
								Size: new(53f, 53f),
								MaxHeight: 6f,
								MinHeight: -19.4f
						)
		];


		public static SpatialHeightMap GetHeightMap(string objPath, float cellSize = 1f, SpawnZone[]? zones = null)
		{
			var tris = GetTris(objPath);
			return new(tris, cellSize, zones);
		}


		public static List<(Vector3 v0, Vector3 v1, Vector3 v2)> GetTris(string objPath)
		{
			string[] lines = File.ReadAllLines(objPath);

			List<Vector3> vertices = [];
			List<(int vi0, int vi1, int vi2)> triangles = [];

			foreach (string raw in lines)
			{
				string line = raw.Trim();
				if (line.Length == 0)
					continue;

				string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				switch (parts[0])
				{
					case "v": // Vertex
						{
							float x = float.Parse(parts[1], CultureInfo.InvariantCulture);
							float y = float.Parse(parts[2], CultureInfo.InvariantCulture);
							float z = float.Parse(parts[3], CultureInfo.InvariantCulture);

							vertices.Add(new Vector3(x, y, z));
							break;
						}
					case "f": // Face
						{
							// OBJ is 1-based indexing
							List<int> faceIndices = [];

							for (int i = 1; i < parts.Length; i++)
							{
								string[] split = parts[i].Split('/');
								int vertexIndex = int.Parse(split[0]) - 1;
								faceIndices.Add(vertexIndex);
							}

							// Triangulate (fan method)
							for (int i = 1; i < faceIndices.Count - 1; i++)
								triangles.Add((
										faceIndices[0],
										faceIndices[i],
										faceIndices[i + 1]
								));
							break;
						}
				}
			}

			Vector3 up = Vector3.UnitY;
			List<(Vector3 v0, Vector3 v1, Vector3 v2)> upwardTriangles = new(triangles.Count);

			foreach (var (vi0, vi1, vi2) in triangles)
			{
				Vector3 v0 = vertices[vi0];
				Vector3 v1 = vertices[vi1];
				Vector3 v2 = vertices[vi2];

				Vector3 edge1 = v1 - v0;
				Vector3 edge2 = v2 - v0;

				Vector3 normal = Vector3.Normalize(Vector3.Cross(edge1, edge2));
				float length = normal.LengthSquared();
				if (float.IsNaN(length) || length < 0.9999f || length > 1.0001f)
					continue;

				float dot = Vector3.Dot(normal, up);
				if (dot > 0.0001f)
					upwardTriangles.Add((v0, v1, v2));
			}

			return upwardTriangles;
		}
	}
}
