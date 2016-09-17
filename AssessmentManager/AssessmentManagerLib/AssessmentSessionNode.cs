﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentManager
{
    public class AssessmentSessionNode : TreeNode
    {
        private AssessmentSession session;

        public AssessmentSessionNode(AssessmentSession session)
        {
            this.session = session;
            Text = session.AssessmentInfo.AssessmentName;
            Name = Text;
        }

        public AssessmentSession Session
        {
            get
            {
                return session;
            }
            set
            {
                session = value;
            }
        }

    }
}
