using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace Topres.VSDebugAttacher
{
    public class GeneralOptionsPage : DialogPage
    {
        public GeneralOptionsPage()
        {
            this.ShowAttachToCustomExe1 = true;
            this.ShowAttachToCustomExe2 = true;
            this.ShowAttachToCustomExe3 = true;
            this.ShowAttachToIIS = true;
            this.ShowAttachToIISExpress = true;
            this.ShowAttachToNUnit = true;
        }

        [Category("General")]
        [DisplayName("Show 'Attach to IIS' command")]
        [Description("Show 'Attach to IIS' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToIIS { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to IIS Express command")]
        [Description("Show 'Attach to IIS Express command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToIISExpress { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to NUnit' command")]
        [Description("Show 'Attach to NUnit' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToNUnit { get; set; }

        [Category("General")]
        [DisplayName("Show 'AttachToCustomExe1' command")]
        [Description("Show 'AttachToCustomExe1' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToCustomExe1 { get; set; }

        [Category("General")]
        [DisplayName("Enter proccess name for 'AttachToCustomExe1'")]
        [Description("Enter the process name to be used with 'AttachToCustomExe1' command.")]
        public string CustomExe1Name { get; set; }

        [Category("General")]
        [DisplayName("Show 'AttachToCustomExe2' command")]
        [Description("Show 'AttachToCustomExe2' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToCustomExe2 { get; set; }


        [Category("General")]
        [DisplayName("Enter proccess name for 'AttachToCustomExe2'")]
        [Description("Enter the process name to be used with 'AttachToCustomExe2' command.")]
        public string CustomExe2Name { get; set; }

        [Category("General")]
        [DisplayName("Show 'AttachToCustomExe3' command")]
        [Description("Show 'AttachToCustomExe3' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToCustomExe3 { get; set; }

        [Category("General")]
        [DisplayName("Enter proccess name for 'AttachToCustomExe3'")]
        [Description("Enter the process name to be used with 'AttachToCustomExe3' command.")]
        public string CustomExe3Name { get; set; }


    }
}
