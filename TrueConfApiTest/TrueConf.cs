using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VideoConsultationsManagement {
	partial class TrueConf {
		public TrueConf () {

		}

		//public async Task GetAllAvailableDoctors() {
		//	string groupId = "0001";
		//	string url = rootUrl + apiGetAllUsersOfGroup.
		//		Replace("{secret_key}", secretKey).Replace("{group_id}", groupId);
		//	HttpResponseMessage response = await httpClient.GetAsync(url);
		//	response.EnsureSuccessStatusCode();

		//	Dictionary<string, Webinar> webinars;
		//	string jsonString = await response.Content.ReadAsStringAsync();
		//	if (!jsonString.Contains("id")) {
		//		webinars = new Dictionary<string, Webinar>();
		//	} else {
		//		webinars = JsonConvert.
		//			DeserializeObject<Dictionary<string, Dictionary<string, Webinar>>>(jsonString).Values.First();
		//	}
		//}

		public async Task<string> StopWebinar(string webinarId) {
			string url = rootUrl + apiPostStopWebinar.
				Replace("{secret_key}", secretKey).Replace("{webinar_id}", webinarId);
			HttpResponseMessage response = await httpClient.PostAsync(url, 
				new FormUrlEncodedContent(new Dictionary<string, string>()));
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> DeleteWebinar(string webinarId) {
			string url = rootUrl + apiDeleteWebianr.
				Replace("{secret_key}", secretKey).Replace("{webinar_id}", webinarId);
			HttpResponseMessage response = await httpClient.DeleteAsync(url);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		public async Task<Webinar> CreateNewWebinar(string topic, string owner, string timestamp) {
			Dictionary<string, string> values = new Dictionary<string, string>() {
				{ "topic", topic },
				{ "owner", owner },
				{ "allow_guests_audio_video", "true" },
				{ "allow_guests_message", "true" },
				{ "invitation_type", "1" },
				{ "invitation_timestamp",  timestamp },
				{ "max_participants", "5" }
			};

			FormUrlEncodedContent content = new FormUrlEncodedContent(values);
			ServicePointManager.Expect100Continue = false;
			string url = rootUrl + apiPostCreateWebinar.Replace("{secret_key}", secretKey);
			HttpResponseMessage response = await httpClient.PostAsync(url, content);
			response.EnsureSuccessStatusCode();
			string jsonString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Webinar>(jsonString);
		}

		public async Task<Dictionary<string, Webinar>> GetAllWebinars() {
			string url = rootUrl + apiGetAllWebinars.Replace("{secret_key}", secretKey);
			HttpResponseMessage response = await httpClient.GetAsync(url);
			response.EnsureSuccessStatusCode();

			Dictionary<string, Webinar> webinars;
			string jsonString = await response.Content.ReadAsStringAsync();
			if (!jsonString.Contains("id")) {
				webinars = new Dictionary<string, Webinar>();
			} else {
				webinars = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Webinar>>>(jsonString).Values.First();
			}
			return webinars;
		}
	}
}
