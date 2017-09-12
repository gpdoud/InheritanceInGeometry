using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry {
	public class Parallelogram  : Quadrilateral {

		public void SetAllSides(int side1, int side2) {
			SetAllSides(side1, side2, side1, side2);
		}

		public int CalculateArea() {
			var area = s1 * s2;
			return area;
		}

		public Parallelogram(int side1, int side2) : base(side1, side2, side1, side2) {
			//SetAllSides(side1, side2);
		}
		public Parallelogram() : base() {
		}
	}
}
