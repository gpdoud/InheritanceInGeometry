using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry {

	public class Square : Parallelogram {

		public void SetSides(int length) {
			SetAllSides(length, length);
		}

		public Square(int side) : base(side, side) {
			//SetSides(side);
		}
		public Square() : base() {

		}
	}
}
