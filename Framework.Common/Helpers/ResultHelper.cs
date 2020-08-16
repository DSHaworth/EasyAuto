using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Helpers
{
    public abstract class ResultHelper
    {
        public bool IsValid { get; set; }

        public IList<string> ErrorMessages { get; set; }

        #region Constructors

        protected ResultHelper()
        {
            IsValid = true;
            ErrorMessages = null;
        }

        protected ResultHelper(Exception exc)
        {
            IsValid = false;
            ErrorMessages = new List<string> { exc.Message };
        }

        //protected ResultHelper(params IList<ValidationResult>[] validationList)
        //{
        //    IsValid = false;
        //    ErrorMessages = new List<string>();
        //    foreach (var validationResultItem in validationList)
        //    {
        //        foreach (var validationResult in validationResultItem)
        //        {
        //            ErrorMessages.Add(validationResult.ErrorMessage);
        //        }
        //    }
        //}

        #endregion
    }

    public class ResultList<T> : ResultHelper
    {
        public IList<T> Items { get; set; }

        public ResultList(IList<T> list)
        {
            Items = list;
        }

        public ResultList(Exception exc)
            : base(exc)
        {
            Items = null;
        }

        //public ResultList(params IList<ValidationResult>[] validationList)
        //    : base(validationList)
        //{
        //    Items = null;
        //}
    }

    public class ResultList : ResultHelper
    {
        //[DataMember]
        public IList<object> Items { get; set; }

        public ResultList(IList<object> list)
        {
            Items = list;
        }

        public ResultList(Exception exc)
            : base(exc)
        {
            Items = null;
        }

        //public ResultList(params IList<ValidationResult>[] validationList)
        //    : base(validationList)
        //{
        //    Items = null;
        //}
    }

    public class ResultItem<T> : ResultHelper
    {
        public T Item { get; set; }

        public ResultItem(T item)
        {
            Item = item;
        }

        public ResultItem(Exception exc)
            : base(exc)
        {
            Item = default(T);
        }

        //public ResultItem(params IList<ValidationResult>[] validationList)
        //    : base(validationList)
        //{
        //    Item = default(T);
        //}
    }

    public class ResultItem : ResultHelper
    {
        public object Item { get; set; }

        public ResultItem(object item)
        {
            Item = item;
        }

        public ResultItem(Exception exc)
            : base(exc)
        {
            Item = default(object);
        }

        //public ResultItem(params IList<ValidationResult>[] validationList)
        //    : base(validationList)
        //{
        //    Item = default(object);
        //}
    }
}
