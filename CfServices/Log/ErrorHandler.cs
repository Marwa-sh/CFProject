using System;
using System.Collections.Generic;
using Cf.Data;

namespace Cf.Services
{
    public interface ILogErrorHandler
    {
        void Handle(EventLog eventLog, Exception ex);
    }

    public partial class DefaultLogErrorHandler : ILogErrorHandler
    {
        public void Handle(EventLog eventLog, Exception ex)
        {
            // TODO: Define the default behaviour when the EventLog fails to be inserted in the database.
            // This may be caused by database connection failure
            // 1. Send e-mail to admin
            // 2. Send SMS to admin
        }
    }
}
