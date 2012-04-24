using System;

namespace TS.Sys.Platform.Widgets
{
    public class LabelComboxOption
    {
        private String value;
        private String text;
        private String comment;

        public LabelComboxOption(String value, String text, String comment)
        {
            this.value = value;
            this.text = text;
            this.comment = comment;
        }

        public String Value
        {
            set { this.value = value; }
            get { return this.value; }
        }

        public String Text
        {
            set { this.text = value; }
            get { return this.text; }
        }

        public String Comment
        {
            set { this.comment = value; }
            get { return this.comment; }
        }

        public override string ToString()
        {
            return this.text;
        }
    }
}
