using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDtester.i18n
{
    internal class I18nEn : I18n
    {
        public override string Lang => "en";
        public override string ButtonGo => "Go";
        public override string ButtonCancel => "Cancel";
        public override string StatusGoHint => "Press [Go] to start.";
        public override string StatusStarting => "Starting...";
        public override string StatusWriting => "Writing";
        public override string StatusVerifying => "Verifying";
        public override string StatusCancelled => "Cancelled:";
        public override string LabelDrive => "Drive:";
        public override string LabelExplain => "No data will be modified on drive, the used areas will not be tested, better test with an empty drive.";
        public override string LabelWriteSpeed => "Write Speed:";
        public override string LabelReadSpeed => "Read Speed:";
        public override string MsgValidErrorTitle => "Validation error";
        public override string MsgValidErrorText => "Validation errors found.\r\n¿Do you want to keep the test file for analisys?";
        public override string AboutTitle => "About Sd Tester";
        public override string AboutHeader => "Sd Tester 1.0";
    }
}
