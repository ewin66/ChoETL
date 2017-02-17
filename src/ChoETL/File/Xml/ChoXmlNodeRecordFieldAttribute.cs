﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL
{
    internal enum ChoXmlNodeRecordFieldType { Element, Attribute };

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true )]
    public class ChoXmlNodeRecordFieldAttribute : ChoFileRecordFieldAttribute
    {
        public string XPath
        {
            get;
            private set;
        }

        public string FieldName
        {
            get;
            set;
        }

        internal ChoXmlNodeRecordFieldType XmlNodeRecordFieldType
        {
            get;
            set;
        }

        protected ChoXmlNodeRecordFieldAttribute()
        {

        }

        public ChoXmlNodeRecordFieldAttribute(string xPath)
        {
            XPath = xPath;
        }
    }
}