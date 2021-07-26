using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKInterviewAssignment.Models
{
    public class CampaingDetalis
    {

       public string code { get; set; }
        public string title { get; set; }
        public bool  featured { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int priority { get; set; }
        public string shortDesc { get; set; }
         public string  imageSrc { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime created { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime endDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float totalAmount { get;set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float procuredAmount  { get;set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float totalProcured { get;set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float backersCount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int categoryId { get; set; }
     public string ngoCode { get; set; }
        public string ngoName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int daysLeft { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float percentage { get; set; }


    }
}
