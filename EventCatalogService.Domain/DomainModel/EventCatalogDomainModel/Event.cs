using EventCatalogService.Domain.DomainModel.EventCatalogDomainModel.Entities;
using EventCatalogService.Domain.DomainModel.EventCatalogDomainModel.Events;
using Microservice.Framework.Domain.Aggregates;
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

            : base(id)
        {
        }


        #endregion


        #region  Properties

        public string EventName { get; set; }

        public decimal Price { get; set; }
        public string Artist { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public CategoryId CategoryId { get; set; }

        #endregion

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
            ImageUrl = imageUrl;
            CategoryId = categoryId;

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