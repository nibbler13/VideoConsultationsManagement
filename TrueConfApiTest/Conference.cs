using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConsultationsManagement {
	class Conference {
		//Conference Structure
		//Field					Type			Description
		//id					string			uniqie identifier of conference
		//url					string			web url of conference
		//type					integer			type of conference		0 = symmetric; 1 = assymetric; 3 = role-based
		//topic					string			conference name
		//owner					string			owner of conference
		//size_participants		integer			size of participants
		//invitation_type		string			type of scheduling conference	"-1" = "without schedule"; "0" = "every week"; "1" = "nonrecurrent"
		//invitation_timestamp	integer			date and time for start conference in Unix Timestamp(if invitation_type == "1") optional 
		//invitation_time		string			time to start the conference(if invitation_type == "0") optional    
		//invitation_days		array			list of days for the start of the conference(if invitation_type == "0") optional    
		//podiums				integer			size of speakers for the role-based conference optional    
		//max_participants		integer			maximum participants of conference
		//state					string			state of conference(runnning or stopped);

		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("url")]
		public string url { get; set; }

		[JsonProperty("type")]
		public int type { get; set; }

		[JsonProperty("topic")]
		public string topic { get; set; }

		[JsonProperty("owner")]
		public string owner { get; set; }

		[JsonProperty("size_participants")]
		public int sizeParticipants { get; set; }

		[JsonProperty("invitation_type")]
		public string invitationType { get; set; }

		[JsonProperty("invitation_timestamp")]
		public int invitationTimestamp { get; set; }

		[JsonProperty("invitation_time")]
		public string invitationTime { get; set; }

		[JsonProperty("invitation_days")]
		public string[] invitationDays { get; set; }

		[JsonProperty("podiums")]
		public int podiums { get; set; }

		[JsonProperty("max_participants")]
		public int maxParticipants { get; set; }

		[JsonProperty("state")]
		private string state;
		public string State {
			get {
				if (state.Equals("running"))
					return "Активная";
				if (state.Equals("stopped"))
					return "Неактивная";
				return this.state;
			}
			set {
				this.state = value;
			}
		}

		public override string ToString() {
			string result = base.ToString() + Environment.NewLine;
			if (id != null)
				result += "\tID: \t\t\t" + id + Environment.NewLine;
			if (url != null)
				result += "\tURL: \t\t\t" + url + Environment.NewLine;
			result += "\tTYPE: \t\t\t" +
				(type == 0 ? "symmetric" : type == 1 ? "assymetric" : type == 3 ? "role-based" : "unknown") +
				Environment.NewLine;
			if (topic != null)
				result += "\tTOPIC: \t\t\t" + topic + Environment.NewLine;
			if (owner != null)
				result += "\tOWNER: \t\t" + owner + Environment.NewLine;
			result += "\tSIZE_PARTICIPANT: \t" + sizeParticipants + Environment.NewLine;
			if (invitationType != null)
				result += "\tINVITATION_TYPE: \t" +
				(invitationType.Equals("-1") ? "without schedule" :
				invitationType.Equals("0") ? "every week" :
				invitationType.Equals("1") ? "nonrecurrent" : "unknown") +
				Environment.NewLine;
			result += "\tINVITATION_TIMESTAMP: \t" + invitationTimestamp + Environment.NewLine;
			if (invitationTime != null)
				result += "\tINVITATION_TIME: \t" + invitationTime + Environment.NewLine;
			if (invitationDays != null)
				result += "\tINVITATION_DAYS: \t" + string.Join(";", invitationDays) + Environment.NewLine;
			result += "\tPODIUMS: \t\t" + podiums + Environment.NewLine;
			result += "\tMAX_PARTICIPANTS: \t" + maxParticipants + Environment.NewLine;
			if (state != null)
				result += "\tSTATE: \t\t\t" + state;
			return result;
		}
	}
}
