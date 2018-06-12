using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Regular_Expression
{
	public class Infomation
	{
		public string Name { get; set; }
		public string Price { get; set; }
		public string Screen { get; set; }
		public string RAM { get; set; }
		public string CPU { get; set; }
		public string PIN { get; set; }
		public string HDH { get; set; }
		public string Camera { get; set; }
		public Infomation() {  }
		public Infomation(string _Name,string _Price,string _Screen,string _RAM,string _CPU,string _PIN,string _HDH,string _Camera)
		{
			Name = _Name;
			Price = _Price;
			Screen = _Screen;
			RAM = _RAM;
			CPU = _CPU;
			PIN = _PIN;
			HDH = _HDH;
			Camera = _Camera;
		}
	}
	 
}
