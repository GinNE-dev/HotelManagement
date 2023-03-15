using HotelManagement.Utils;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace HotelManagement.FuntionalForms
{
    public partial class frmStatistic : Form
    {
        private  List<string> monthLabels = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private List<string> weekdayLabels = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public frmStatistic()
        {
            InitializeComponent();
            //
            PrepareComponents();
        }

        private void PrepareComponents()
        {
            dateTimePickerRange.MaxDate = DateTime.Today;
            if(cbbPeriod.Items.Count == 0)
            {
                cbbPeriod.Items.Add("Week");
            }
            cbbPeriod.SelectedIndex = 0;
            btnECount.Text = "Employees: "+ HotelDB.GetDBEntities().Employees.Count().ToString();
            btnSCount.Text = "Services: "+ HotelDB.GetDBEntities().Services.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private List<string> GetDayOfMonthLables(int year, int month)
        {
            List<string> lables = new List<string>();
            if(month < 1 || month > 12 || year < 1775) return lables;

            for(int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                lables.Add(i.ToString());
            }
            return lables;
        }

        private List<Bill> GetBillsInDays(DateTime day, int numOfDay = 1)
        {
            List<Bill> bills = new List<Bill>();
            
            for(int i=0; i < numOfDay; i++)
            {
                bills.AddRange(HotelDB.GetDBEntities().Bills.Where(
                            b => b.BillDate.Year.Equals(day.Year)
                            && b.BillDate.Month.Equals(day.Month)
                            && b.BillDate.Day.Equals(day.Day)
                            ).ToList());
                day = day.AddDays(1);
            }

            return bills;
        }

        private List<Bill> GetBillsInYear(int year)
        {
            List<Bill> bills = new List<Bill>();
            if (year < 0) return bills;
            for (int i = 1; i <= 12; i++)
            {
                bills.AddRange(HotelDB.GetDBEntities().Bills.Where(
                            b => b.BillDate.Year.Equals(year)
                            && b.BillDate.Month.Equals(i)
                            ).ToList());
            }

            return bills;
        }

        private void DrawCustomerAgeClassify()
        {
            int adole = HotelDB.GetDBEntities().Customers.Count(x => x.Age > 13 && x.Age <= 17);
            int young = HotelDB.GetDBEntities().Customers.Count(x => x.Age >= 18 && x.Age <= 30);
            int midleAdult = HotelDB.GetDBEntities().Customers.Count(x => x.Age >= 31 && x.Age <= 50);
            int senior = HotelDB.GetDBEntities().Customers.Count(x => x.Age > 51);

            var series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Adolsc (13-17)",
                    Values = new LiveCharts.ChartValues<double> { adole },
                    DataLabels = true
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Youngs (18-30)",
                    Values = new LiveCharts.ChartValues<double> { young },
                    DataLabels = true
                },

                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Adults (31-50)",
                    Values = new LiveCharts.ChartValues<double> { midleAdult },
                    DataLabels = true
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Seniors (>50)",
                    Values = new LiveCharts.ChartValues<double> { senior },
                    DataLabels = true
                }
            };

            var pieChart = new PieChart()
            {
                Series = series,
                LegendLocation = LegendLocation.Right,
            };

            elementHostCustomerAge.Child = pieChart;
        }

        private void DrawBarCharRevenue()
        {
            DateTime selectedDate = dateTimePickerRange.Value;
            DateTime dayStart;

            var exactLables = new List<string>();
            string xTitle = string.Empty;
            double revenue = 0;
            double serviceRev = 0;
            string title = "REVENUE DURING " + cbbPeriod.Text.ToUpper();
            string period = string.Empty;
            List<Bill> bills;
            List<double> revenues = new List<double>();
            List<double> serviceRevs = new List<double>();
            switch (cbbPeriod.Text.ToString().ToLower())
            {
                case "week":
                    exactLables = weekdayLabels;
                    xTitle = "Week Days";
                    dayStart = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
                    period += " (" + dayStart.ToString("MM/dd/yyy") + "-";
                    for (int i = 0; i < 7; i++)
                    {
                        revenue = 0;
                        foreach (Bill bill in GetBillsInDays(dayStart))
                        {
                            if(bill.Booking != null)
                            {
                                serviceRev += bill.Booking.ServiceCost;
                            }
                            revenue += bill.TotalCost;
                        }

                        revenues.Add(revenue);
                        serviceRevs.Add(serviceRev);
                        dayStart = dayStart.AddDays(1);
                    }
                    period += dayStart.AddDays(-1).ToString("MM/dd/yyy") + ")";
                    break;
                case "month":
                    dayStart = selectedDate.AddDays(-(int)selectedDate.Day + 1);
                    exactLables = GetDayOfMonthLables(dayStart.Year, dayStart.Month);
                    xTitle = "Days";
                    period += " (" + dayStart.ToString("MM/dd/yyy") + "-";
                    for (int i = 1; i <= DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month); i++)
                    {
                        revenue = 0;
                        foreach (Bill bill in GetBillsInDays(dayStart))
                        {
                            if (bill.Booking != null)
                            {
                                serviceRev += bill.Booking.ServiceCost;
                            }
                            revenue += bill.TotalCost;
                        }

                        revenues.Add(revenue);
                        dayStart = dayStart.AddDays(1);
                    }
                    period += dayStart.AddDays(-1).ToString("MM/dd/yyy") + ")";
                    break;
                case "year":
                    exactLables = monthLabels;
                    xTitle = "Months";
                    for (int i = 0; i < 12; i++)
                    {
                        bills = HotelDB.GetDBEntities().Bills.Where(
                            b => b.BillDate.Year.Equals(selectedDate.Year)
                            && b.BillDate.Month.Equals(i + 1)
                            ).ToList();

                        revenue = 0;
                        foreach (Bill bill in bills)
                        {
                            if (bill.Booking != null)
                            {
                                serviceRev += bill.Booking.ServiceCost;
                            }
                            revenue += bill.TotalCost;
                        }

                        revenues.Add(revenue);
                    }
                    break;
            }

            var chart = new CartesianChart
            {
                
                Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = "Revenue",
                        Values = new ChartValues<double>(revenues),
                        Fill = System.Windows.Media.Brushes.DarkCyan,
                        DataLabels = !cbbPeriod.Text.ToLower().Equals("month"),
                        //StackMode = StackMode.Values
                    },
                    /*
                    new ColumnSeries
                    {
                        Title = "Services",
                        Values = new ChartValues<double>(serviceRevs),
                        Fill = System.Windows.Media.Brushes.DarkGreen,
                        DataLabels = true,
                        //StackMode  = StackMode.Values
                    }
                    */

                },
                LegendLocation = LegendLocation.Right,

                AxisX = new AxesCollection
                {
                    new Axis
                    {
                        Title = xTitle,
                        Labels = new ChartValues<string>(exactLables),
                        Separator = new Separator { Step = 1 },
                        Foreground = System.Windows.Media.Brushes.BlueViolet
                    }
                },

                AxisY = new AxesCollection
                        {
                            new Axis
                            {
                                Title = "Revenue",
                                MinValue = 0,
                                LabelFormatter = value => value.ToString(TextDictionary.CURRENCY_FORMAT),
                                Foreground = System.Windows.Media.Brushes.DarkOrange
                            }
                        }

            };

            lblPeriod.Text = period;
            lblRevenueChartTitle.Text = title;
            lblTotalRevenue.Text = "TOTAL: "+ revenues.Sum().ToString(TextDictionary.CURRENCY_FORMAT);
            eHostBarChartRevenue.Child = chart;
        }

        private void DrawPieChartType()
        {
            
            int singleR = 0;
            int doubleR = 0;
            int kingR = 0;
            int queenR = 0;
            double serviceOrderRate = 0;

            DateTime selectedDate = dateTimePickerRange.Value;
            DateTime dayStart;
            List<Bill> bills = new List<Bill>();
            switch (cbbPeriod.Text.ToString().ToLower())
            {
                case "week":
                    dayStart = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
                    bills = GetBillsInDays(dayStart, 7);
                    break;
                case "month":
                    dayStart = selectedDate.AddDays(-(int)selectedDate.Day + 1);
                    bills = GetBillsInDays(dayStart, DateTime.DaysInMonth(dayStart.Year, dayStart.Month));
                    break;
                case "year":
                    bills = GetBillsInYear(dateTimePickerRange.Value.Year);
                    break;
            }

            /*
            int orderCount = 0;
            foreach(Bill bill in bills)
            {
                if (bill.Booking != null && bill.Booking.Room != null)
                {
                    switch (bill.Booking.Room.RoomType)
                    {
                        case "Single":
                            singleR += 1;
                            break;
                        case "Double":
                            doubleR += 1;
                            break;
                        case "King":
                            kingR += 1;
                            break;
                        case "Queen":
                            queenR += 1;
                            break;
                    }

                    if(bill.Booking.ServiceDetails.Count > 0)
                    {
                        orderCount += 1;
                    }

                }
            }
            */
            int orderCount = 0;
            try
            {
                singleR = bills.Count(x => x.Booking.Room.RoomType.Equals(TextDictionary.ROOM_SINGLE));
                doubleR = bills.Count(x => x.Booking.Room.RoomType.Equals(TextDictionary.ROOM_DOUBLE));
                kingR = bills.Count(x => x.Booking.Room.RoomType.Equals(TextDictionary.ROOM_KING));
                queenR = bills.Count(x => x.Booking.Room.RoomType.Equals(TextDictionary.ROOM_QUEEN));
                orderCount = bills.Count(x=>x.Booking.ServiceDetails.Count>0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            serviceOrderRate = (bills.Count != 0) ? (orderCount*1.0 / bills.Count)*100 : 0;


            var series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Single Bed",
                    Values = new LiveCharts.ChartValues<double> { singleR },
                    DataLabels = true
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Double Bed",
                    Values = new LiveCharts.ChartValues<double> { doubleR },
                    DataLabels = true
                },
                
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "King Bed",
                    Values = new LiveCharts.ChartValues<double> { kingR },
                    DataLabels = true
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Title = "Queen Bed",
                    Values = new LiveCharts.ChartValues<double> { queenR },
                    DataLabels = true
                }
            };

            var pieChart = new PieChart()
            {
                Series = series,
                LegendLocation = LegendLocation.Right,
            };

            var chart = new AngularGauge
            {
                Value = serviceOrderRate,
                FromValue = 0,
                ToValue = 100,
                LabelFormatter = value => $"{value:N0}%",
                TicksForeground = System.Windows.Media.Brushes.DarkRed,
                Foreground = System.Windows.Media.Brushes.DarkGreen
            };

           
            

            elementHostOrderRate.Child = chart;


            eHostPieChart.Child = pieChart;
        }

        private void cbbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawBarCharRevenue();
            DrawPieChartType();
        }

        private void dateTimePickerRange_ValueChanged(object sender, EventArgs e)
        {
            DrawBarCharRevenue();
            DrawPieChartType();
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {

        }

        private void frmStatistic_VisibleChanged(object sender, EventArgs e)
        {
            DrawCustomerAgeClassify();
        }
    }
}
