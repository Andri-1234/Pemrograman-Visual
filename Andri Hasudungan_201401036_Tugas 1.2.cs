/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 2/27/2022
 * Time: 11:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace BelajarCSHARP{
	class programHW2{
		static void Main (String [] args){
			Console.Write ("Nama kamu siapa ?");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu "+ nama);
			
			Console.Write ("Press any key to continue . . .");
			Console.ReadKey(true);
		}
	}
}
