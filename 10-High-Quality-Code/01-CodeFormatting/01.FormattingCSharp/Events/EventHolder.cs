namespace Events
{
    using System;
    using Wintellect.PowerCollections;
    
    public class EventHolder
    {
        private MultiDictionary<string, Event> eventsByTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> eventsByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);

            this.eventsByTitle.Add(title.ToLower(), newEvent);
            this.eventsByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int deletedCount = 0;

            foreach (var eventToRemove in this.eventsByTitle[title])
            {
                this.eventsByDate.Remove(eventToRemove);
                deletedCount++;
            }

            this.eventsByTitle.Remove(title);
            
            Messages.EventDeleted(deletedCount);
        }

        public void ListEvents(DateTime date, int count)
        {
            var eventFrom = new Event(date, string.Empty, string.Empty);
            var eventsToShow = this.eventsByDate.RangeFrom(eventFrom, true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}