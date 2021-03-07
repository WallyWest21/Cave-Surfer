using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace StockMarket_Lib.View_Model
{
    class VM_CaveSurfer
    {
        //public async Task AutomaticallyUpdateStocks(System.Collections.Specialized.StringCollection SavedSearchTerms, )
        //{
        //    while (true)
        //    {


        //        List<StockMarket_Lib.StockPriceModel> _manualReadTagList = new List<StockMarket_Lib.StockPriceModel>();

        //        List<string> tickerlist = new List<string> { "AAPL", "GOOG", "AMZN", "FB" };

                
        //        foreach (string ticker in SavedSearchTerms)
        //        {
        //            foreach (var r in await cl_StockMarket.GetStockData(ticker, DateTime.Now.AddMilliseconds(-2).ToString("MM/dd/yyyy HH:mm"), DateTime.Now.ToString("MM/dd/yyyy HH:mm"), "daily"))
        //            {
        //                _manualReadTagList.Add(r);
        //            }
        //        }
        //        await Task.Run(() =>
        //        {


        //            Dispatcher.BeginInvoke(new Action(delegate
        //            {

        //                txtblk_LastUpdated.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        //                dg_Stocks.ItemsSource = _manualReadTagList;


        //            }));
        //            Thread.Sleep(3000);
        //        }

              
        //        );
             

        //    }

        //}

    }
}
