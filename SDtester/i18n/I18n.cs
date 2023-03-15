using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDtester.i18n
{
    public abstract class I18n
    {
        protected I18n() { }
        private static I18n last;

        public static I18n Get(string lang = null)
        {
            List<I18n> all = GetAll();
            if (lang == null)
                lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower();
            if (last != null && last.Lang == lang)
                return last;
            foreach (var i18n in all)
                if (i18n.Lang == lang)
                    return last = i18n;
            return all[0];
        }

        private static List<I18n> GetAll()
        {
            return new List<I18n> {
                new I18nEn(),
                new I18nEs(),
            };
        }

        public abstract string Lang { get; }
        public abstract string ButtonGo { get; }
        public abstract string ButtonCancel { get; }
        public abstract string StatusGoHint { get; }
        public abstract string StatusStarting { get; }
        public abstract string StatusWriting { get; }
        public abstract string StatusVerifying { get; }
        public abstract string StatusCancelled { get; }
        public abstract string LabelDrive { get; }
        public abstract string LabelExplain { get; }
        public abstract string LabelWriteSpeed { get; }
        public abstract string LabelReadSpeed { get; }
        public abstract string MsgValidErrorTitle { get; }
        public abstract string MsgValidErrorText { get; }
        public abstract string AboutTitle { get; }
        public abstract string AboutText { get; }
        public abstract string AboutTranslation { get; }
    }
}
