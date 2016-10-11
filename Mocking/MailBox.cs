using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {

        List<Mail> mail = new List<Mail>();

        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

        internal void Add(Mail o)
        {
            mail.Add(o);
            NumReceivedMessages++;

        }

        internal string GetLatestMessageText()
        {
            Mail thisMail = mail[mail.Count - 1];
            return thisMail.Content;

        }
    }
}