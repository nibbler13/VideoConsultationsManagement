using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConsultationsManagement {
	class ListViewColumnSorter : IComparer {
		public int ColumnToSort { get; set; }
		public SortOrder OrderOfSort { get; set; }
		private CaseInsensitiveComparer ObjectCompare = new CaseInsensitiveComparer();

		public ListViewColumnSorter() {
			ColumnToSort = 0;
			OrderOfSort = SortOrder.None;
		}
		
		public int Compare(object x, object y) {
			int compareResult = 0;
			ListViewItem listviewX, listviewY;
			
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;
			
			try {
				string valueX = listviewX.SubItems[ColumnToSort].Text;
				string valueY = listviewY.SubItems[ColumnToSort].Text;

				if (ColumnToSort == 1) {
					compareResult = ObjectCompare.Compare(int.Parse(valueX), int.Parse(valueY));
				} else if (ColumnToSort == 3) {
					if (valueX.Equals("Не задано"))
						valueX = new DateTime().ToString();
					if (valueY.Equals("Не задано"))
						valueY = new DateTime().ToString();
					compareResult = ObjectCompare.Compare(DateTime.Parse(valueX), DateTime.Parse(valueY));
				} else {
					compareResult = ObjectCompare.Compare(valueX, valueY);
				}
			} catch (Exception) {
			}
			
			if (OrderOfSort == SortOrder.Ascending) {
				return compareResult;
			} else if (OrderOfSort == SortOrder.Descending) {
				return (-compareResult);
			} else {
				return 0;
			}
		}

	}
}