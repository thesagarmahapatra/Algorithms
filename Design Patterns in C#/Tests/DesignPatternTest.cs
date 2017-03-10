//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using System;
using Patterns;
using System.Collections;


namespace tests
{
	[TestFixture()]
	public class Test
	{

		[Test()]
		public void StrategyTest()
		{
			Helicopter helicopter = new Helicopter();
			StreetRacing street = new StreetRacing();

			helicopter.Go ();
			street.Go ();

			//change algorithm at runtime
			helicopter.SetGoAlgorithm(new GoByDriving());
			helicopter.Go ();
		}

		[Test()]
		public void DecoratorTest()
		{
			Computer comp= new Computer();
			Disk d= new Disk(comp);
			Assert.AreEqual ("computer and a disk",d.description());
		}

		[Test()]
		public void FirstFactoryTest()
		{
			FirstFactory factory = new FirstFactory ("SQL");
			Connection connection=factory.CreateConnection ();
			Assert.AreEqual ("SQL",connection.description());			
		}

		[Test()]
		public void AbstractFactoryTest()
		{
			SecureFactory factory = new SecureFactory ();
			Connection connection=factory.CreateConnection ("SQL");			
			Assert.AreEqual ("SQL",connection.description());			
		}
		[Test()]
		public void ObserverTest()
		{
			Database db = new Database ();
			Client client = new Client ();
			Boss boss = new Boss ();
			db.RegisterObserver (client);
			db.RegisterObserver (boss);
			db.EditRecord ("delete", "record 1");
		}
		[Test()]
		public void SingletonTest()
		{
			//simple 
			Singleton_ single1 = Singleton_.GetInstance ();
			Singleton_ single2 = Singleton_.GetInstance ();
			Assert.AreSame (single1, single2);

			//thread safe singleton
			Singleton single3 = Singleton.Instance;
			Singleton single4 = Singleton.Instance;
			Assert.AreSame (single3, single4);
		}
		[Test()]
		public void AdaptorTest()
		{
			AceClass aceObject = new AceClass ();
			aceObject.setName("Cary Grant");
			AceToAcmeAdapter adapter = new AceToAcmeAdapter(aceObject);

			Assert.AreEqual("Cary",adapter.getFirstName());
			Assert.AreEqual("Grant",adapter.getLastName());
		}
		[Test()]
		public void FacadeTest()
		{
			simpleProductFacade simplePF = new simpleProductFacade ();
			simplePF.setName("testers");
			Assert.AreEqual ("testers",simplePF.getName ());
		}
		[Test()]
		public void TemplateTest()
		{
			AutoMotiveRobot automotiveRobot = new AutoMotiveRobot ("AutomotiveRobot");
			CookieRobot cookieRobot = new CookieRobot ("CookieRobot");
			automotiveRobot.Go ();
			cookieRobot.Go ();
		}
		[Test()]
		public void BuilderTest()
		{
			CookieRobotBuilder builder = new CookieRobotBuilder ();
			builder.addStart ();
			builder.addGetParts ();
			builder.addStop ();
			RobotBuildable cookieRobotBuildable = builder.getRobot ();
			cookieRobotBuildable.Go ();
		}
		[Test()]
		public void IteratorTest()
		{
			Division division = new Division ("sales");
			division.Add ("bob");
			division.Add ("joe");
			division.Add ("ziggy");
			IEnumerator it = division.iterator ();
			while (it.MoveNext())
			{
				VP vp=it.Current as VP;
                if (vp!=null)
				vp.print();
			}
		}
		[Test()]
		public void StateTest()
		{
			Automat automat = new Automat(9);
			
			automat.gotApplication();
			automat.checkApplication();
			automat.rentApartment();
		}
		[Test()]
		public void RepositoryTest()
		{
			var autoRepository = new AutoRepository();			
			AutomobileBase automobile = autoRepository.Find("mini");
			
			if (automobile == AutomobileBase.NULL)
				return;
			
			automobile.Start();
			automobile.Stop();
		}
		[Test()]
		public void MediatorTest()
		{
			Mediator mediator = new Mediator();			
			mediator.getWelcome().go();
		}
		[Test()]
		public void CommandTest()
		{
			AsiaServer server = new AsiaServer ();
			ShutDownAsiaCommand shutdown = new ShutDownAsiaCommand (server);
			RebootCommand rebootAsia = new RebootCommand (server);

			shutdown.Execute ();
			rebootAsia.Execute ();
            Assert.IsTrue(true);
		}



	}
}
