using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using System.Threading;

namespace StockMarket_Lib
{
    [Produces("application/json")]

    public class cl_StockMarket
    {
        [Route("~/api/ApiStockData/{ticker}/{start}/{end}/{period}")]
        [HttpGet]
        public async Task<List<StockPriceModel>> GetStockData(string ticker, string start, string end, string period)
        {
            var p = Period.Daily;
            if (period.ToLower() == "weekly") p = Period.Weekly;
            else if (period.ToLower() == "monthly") p = Period.Monthly;
            var startDate = DateTime.Parse(start);
            var endDate = DateTime.Parse(end);

            var hist = await Yahoo.GetHistoricalAsync(ticker, startDate, endDate, p);

            List<StockPriceModel> models = new List<StockPriceModel>();
            foreach (var r in hist)
            {
                models.Add(new StockPriceModel
                {
                    Ticker = ticker,
                    //Date = r.DateTime.ToString("yyyy-MM-dd"),
                    Date = r.DateTime.ToString("MM/dd/yyyy HH:mm"),
                    Open = r.Open,
                    High = r.High,
                    Low = r.Low,
                    Close = r.Close,
                    AdjustedClose = r.AdjustedClose,
                    Volume = r.Volume

                });
            }
            return models;
        }
        public   List<StockPriceModel> GetStockdataNotAsync(string ticker, string start, string end, string period)
        {
            List<StockPriceModel> models = new List<StockPriceModel>();

            //models = Task.Run(async () => 
            //await  GetStockData(ticker, DateTime.Now.AddHours(-6).ToString("MM/dd/yyyy HH:mm"), 
            //DateTime.Now.ToString("MM/dd/yyyy HH:mm"), "daily"));

            //models = GetStockData(ticker, DateTime.Now.AddHours(-6).ToString("MM/dd/yyyy HH:mm"), DateTime.Now.ToString("MM/dd/yyyy HH:mm"), "daily").GetAwaiter().GetResult();
            //List <Task  <StockPriceModel>> callTask = Task.Run(() => GetStockData(ticker, DateTime.Now.AddHours(-6).ToString("MM/dd/yyyy HH:mm"), DateTime.Now.ToString("MM/dd/yyyy HH:mm"), "daily"));
            // callTask.Wait();
            // // Get the result
            // ret = callTask.Result;



            foreach (StockPriceModel x in  GetStockData(ticker, DateTime.Now.AddHours(-6).ToString("MM/dd/yyyy HH:mm"), DateTime.Now.ToString("MM/dd/yyyy HH:mm"), "daily").GetAwaiter().GetResult().ToList<StockPriceModel>())
            {
                models.Add(x);            
            }


            return models;
        }
    }
    public class StockPriceModel
    {
        public string Ticker { get; set; }
        public string Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjustedClose { get; set; }
        public decimal Volume { get; set; }
    }
}
