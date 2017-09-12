using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceInGeometry;

namespace TestInheritanceInGeometry {
	class Program {

		void Run() {
			Quadrilateral quad1 = new Quadrilateral(3, 4, 5, 6);
			//quad1.SetAllSides(3, 4, 5, 6);
			var perimeter = quad1.CalculatePerimeter();
			Console.WriteLine($"The perimeter is {perimeter}");

			Parallelogram p1 = new Parallelogram(7, 3);
			//p1.SetAllSides(7, 3);
			perimeter = p1.CalculatePerimeter();
			var area = p1.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");

			Square sqr = new Square(6);
			//sqr.SetSides(6);
			perimeter = sqr.CalculatePerimeter();
			area = sqr.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");
		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
