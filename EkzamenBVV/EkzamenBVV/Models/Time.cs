using SQLite;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EkzamenBVV.Models
{
    class Time
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text 
        {
            get
            {
                using (WebClient webClient = new WebClient())
                {
                    return webClient.DownloadString($"http://numbersapi.com/{Id}?notfound=ceil");
                }
            }
        }
    }
}
