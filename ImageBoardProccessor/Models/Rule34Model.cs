﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Xml.Schema;

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 

namespace ImageBoardProcessor.Models
{

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false,DataType ="string",ElementName="posts")]
    public partial class Rule34Model
    {

        private Image[] postField;

        private string countField;

        private string offsetField;

        /// <remarks/>
        [XmlElementAttribute("post", Form = XmlSchemaForm.Unqualified)]
        public Image[] post
        {
            get
            {
                return this.postField;
            }
            set
            {
                this.postField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true,IncludeInSchema = true, Namespace ="",TypeName ="post")]
    public partial class Image
    {

        private string scoreField;

        private string file_urlField;

        private string parent_idField;

        private string preview_urlField;

        private string ratingField;

        private string tagsField;

        private string idField;

        private string creator_idField;

        private string sourceField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string file_url
        {
            get
            {
                return this.file_urlField;
            }
            set
            {
                this.file_urlField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string parent_id
        {
            get
            {
                return this.parent_idField;
            }
            set
            {
                this.parent_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string creator_id
        {
            get
            {
                return this.creator_idField;
            }
            set
            {
                this.creator_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

    }

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private Rule34Model[] itemsField;

        /// <remarks/>
        [XmlElementAttribute("posts")]
        public Rule34Model[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

}