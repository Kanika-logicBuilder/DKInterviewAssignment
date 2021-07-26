using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKInterviewAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json.Linq;

using System.Net;

using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DKInterviewAssignment.Controllers
{
    public class DKController : Controller
    {
        //below function sort the campaign in descending order of the amount of campaign and retirn the result to the view
        public IActionResult CampaignAccToAmount()
        {


            var campaignDetails = fetchCampaignDetail();
            IEnumerable<CampaingDetalis> campaingDetalisSortedList = new List<CampaingDetalis>();
            campaingDetalisSortedList = campaignDetails.OrderByDescending(o => o.totalAmount).ToList();
            //return (Task<ActionResult<IEnumerable<CampaingDetalis>>>)campaignDetails;
            return View(campaingDetalisSortedList);
        }
        // fetch the campaign detials from the link provided and convert it into the list 

        public IEnumerable<CampaingDetalis> fetchCampaignDetail()
        {
            var campaignDetailsJsonString = new WebClient().DownloadString("https://testapi.donatekart.com/api/campaign");
          
                IList<CampaingDetalis> campaingDetalisList = new List<CampaingDetalis>();
           
            var campaignDetailArray = JArray.Parse(campaignDetailsJsonString);
            foreach (var item in campaignDetailArray)
            {
                if (item != null)
                {
                    campaingDetalisList.Add(item.ToObject<CampaingDetalis>());
                }

            }
            
            return campaingDetalisList;



        
    }
        // It fetchs the active campaign
        public  IActionResult GetActiveCampaign()
        {
            var campaignDetails = fetchCampaignDetail();
            IList<CampaingDetalis> activeCampaingDetalisList = new List<CampaingDetalis>();
           

            foreach (var item in campaignDetails)
            {

                var xx = DateTime.Today.AddDays(-30);

               if ( item.endDate >= DateTime.Today  && item.created >= DateTime.Today.AddDays(-30))
                {

                    activeCampaingDetalisList.Add(item);
                }
            }
            return View(activeCampaingDetalisList);
        }
        //fetches the completed campaign
        public IActionResult GetCompletedCampaign()
        {
            var campaignDetails = fetchCampaignDetail();
            IList<CampaingDetalis> activeCampaingDetalisList = new List<CampaingDetalis>();

            foreach (var item in campaignDetails)
            {

                if (item.totalAmount >= item.procuredAmount || item.endDate < DateTime.Today)
                {

                    activeCampaingDetalisList.Add(item);
                }
            }
            return View(activeCampaingDetalisList);
        }
}
}



