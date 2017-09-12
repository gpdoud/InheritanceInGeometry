using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry
{
    public class Quadrilateral {

		protected int s1;
		protected int s2;
		protected int s3;
		protected int s4;

		public void SetAllSides(int side1, int side2, int side3, int side4) {
			s1 = side1;
			s2 = side2;
			s3 = side3;
			s4 = side4;
		}

		public int CalculatePerimeter() {
			var totalLength = s1 + s2 + s3 + s4;
			return totalLength;
		}

		public Quadrilateral(int side1, int side2, int side3, int side4) {
			SetAllSides(side1, side2, side3, side4);
		}
		public Quadrilateral() {
		}
	}
}
