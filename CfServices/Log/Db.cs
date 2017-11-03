using System;
using System.Configuration;
using Cf.Data;
using Cf.Services.Exceptions;

namespace Cf.Services
{
    public static partial class DbServices
    {
        /// <summary>
        /// Add a new eventlog record coming from a user instance
        /// </summary>
        /// <param name="user">Identifier of the user in charge</param>
        /// <param name="db">Database object on which the log will be executed</param>
        /// <param name="categoryName">Event Category Name</param>
        /// <param name="sourceName">Event Source Name</param>
        /// <param name="statusName">Event Status Name</param>
        /// <param name="formatter">XML formatter</param>
        /// <param name="handler">A handler that defines the behaviour when the method fails to insert the EventLog to the Database</param>
        /// <returns>The inserted EvantLog</returns>
        internal static EventLog Log(int user, Db db, string categoryName, string sourceName, string statusName, XmlFormatterBase formatter, ILogErrorHandler handler = null)
        {
            EventLog eventLog = new EventLog();
            try
            {
                EventCategory eventCategory = EventCategoryServices.GetByNameFirstOrNull(categoryName, db);
                if (eventCategory == null)
                {
                    eventCategory = EventCategoryServices.GetByNameFirstOrNull("Uncategorized", db);
                }
                EventSource eventSource = EventSourceServices.GetByNameFirstOrNull(sourceName, db);
                if (eventSource == null)
                {
                    eventSource = EventSourceServices.GetByNameFirstOrNull("Uncategorized", db);
                }
                EventStatus eventStatus = EventStatusServices.GetByNameFirstOrNull(statusName, db);
                if (eventStatus == null)
                {
                    eventStatus = EventStatusServices.GetByNameFirstOrNull("Error", db);
                }
                eventLog.EventCategory = eventCategory.Id;
                eventLog.EventSource = eventSource.Id;
                eventLog.EventStatus = eventStatus.Id;
                eventLog.Date = DateTime.Now;
                if (eventCategory.Name == "Uncategorized")
                    formatter = new UncategorizedXmlFormatter(categoryName, formatter.Parameters);
                eventLog.Parameters = formatter.ToString();
                eventLog.User = user;

                eventLog = EventLogServices.Insert(eventLog, db);
            }
            catch (Exception ex)
            {
                if (handler == null)
                    handler = new DefaultLogErrorHandler();
                handler.Handle(eventLog, ex);
            }
            return eventLog;
        }

        internal static EventLog Log(int user, Db db, int categoryId, int sourceId, int statusId, XmlFormatterBase formatter, ILogErrorHandler handler = null)
        {
            EventLog eventLog = new EventLog();
            eventLog.EventCategory = categoryId;
            eventLog.EventSource = sourceId;
            eventLog.EventStatus = statusId;
            eventLog.User = user;
            eventLog.Date = DateTime.Now;
            if (categoryId == (int)EventCategoryEnum.Uncategorized)
                formatter = new UncategorizedXmlFormatter(EventCategoryEnum.Uncategorized.ToString(), formatter.Parameters);
            eventLog.Parameters = formatter.ToString();
            try
            {
                eventLog = EventLogServices.Insert(eventLog, db);
            }
            catch(Exception ex)
            {
                EventCategory category = EventCategoryServices.Get(categoryId, db);
                if (category != null)
                    eventLog.EventCategory = category.Id;
                else
                    eventLog.EventCategory = (int)EventCategoryEnum.Uncategorized;
                EventSource source = EventSourceServices.Get(sourceId, db);
                if (source != null)
                    eventLog.EventSource = source.Id;
                else
                    eventLog.EventSource = (int)EventSourceEnum.Uncategorized;
                EventStatus status = EventStatusServices.Get(statusId, db);
                if (status != null)
                    eventLog.EventStatus = status.Id;
                else
                    eventLog.EventStatus = (int)EventStatusEnum.Error;
                eventLog.Date = DateTime.Now;
                try
                {
                    eventLog = EventLogServices.Insert(eventLog, db);
                }
                catch(Exception exx)
                {
                    if (handler == null)
                        handler = new DefaultLogErrorHandler();
                    handler.Handle(eventLog, exx);
                }
            }
            return eventLog;
        }

   //     internal static CfException LogError(EventLog eventLog, CfException ex, Db db)
   //     {
			//string trace = Environment.StackTrace;
   //         if (ex.StackTrace != null)
   //             trace = ex.StackTrace;
   //         else if (ex.InnerException != null && ex.InnerException.StackTrace != null)
   //             trace = ex.InnerException.StackTrace;
   //         EventLogError error = new EventLogError();
   //         error.EventLog = eventLog.Id;
   //         error.Number = ex.Number;
   //         error.Message = ex.Message;
   //         error.StackTrace = trace;
   //         EventLogErrorServices.Insert(error, db);

			//ErrorDefinition errorDefinition = new ErrorDefinition();
			//errorDefinition.Message = ex.Message;
			//errorDefinition.LocalizedMessage = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UnexpectedError"); ;
			//errorDefinition.LikeExpression = ex.Message;
			//errorDefinition = ErrorDefinitionServices.Insert(errorDefinition, db);
			//ex.ErrorDefinition = errorDefinition;
   //     }

        internal static CfException LogError(EventLog eventLog, Exception ex, string module, Db db)
        {
            CfException exception = new CfException(module, eventLog.EventCategory, ex.Message, ex);
			string trace = Environment.StackTrace;
			if (exception.StackTrace != null)
				trace = exception.StackTrace;
			else if (exception.InnerException != null && exception.InnerException.StackTrace != null)
				trace = exception.InnerException.StackTrace;
			EventLogError error = new EventLogError();
			error.EventLog = eventLog.Id;
			error.Number = exception.Number;
			error.Message = exception.Message;
			error.StackTrace = trace;
			EventLogErrorServices.Insert(error, db);

			ErrorDefinition errorDefinition = new ErrorDefinition();
			errorDefinition.Message = exception.Message;
			errorDefinition.LocalizedMessage = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UnexpectedError");
			errorDefinition.LikeExpression = exception.Message;
			errorDefinition = ErrorDefinitionServices.Insert(errorDefinition, db);
			exception.ErrorDefinition = errorDefinition;

			return exception;
        }
    }
}
