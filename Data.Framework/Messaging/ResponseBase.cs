using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data.Messaging
{
    public class ResponseBase<T>
    {
        public T ResponseObject { get; set; }
        public string ErrorMessage { get; private set; }
        public Exception Exception { get; set; }
        public string FriendlyErrorMessage { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }
        public bool Result { get { return String.IsNullOrEmpty(ErrorMessage) || Exception == null; }  }

        public ResponseBase(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage.Trim();
        }

        public ResponseBase(Exception ex)
        {
            this.Exception = ex;
        }

        public ResponseBase()
        {
        }
    }
}
