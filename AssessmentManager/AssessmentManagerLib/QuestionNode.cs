using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentManager
{
    public class QuestionNode : TreeNode
    {
        private Question question;

        public QuestionNode(Question question)
        {
            Question = question;
            Text = question.Name;
        }

        public QuestionNode(Question question, QuestionNode[] subQuestions) : this(question)
        {
            //TODO:: record the passes children nodes
            Nodes.Clear();
            foreach (var q in subQuestions)
            {
                Nodes.Add(q);
            }
        }

        public Question Question
        {
            get
            {
                return question;
            }
            private set
            {
                question = value;
            }
        }

        public bool CanMoveUp
        {
            get
            {
                if (TreeView != null)
                {
                    if (Index == 0)
                        return false;
                    return true;
                }
                return false;
            }
        }

        public bool CanMoveDown
        {
            get
            {
                if (TreeView != null)
                {
                    if (Parent != null)
                    {
                        return (Index != Parent.Nodes.Count - 1);
                    }
                    else
                        return (Index != TreeView.Nodes.Count - 1);
                }
                return false;
            }
        }
    }
}
