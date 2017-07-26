using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoConsultationsManagement {
	class Webinar : Conference {
		[JsonProperty("allow_guests_audio_video")]
		public bool allowGuestsAudioVideo { get; set; }

		[JsonProperty("allow_guests_message")]
		public bool allowGuestsMessage { get; set; }

		public override string ToString() {
			string result = base.ToString() + Environment.NewLine;
			result += "\tALLOW_GUESTS_AUDIO_VIDEO: \t" + allowGuestsAudioVideo + Environment.NewLine;
			result += "\tALLOW_GUESTS_MESSAGE: \t" + allowGuestsMessage;
			return result;
		}

		public DateTime UnixTimeStampToDateTime() {
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
			dateTime = dateTime.AddSeconds(invitationTimestamp).ToLocalTime();
			return dateTime;
		}

		public string GetOwner() {
			if (string.IsNullOrEmpty(owner))
				return "";

			if (!owner.Contains("@"))
				return owner;

			return owner.Split('@')[0];
		}

		public string GetStartDateAndTime() {
			if (invitationTimestamp == 0)
				return "Не задано";

			return UnixTimeStampToDateTime().ToString();
		}

		public string GetPhoneNumber() {
			string phoneNumber = "";
			try {
				if (topic.Length > 10) {
					string rightTenSymbols = topic.Substring(topic.Length - 10);
					if (rightTenSymbols.All(char.IsDigit))
						phoneNumber = rightTenSymbols;
				}
			} catch (Exception) {
			}

			return phoneNumber;
		}
	}
}
