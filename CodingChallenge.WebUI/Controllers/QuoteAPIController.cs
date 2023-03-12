using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CodingChallenge.ViewModel;

namespace CodingChallenge.WebUI.Controllers
{
    public class QuoteAPIController : Controller
    {
        // GET: QuoteAPI
        public ActionResult Index()
        {
            return View();
        }

        string Baseurl = "https://api.quotable.io/";

        #region Get Random Quote

        public async Task<ActionResult> GetRandomQuote()
        {
            List<QuoteRandomViewModel> quoteRandoms = new List<QuoteRandomViewModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.GetAsync("quotes/random");
                    if (Res.IsSuccessStatusCode)
                    {
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                        quoteRandoms = JsonConvert.DeserializeObject<List<QuoteRandomViewModel>>(EmpResponse);
                    }

                }
            }
            catch (Exception ex)
            {
            }

            return View(quoteRandoms);
        }

        #endregion

        #region Get Random Quote

        public async Task<ActionResult> GetAuthorQuote()
        {
            QuoteAuthorViewModel quoteAuthors = new QuoteAuthorViewModel();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.GetAsync("quotes?author=albert-einstein");
                    if (Res.IsSuccessStatusCode)
                    {
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                        quoteAuthors = JsonConvert.DeserializeObject<QuoteAuthorViewModel>(EmpResponse);
                    }

                }
            }
            catch (Exception ex)
            {
            }
            quoteAuthors.results.ForEach(item => item.type = item.length <= 10 ? "Short" : item.length > 10 & item.length <= 20 ? "Medium" : item.length > 20 ? "Long" : "");
            return View(quoteAuthors);
        }

        #endregion

    }
}