using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArticleEditor.Commands;

namespace ArticleEditor
{
    public class MainViewModel : LambdaNPC
    {
        private MainWindow view;

        public MainViewModel(MainWindow view)
        {
            // TODO: Complete member initialization
            this.view = view;

            BoldCommand = new BaseCommands(view.doc, "b");
            ItalicCommand = new BaseCommands(view.doc, "i");
            ImgCommand = new BaseCommands(view.doc, "img");
            RrCommand = new BaseCommands(view.doc, "rr");
            CodeCommand = new BaseCommands(view.doc, "code");
            QuoteCommand = new BaseCommands(view.doc, "quote");
            CenterCommand = new BaseCommands(view.doc, "center");
            LeftCommand = new BaseCommands(view.doc, "left");
            RightCommand = new BaseCommands(view.doc, "right");
            JustyfyCommand = new BaseCommands(view.doc, "justify");
            YoutubeCommand = new BaseCommands(view.doc, "youtube");
            UCommand = new BaseCommands(view.doc, "u");
            DelCommand = new BaseCommands(view.doc, "del");
            HrCommand = new HrCommand(view.doc);
            HashCommand = new BaseCommands(view.doc, "#");
            UrlCommand = new UrlCommand(view.doc);
            AudioCommand = new BaseCommands(view.doc, "audio");
            SizeCommand = new SizeCommand(view.doc);
            VoteHeaderOpenCommand = new BaseCommands(view.doc, "vote");
            VoteHeaderAnonCommand = new BaseCommands(view.doc, "votea");
            VoteVariantCommand = new BaseCommands(view.doc, "v");
            ColorCommand = new ColorCommand(view.doc);
        }

        public BaseCommands BoldCommand { get; set; }
        public BaseCommands ItalicCommand { get; set; }
        public BaseCommands ImgCommand { get; set; }
        public BaseCommands RrCommand { get; set; }
        public BaseCommands CodeCommand { get; set; }
        public BaseCommands QuoteCommand { get; set; }
        public BaseCommands CenterCommand { get; set; }
        public BaseCommands LeftCommand { get; set; }
        public BaseCommands RightCommand { get; set; }
        public BaseCommands YoutubeCommand { get; set; }
        public BaseCommands UCommand { get; set; }
        public BaseCommands DelCommand { get; set; }
        public HrCommand HrCommand { get; set; }
        public UrlCommand UrlCommand { get; set; }
        public BaseCommands JustyfyCommand { get; set; }
        public BaseCommands HashCommand { get; set; }
        public BaseCommands AudioCommand { get; set; }
        public SizeCommand SizeCommand { get; set; }
        public BaseCommands VoteHeaderOpenCommand { get; }
        public BaseCommands VoteHeaderAnonCommand { get; }
        public BaseCommands VoteVariantCommand { get; }
        public ColorCommand ColorCommand { get; }
    }
}
