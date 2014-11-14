#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;
using WaveEngine.Materials;

#endregion

namespace PolkaDotted.ObstacleRunnerProject
{
	public class MyScene : Scene
	{
		protected override void CreateScene()
		{
			RenderManager.BackgroundColor = Color.Black;

			var title = new Entity("Title")
				.AddComponent(new Material2D(new BasicMaterial(Color.Red)))
				.AddComponent(new )
				.AddComponent(new Transform2D()
				{
					Y = WaveServices.Platform.ScreenHeight / 2,
					X = WaveServices.Platform.ScreenWidth / 2,
				});

			EntityManager.Add(title);
		}
	}
}
