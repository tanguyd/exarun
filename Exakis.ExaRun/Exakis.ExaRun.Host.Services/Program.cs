using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Exakis.ExaRun.Web.Services {
	class Program {
		static void Main(string[] args) {

			string baseAddress = "http://localhost:9000/";

			// Start OWIN host 
			using (WebApp.Start<Startup>(baseAddress)) {
				// Create HttpCient and make a request to api/values 
				HttpClient client = new HttpClient();

				var response = client.GetAsync(baseAddress + "api/test/values").Result;

				Console.WriteLine(response);
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
			}

			Console.ReadLine(); 
		}
	}
}
