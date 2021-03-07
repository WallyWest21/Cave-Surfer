using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Test.Models
{
    public class test_Model
    {
        public List<StockData> stockdata = new List<StockData>();

            public object[,] array2D = new object[,] {
        {"11/15/2014", 93.87, 94.91, 93.7, 93.76 },
 {"11/16/2014", 93.87, 11, 93.7, 33 },
 {"11/17/2014", 93.87, 94.91, 93.7, 93.76 },
 {"11/18/2014", 95, 77, 93.7, 22 },
 {"11/19/2014", 93.87, 94.91, 93.7, 93.76 },
 {"11/20/2014", 93.87, 44, 93.7, 93.76 },
 {"11/21/2014", 93.87, 94.91, 93.7, 88 },


        };

        public object[,] stock_array = new object[,] 
        {
        {"11/15/2014", 93.87, 94.91, 93.7, 93.76},
              {"11/16/2014", 93.91, 94.33, 92.07, 92.45},
              {"11/17/2014", 93.14, 93.55, 91.52, 91.6},
              {"11/18/2014", 92.56, 93, 92, 92.05},
              {"11/21/2014", 92.03, 92.62, 91.22, 91.59},
              {"11/22/2014", 91.9, 93.14, 91.81, 91.96},
              {"11/23/2014", 92.32, 92.5, 91.18, 91.7},
              {"11/25/2014", 91.87, 92.45, 91.41, 91.8},
              {"11/28/2014", 93.19, 93.99, 93.07, 93.06},
              {"11/29/2014", 93.54, 93.79, 93.11, 93.46},
              {"11/30/2014", 94.85, 95.54, 94.64, 95.52},
              {"12/1/2014", 95.44, 95.88, 95.22, 95.5},
              {"12/2/2014", 96.37, 96.47, 95.32, 95.7},
              {"12/5/2014", 96.42, 96.59, 95.08, 95.35},
              {"12/6/2014", 95.47, 96.27, 94.82, 96.01},
              {"12/7/2014", 95.83, 96.65, 95.5, 96.45},
              {"12/8/2014", 97.03, 98.29, 96.72, 96.92},
              {"12/9/2014", 97.67, 98.43, 97.62, 98.03},
              {"12/12/2014", 97.67, 98.53, 97.2, 98.48},
              {"12/13/2014", 98.74, 98.95, 97.76, 98},
              {"12/14/2014", 97.76, 98.46, 97.16, 97.61},
              {"12/15/2014", 98.51, 98.78, 97.86, 98.14},
              {"12/16/2014", 98.54, 98.62, 97.08, 97.49},
              {"12/19/2014", 97.92, 98.37, 96.98, 97.24},
              {"12/20/2014", 98.07, 98.92, 97.93, 98.82},

        };


        public test_Model()
        {
        List<StockData> stockdata = new List<StockData>();
            stockdata.Add(new StockData() { Date = "11/15/2014", Open = 90, High = 94, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/16/2014", Open = 77, High = 94, Low = 88, Close = 55 });
            stockdata.Add(new StockData() { Date = "11/17/2014", Open = 86, High = 94, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/18/2014", Open = 87, High = 44, Low = 44, Close = 44 });
            stockdata.Add(new StockData() { Date = "11/19/2014", Open = 45, High = 94, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/20/2014", Open = 55, High = 94, Low = 44, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/21/2014", Open = 56, High = 45, Low = 44, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/22/2014", Open = 12, High = 55, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/23/2014", Open = 90, High = 94, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/24/2014", Open = 25, High = 94, Low = 44, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/25/2014", Open = 35, High = 94, Low = 55, Close = 44 });
            stockdata.Add(new StockData() { Date = "11/26/2014", Open = 90, High = 44, Low = 88, Close = 87 });
            stockdata.Add(new StockData() { Date = "11/27/2014", Open = 90, High = 94, Low = 88, Close = 87 });

        }
        //public System.Collections.Generic.List<string, double, double, double, double> stockdata = new System.Collections.Generic.List<string, double, double, double, double>();

        public class StockData
        {
          
            public string Date { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }
        }
    }
}