﻿namespace SlideBuilder.Models
{
    using System.Text;

    public class MDShape
    {
        public MDShape()
        {
            this.Line = new StringBuilder();
        }

        public MDShape(string line)
            :this()
        {
            this.Line.Append(line);
        }

        public StringBuilder Line { get; set; }

        public int IndentCount { get; set; }

        public bool IsTitle { get; set; }

        public bool IsSecTitle { get; set; }

        public bool IsBalloon { get; set; }

        public bool IsCode { get; set; }

        public bool IsMultiCode { get; set; }

        public bool AddedCodeOpen { get; set; }

        public override string ToString()
        {
            return this.Line.ToString();
        }
    }
}
