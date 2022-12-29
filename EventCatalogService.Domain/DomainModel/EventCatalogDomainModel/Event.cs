using Microservice.Framework.Domain.Aggregates;
using Microservice.Framework.Domain.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the link to the videos https://www.youtube.com/watch?v=eHiDJR6sL58

namespace EventCatalogService.Domain.DomainModel.EventCatalogDomainModel
{
    public class Event : AggregateRoot<Event, EventId>
    {
        #region Contructors
        public Event()
            : this(null)
        {
        }

        public Event(EventId id)

            : base()
        { }


        #endregion


        #region  Properties

        public string Eventname { get; set; }

        public decimal Price { get; set; }
        public string Artist { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string imageUrl { get; set; }

        public CategoryId CategoryId { get; set; }

        #region Methods 

        public void AddEvent(

                string eventName,
                int price,
                string artist,
                DateTime date,
                string description,
                string imageUrl,
                CategoryId categoryId)


        {
            EventName = eventName;
            Price = price;
            Artist = artist;
            Date = date;
            Description = description;
            imageUrl = imageUrl;
            CategoryId= categoryId;

            Emit(new AddedEvent(
                eventName,
                price,
                artist,
                date,
                description,
                imageUrl,
                categoryId));
        }
        #endregion
    }


}
}
