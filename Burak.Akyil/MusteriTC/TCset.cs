using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTC
{
    public class TCset
    {
		private long _tc;

		public long TCno
		{
			get { return _tc; }
			set 
			{ 
				if(value.ToString().Length == 11)
				_tc = value;
				else
					_tc = 0;
			}
		}





	}
}
