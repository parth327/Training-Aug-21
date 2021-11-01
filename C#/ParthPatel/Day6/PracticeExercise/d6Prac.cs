using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6Prac
{
    //Example 1
    //public class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        Document doc = new Document();
    //        doc.Text = "Document text goes here";
    //        var BlogPoster = new BlogPoster();
    //        var blogDelegate = new Document.SendDoc(BlogPoster.PostToBlog);
    //        doc.ReportSendingResult(blogDelegate);
    //        var emailSender = new EmailSender();
    //        var emailDelegate = new Document.SendDoc(emailSender.SendEmail);
    //        doc.ReportSendingResult(emailDelegate);
    //        Console.ReadLine();
    //    }
    //}
    //public class Document
    //{
    //    public string Text { get; set; }
    //    public delegate int SendDoc();
    //    public void ReportSendingResult(SendDoc sendingDelegate)
    //    {
    //        if (sendingDelegate() == 0)
    //        {
    //            Console.WriteLine("Success");
    //        }
    //        else 
    //        {
    //            Console.WriteLine("Unable to Send!");
    //        }
    //    }
    //}
    //public class EmailSender
    //{
    //    private int sendResult;
    //    public int SendEmail()
    //    {
    //        Console.WriteLine("Simulating sending Email...");
    //        sendResult = 0;
    //        return sendResult;
    //    }
    //}
    //public class BlogPoster
    //{
    //    public int PostToBlog()
    //    {
    //        Console.WriteLine("Posting to Blog...");
    //        return 0;
    //    }
    //}
    //Example 2
    public class Program
    {
        static void Main(string[] args)
        {
            var theClock = new Clock();
            var visibleClock = new VisibleClock();
            visibleClock.Subscribe(theClock);
            theClock.RunClock();
        }
    }
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;
        public delegate void TimeChangeHandler(
            object clock, TimeEventArgs timeInfo);
        
        public event TimeChangeHandler TimeChanged;
        public void RunClock() 
        {
            while (true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;
                if (currentTime.Second != this.second)
                {
                    TimeEventArgs timeEventArgs = new TimeEventArgs();
                    {
                        hour = currentTime.Hour;
                        minute = currentTime.Minute;
                        second = currentTime.Second;
                    };
                    if (TimeChanged != null)
                    {
                        TimeChanged(this, timeEventArgs);
                    }
                    this.second = currentTime.Second;
                    this.minute = currentTime.Minute;
                    this.hour = currentTime.Hour;
                }
            }
        }
    }
    public class VisibleClock 
    {
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }
        public void NewTime(object theClock, TimeEventArgs e)
        {
            Console.WriteLine("{0}:{1}:{2}", e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
        }
    }
    public class Logger
    {
        public void Subscribe(Clock theClock) 
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }
        public void NewTime(object theClock, TimeEventArgs e)
        {
            Console.WriteLine("Logging event at {0}:{1}:{2}",
                e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
        }
    }
}











