﻿using System;

namespace BankScraper.Models.Nubank
{
    /// <summary>
    /// Events
    /// </summary>
    public class NubankEvents
    {
       
        public string category { get; set; }
        public string title { get; set; }
        public string amount { get; set; }
        public string time { get; set; }
        public string message { get; set; }
        public string id { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:BankScraper.Models.Events"/> class.
        /// </summary>
        public NubankEvents(){}
     
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BankScraper.Models.Events"/> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Time">Time.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Id">Identifier.</param>
        public NubankEvents(string Category, string Title, string Amount, string Time, string Message, string Id)
        {
            category = Category;
            title = Title;
            amount = Amount;
            time = Time;
            message = Message;
            id = Id;
        }
    }
}
