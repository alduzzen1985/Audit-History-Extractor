﻿using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AuditHistoryExtractor
{
    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("BackgroundColor", "#26577F"),
    ExportMetadata("PrimaryFontColor", "White"),
    ExportMetadata("SecondaryFontColor", "Gray"),

    ExportMetadata("SmallImageBase64", "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"),
    ExportMetadata("BigImageBase64", "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"),
    ExportMetadata("Name", "Audit History Extractor"),
    ExportMetadata("Description", "A plugin to view and save in a file the fields changes.")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }
        //evolutive
    }
}
