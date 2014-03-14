﻿using System.Collections.Generic;

namespace TestStack.BDDfy.Processors
{
    public class HtmlReportViewModel : FileReportModel
    {
        public HtmlReportViewModel(IHtmlReportConfiguration configuration, IEnumerable<Story> stories)
            : base(stories)
        {
            Configuration = configuration;
        }

        public bool UseCustomStylesheet { get; set; }
        public bool UseCustomJavascript { get; set; }

        public IHtmlReportConfiguration Configuration { get; private set; }
    }
}